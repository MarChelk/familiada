using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.ComponentModel.DataAnnotations;

namespace familiada
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            przyciskiOdpowiedzi = new System.Windows.Forms.Button[] { button3, button4, button5, button6, button7, button8, button17, button18 };
            przyciskiRundy = new System.Windows.Forms.Button[] { button9, button10, button11, button12, button13, button14, button16 };
            labeleOdpowiedzi = new System.Windows.Forms.Label[] { label3, label4, label5, label6, label7, label8, label22, label24 };
            labelePunkty = new System.Windows.Forms.Label[] { label11, label12, label13, label14, label15, label16, label21, label23 };

            // Show the setup dialog
            using (var setupDialog = new Form2())
            {
                var result = setupDialog.ShowDialog();
                // Retrieve parameters
                pytania = setupDialog.pytania;
            }

            // Define your variable 'pytania' with the value you want to match
            string filePath = "baza_danych.txt"; // Path to your text file

            // Initialize the two-dimensional arrays (assuming a maximum of 100 rows and 5 columns for both arrays)
            odpowiedzi = new string[10, 10]; // Array for string values (4th, 6th, 8th, ...)
            punkty = new int[10, 10]; // Array for integer values (5th, 7th, 9th, ...)

            int rowIndex = 0; // Variable to keep track of the current row in the arrays

            try
            {
                // Read all lines from the file
                var lines = File.ReadLines(filePath);

                foreach (int pytanie in pytania)
                {
                    foreach (var line in lines)
                    {
                        // Split each line by commas
                        var values = line.Split(',');

                        // Ensure the line has at least 3 values (because we need 4th, 5th, and 6th columns)
                        if (values.Length >= 3)
                        {
                            // Check if the first value in the line matches any value in 'pytania'
                            if (Convert.ToInt16(values[0]) == pytanie)
                            {
                                // Extract string values (4th, 6th, 8th, ...) into odpowiedzi
                                int odpowiedziIndex = 0; // Index for the 'odpowiedzi' array
                                int punktyIndex = 0; // Index for the 'punkty' array

                                // Loop through the columns starting from the 4th value (index 3)
                                for (int i = 3; i < values.Length; i += 2) // 4th, 6th, 8th, ...
                                {
                                    odpowiedzi[rowIndex, odpowiedziIndex++] = values[i].Trim(); // Store string values
                                }

                                // Loop through the columns starting from the 5th value (index 4)
                                for (int i = 4; i < values.Length; i += 2) // 5th, 7th, 9th, ...
                                {
                                    // Try to parse the 5th, 7th, 9th values as integers
                                    if (int.TryParse(values[i].Trim(), out int punkt))
                                    {
                                        punkty[rowIndex, punktyIndex++] = punkt; // Store integer values
                                    }
                                }

                            }
                        }
                    }
                    // Increment rowIndex to process the next row in the arrays
                    rowIndex++;
                }

                // After processing all lines, print the results for checking
                Console.WriteLine("Odpowiedzi (String values):");
                for (int i = 0; i < rowIndex; i++)
                {
                    for (int j = 0; j < 10; j++) // Print the first 5 columns for odpowiedzi
                    {
                        if (odpowiedzi[i, j] != null)
                            Console.Write(odpowiedzi[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\nPunkty (Integer values):");
                for (int i = 0; i < rowIndex; i++)
                {
                    for (int j = 0; j < 10; j++) // Print the first 5 columns for punkty
                    {
                        Console.Write(punkty[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }

            runda = 0;
            strataA = 0;
            strataB = 0;
            sumaA = 0;
            sumaB = 0;
            suma = 0;
            label17.Visible = false;
            label18.Visible = false;
            czy = false;
            czy_liczyc = false;

            for (int i = 0; i < przyciskiOdpowiedzi.Length; i++)
            {
                przyciskiOdpowiedzi[i].Enabled = false;
            }

            for (int i = pytania.Length; i < przyciskiRundy.Length; i++)
            {
                przyciskiRundy[i].Visible = false;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            strataA += 1;
            if (strataA == 1)
            {
                this.pictureBox1.Load("iks.png");
            }
            if (strataA == 2)
            {
                this.pictureBox2.Load("iks.png");
            }
            if (strataA == 3)
            {
                this.pictureBox3.Load("iks.png");
            }
            using (var soundPlayer = new System.Media.SoundPlayer(@"zla.wav"))
            {
                soundPlayer.Play();
            }
        }

        private void nowa_runda(int runda)
        {
            for (int i = 0; i < przyciskiOdpowiedzi.Length; i++)
            {
                przyciskiOdpowiedzi[i].Enabled = true;
                przyciskiOdpowiedzi[i].Visible = true;
            }

            for (int i = 0; i < labeleOdpowiedzi.Length; i++)
            {
                labeleOdpowiedzi[i].Text = ".....................................";
            }

            for (int i = 0; i < labelePunkty.Length; i++)
            {
                labelePunkty[i].Text = ".....";
            }

            this.pictureBox4.Load("tlo.png");
            this.pictureBox5.Load("tlo.png");
            this.pictureBox6.Load("tlo.png");
            this.pictureBox1.Load("tlo.png");
            this.pictureBox2.Load("tlo.png");
            this.pictureBox3.Load("tlo.png");

            this.label2.Text = "Runda " + runda.ToString();
            this.label26.Text = pytania[runda - 1].ToString();

            strataA = 0;
            strataB = 0;
            suma = 0;
            czy_liczyc = true;
            label10.Text = suma.ToString();
            using (var soundPlayer = new System.Media.SoundPlayer(@"runda.wav"))
            {
                soundPlayer.Play();
            }
            label17.Visible = true;
            label18.Visible = true;
            label18.BackColor = Color.MidnightBlue;
            label17.BackColor = Color.Maroon;
            czy = true;

            int nonZeroCount = 0; // Counter for non-zero elements in the current row
            // Loop through each column in the row
            for (int col = 0; col < 10; col++)
            {
                if (punkty[runda - 1, col] != 0)
                {
                    nonZeroCount++;  // Increment counter for non-zero elements
                }
            }

            for (int i = nonZeroCount; i < labeleOdpowiedzi.Length; i++)
            {
                labeleOdpowiedzi[i].Text = "";
            }

            for (int i = nonZeroCount; i < labelePunkty.Length; i++)
            {
                labelePunkty[i].Text = "";
            }

            for (int i = nonZeroCount; i < przyciskiOdpowiedzi.Length; i++)
            {
                przyciskiOdpowiedzi[i].Enabled = false;
                przyciskiOdpowiedzi[i].Visible = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            strataB += 1;
            if (strataB == 1)
            {
                this.pictureBox4.Load("iks.png");
            }
            if (strataB == 2)
            {
                this.pictureBox5.Load("iks.png");
            }
            if (strataB == 3)
            {
                this.pictureBox6.Load("iks.png");
            }
            using (var soundPlayer = new System.Media.SoundPlayer(@"zla.wav"))
            {
                soundPlayer.Play();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            runda = 1;
            nowa_runda(runda);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            runda = 2;
            nowa_runda(runda);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            runda = 3;
            nowa_runda(runda);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            runda = 4;
            nowa_runda(runda);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            runda = 5;
            nowa_runda(runda);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            runda = 6;
            nowa_runda(runda);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            runda = 7;
            nowa_runda(runda);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = odpowiedzi[runda - 1, 0];
            label11.Text = punkty[runda - 1, 0].ToString();
            suma += punkty[runda - 1, 0];
            label10.Text = suma.ToString();
            using (var soundPlayer = new System.Media.SoundPlayer(@"dobra.wav"))
            {
                soundPlayer.Play();
            }
            label17.Visible = false;
            label18.Visible = false;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = odpowiedzi[runda - 1, 1];
            label12.Text = punkty[runda - 1, 1].ToString();
            suma += punkty[runda - 1, 1];
            label10.Text = suma.ToString();
            using (var soundPlayer = new System.Media.SoundPlayer(@"dobra.wav"))
            {
                soundPlayer.Play();
            }
            label17.Visible = false;
            label18.Visible = false;
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text = odpowiedzi[runda - 1, 2];
            label13.Text = punkty[runda - 1, 2].ToString();
            suma += punkty[runda - 1, 2];
            label10.Text = suma.ToString();
            using (var soundPlayer = new System.Media.SoundPlayer(@"dobra.wav"))
            {
                soundPlayer.Play();
            }
            label17.Visible = false;
            label18.Visible = false;
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label6.Text = odpowiedzi[runda - 1, 3];
            label14.Text = punkty[runda - 1, 3].ToString();
            suma += punkty[runda - 1, 3];
            label10.Text = suma.ToString();
            using (var soundPlayer = new System.Media.SoundPlayer(@"dobra.wav"))
            {
                soundPlayer.Play();
            }
            label17.Visible = false;
            label18.Visible = false;
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label7.Text = odpowiedzi[runda - 1, 4];
            label15.Text = punkty[runda - 1, 4].ToString();
            suma += punkty[runda - 1, 4];
            label10.Text = suma.ToString();
            using (var soundPlayer = new System.Media.SoundPlayer(@"dobra.wav"))
            {
                soundPlayer.Play();
            }
            label17.Visible = false;
            label18.Visible = false;
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label8.Text = odpowiedzi[runda - 1, 5];
            label16.Text = punkty[runda - 1, 5].ToString();
            suma += punkty[runda - 1, 5];
            label10.Text = suma.ToString();
            using (var soundPlayer = new System.Media.SoundPlayer(@"dobra.wav"))
            {
                soundPlayer.Play();
            }
            label17.Visible = false;
            label18.Visible = false;
            button8.Enabled = false;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            label22.Text = odpowiedzi[runda - 1, 6];
            label21.Text = punkty[runda - 1, 6].ToString();
            suma += punkty[runda - 1, 6];
            label10.Text = suma.ToString();
            using (var soundPlayer = new System.Media.SoundPlayer(@"dobra.wav"))
            {
                soundPlayer.Play();
            }
            label17.Visible = false;
            label18.Visible = false;
            button17.Enabled = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label24.Text = odpowiedzi[runda - 1, 7];
            label23.Text = punkty[runda - 1, 7].ToString();
            suma += punkty[runda - 1, 7];
            label10.Text = suma.ToString();
            using (var soundPlayer = new System.Media.SoundPlayer(@"dobra.wav"))
            {
                soundPlayer.Play();
            }
            label17.Visible = false;
            label18.Visible = false;
            button18.Enabled = false;
        }

        private void kto_pierwszy(bool czerwony, bool czyf)
        {
            if (czyf)
            {
                if (czerwony)
                {
                    label17.BackColor = Color.Red;
                }
                else
                {
                    label18.BackColor = Color.Blue;
                }
            }
            czy = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            using (var soundPlayer = new System.Media.SoundPlayer(@"poczatek.wav"))
            {
                soundPlayer.Play();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1')
            {
                this.button3.PerformClick();
            }
            if (e.KeyChar == '2')
            {
                this.button4.PerformClick();
            }
            if (e.KeyChar == '3')
            {
                this.button5.PerformClick();
            }
            if (e.KeyChar == '4')
            {
                this.button6.PerformClick();
            }
            if (e.KeyChar == '5')
            {
                this.button7.PerformClick();
            }
            if (e.KeyChar == '6')
            {
                this.button8.PerformClick();
            }
            if (e.KeyChar == '7')
            {
                this.button17.PerformClick();
            }
            if (e.KeyChar == '8')
            {
                this.button18.PerformClick();
            }
            if (e.KeyChar == 'c')
            {
                this.button1.PerformClick();
            }
            if (e.KeyChar == 'n')
            {
                this.button2.PerformClick();
            }
            if (e.KeyChar == 'q')
            {
                this.button9.PerformClick();
            }
            if (e.KeyChar == 'w')
            {
                this.button10.PerformClick();
            }
            if (e.KeyChar == 'e')
            {
                this.button11.PerformClick();
            }
            if (e.KeyChar == 'r')
            {
                this.button12.PerformClick();
            }
            if (e.KeyChar == 't')
            {
                this.button13.PerformClick();
            }
            if (e.KeyChar == 'y')
            {
                this.button14.PerformClick();
            }
            if (e.KeyChar == 'u')
            {
                this.button16.PerformClick();
            }
            if (e.KeyChar == 's')
            {
                this.button15.PerformClick();
            }
            if (e.KeyChar == '0' || e.KeyChar == ',')
            {
                kto_pierwszy(true, czy);
            }
            if (e.KeyChar == '/' || e.KeyChar == '*')
            {
                kto_pierwszy(false, czy);
            }
            if (e.KeyChar == 'x')
            {
                if (czy_liczyc)
                {
                    sumaA += suma;
                    label20.Text = sumaA.ToString();
                    czy_liczyc = false;
                }

            }
            if (e.KeyChar == 'm')
            {
                if (czy_liczyc)
                {
                    sumaB += suma;
                    label19.Text = sumaB.ToString();
                    czy_liczyc = false;
                }
            }
        }
        //przypadkiem wygenerowane funkcje
        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }


    }
}