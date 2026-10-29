using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Net;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace familiada
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            filePath = "baza_danych.txt"; // Path to the text file
            pytania = new int[5];
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            var numberOfLines = 0;
            try
            {
                // Read all lines from the file
                var lines = File.ReadAllLines(filePath);

                if (lines.Length > 0)
                {
                    // Get the last line
                    string lastLine = lines[^1]; // Equivalent to lines[lines.Length - 1]

                    // Find the number before the first ',' in the last line
                    int commaIndex = lastLine.IndexOf(',');

                    if (commaIndex > 0) // Ensure there is a ',' and something before it
                    {
                        string numberPart = lastLine.Substring(0, commaIndex);

                        // Try parsing the number
                        if (int.TryParse(numberPart, out int number))
                        {
                            Console.WriteLine($"The number before the first ',' in the last line is: {number}");
                            numberOfLines = number + 1;
                        }
                        else
                        {
                            Console.WriteLine("Could not parse the number before the ',' in the last line.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The last line does not contain a ',' or the format is incorrect.");
                    }
                }
                else
                {
                    Console.WriteLine("The file is empty.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            TextBox[] textBoxes = { textBox12, textBox34, textBox14, textBox13, textBox20, textBox19,
                textBox24, textBox23, textBox28, textBox27, textBox32, textBox31, textBox16,
                textBox15, textBox18, textBox17, textBox22, textBox21, textBox26, textBox25, textBox30, textBox29};

            try
            {
                // Take only the first elements
                TextBox[] firstXTextBoxes = textBoxes.Take(Convert.ToInt16(textBox34.Text) * 2 + 2).ToArray();
                string mergedText = string.Join(",", firstXTextBoxes.Select(tb => tb.Text));
                mergedText = numberOfLines + "," + mergedText;

                // Open a StreamWriter to write to the file
                using (StreamWriter writer = new StreamWriter(filePath, append: true))
                {
                    writer.WriteLine(mergedText); // Write the line
                }

                MessageBox.Show("Dodano do bazy nowe pytanie! ID: : " + mergedText);
            }
            catch
            {
                MessageBox.Show("Nieprawidłowy format");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Read all lines from the file
                var lines = File.ReadAllLines(filePath);

                // Create a StringBuilder to accumulate the results
                var displayContent = new StringBuilder();

                // Process each line to extract the first two items
                foreach (var line in lines)
                {
                    var parts = line.Split(','); // Split the line by ','

                    if (parts.Length >= 2) // Ensure there are at least two parts
                    {
                        displayContent.AppendLine($"{parts[0]}, {parts[1]}"); // Add the first two items
                    }
                    else if (parts.Length == 1) // If only one part exists, show it
                    {
                        displayContent.AppendLine($"{parts[0]}");
                    }
                }

                // Display the result in a dialog window
                MessageBox.Show(displayContent.ToString(), "BAZA DANYCH", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle any errors and display a message
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            string doUsunieciaString = textBox33.Text; // Get the number to find from the textbox
            short idToDelete = Convert.ToInt16(doUsunieciaString); // Convert the input to a number

            try
            {
                // Read all lines from the file into a list
                var lines = File.ReadAllLines(filePath).ToList();

                // Find the index of the line that starts with the specified number before the first ','
                int lineToDelete = lines.FindIndex(line =>
                {
                    int commaIndex = line.IndexOf(',');
                    if (commaIndex > 0) // Ensure there's a ',' in the line
                    {
                        string numberPart = line.Substring(0, commaIndex); // Extract the part before the comma
                        return short.TryParse(numberPart, out short parsedNumber) && parsedNumber == idToDelete;
                    }
                    return false; // If no ',' or parsing fails, skip the line
                });

                // Check if the line was found
                if (lineToDelete >= 0)
                {
                    // Remove the specified line
                    lines.RemoveAt(lineToDelete);

                    // Write the updated lines back to the file
                    File.WriteAllLines(filePath, lines);

                    MessageBox.Show("Usunięto z bazy pytanie o ID: " + doUsunieciaString);
                }
                else
                {
                    MessageBox.Show("Nie znaleziono w bazie pytania o ID: " + doUsunieciaString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd: " + ex.Message);
            }

        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // czytaj parametry
            TextBox[] textBoxes = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6,
                textBox7, textBox8, textBox9, textBox10};

            int liczbaRund = Convert.ToInt16(numericUpDown1.Value);

            pytania = new int[liczbaRund]; // Array size is determined by 'liczbaRund'
            int index = 0;
            for (int i = 0; i < liczbaRund; i++)
            {
                if (int.TryParse(textBoxes[i].Text, out int value))
                {
                    pytania[index] = value;  // Store the value in the array
                    index++;
                }
                else
                {
                    MessageBox.Show($"Please enter a valid integer in TextBox {i + 1}.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            // Optional: Output values to check
            string valuesText = string.Join(", ", pytania);
            MessageBox.Show($"Saved values: {valuesText}", "Values Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string OUTLOOK_EMAIL = "chelkowska.marta99@outlook.com";
            string OUTLOOK_PASSWORD = "hudwfhzvxijazgnd";

            try
            {
                // Retrieve credentials from environment variables
                string email = OUTLOOK_EMAIL;
                string password = OUTLOOK_PASSWORD;

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(email);
                mail.To.Add(textBox11.Text);
                mail.Subject = "Secure Email from Outlook SMTP";
                mail.Body = "This email uses credentials from environment variables.";

                SmtpClient smtp = new SmtpClient("smtp.office365.com", 587);
                smtp.Credentials = new NetworkCredential(email, password);
                smtp.EnableSsl = true;

                smtp.Send(mail);

                MessageBox.Show("Email sent successfully!");
            }
            catch (Exception ex)
            {
                textBox11.Text = "Error: " + ex.Message;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                // Read all lines from the file
                var lines = File.ReadAllLines(filePath);

                // Create a StringBuilder to accumulate the results
                var displayContent = new StringBuilder();

                // Process each line to extract the first two items
                foreach (var line in lines)
                {
                    var parts = line.Split(','); // Split the line by ','

                    if (parts.Length >= 2) // Ensure there are at least two parts
                    {
                        displayContent.AppendLine(""); // Add the empty line
                        displayContent.AppendLine(""); // Add the empty line
                        displayContent.AppendLine($"{parts[0]}. {parts[1]}"); // Add the first two items
                        int licznikOdpowiedzi = 0;
                        for(int i=3; i<parts.Length; i += 2)
                        {
                            licznikOdpowiedzi++;
                            displayContent.AppendLine($"    {licznikOdpowiedzi}. {parts[i]}"); // Add the first two items
                        }
                    }
                    else if (parts.Length == 1) // If only one part exists, show it
                    {
                        displayContent.AppendLine($"{parts[0]}");
                    }
                }

                File.WriteAllText("baza_danych_export.txt", displayContent.ToString());
            }
            catch (Exception ex)
            {
                // Handle any errors and display a message
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
