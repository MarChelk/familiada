
namespace familiada
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public int[,] punkty;
        public string[,] odpowiedzi;
        private int runda;
        private int strataA, strataB, sumaA, sumaB;
        private int suma;
        private bool czy, czy_liczyc;
        private int[] pytania;

        System.Windows.Forms.Button[] przyciskiOdpowiedzi;
        System.Windows.Forms.Button[] przyciskiRundy;
        System.Windows.Forms.Label[] labeleOdpowiedzi;
        System.Windows.Forms.Label[] labelePunkty;
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            pictureBox6 = new System.Windows.Forms.PictureBox();
            button2 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            button9 = new System.Windows.Forms.Button();
            button10 = new System.Windows.Forms.Button();
            button11 = new System.Windows.Forms.Button();
            button12 = new System.Windows.Forms.Button();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            button13 = new System.Windows.Forms.Button();
            button14 = new System.Windows.Forms.Button();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            button15 = new System.Windows.Forms.Button();
            label17 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            button16 = new System.Windows.Forms.Button();
            label21 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            button17 = new System.Windows.Forms.Button();
            label23 = new System.Windows.Forms.Label();
            label24 = new System.Windows.Forms.Label();
            button18 = new System.Windows.Forms.Button();
            label25 = new System.Windows.Forms.Label();
            label26 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            button1.Location = new System.Drawing.Point(100, 773);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(101, 60);
            button1.TabIndex = 0;
            button1.Text = "STRATA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.KeyPress += Form1_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pictureBox1.Location = new System.Drawing.Point(100, 237);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(101, 102);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pictureBox2.Location = new System.Drawing.Point(100, 374);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(101, 102);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pictureBox3.Location = new System.Drawing.Point(100, 507);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(101, 102);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            pictureBox4.Location = new System.Drawing.Point(950, 237);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(101, 102);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            pictureBox5.Location = new System.Drawing.Point(952, 374);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(101, 102);
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            pictureBox6.Location = new System.Drawing.Point(952, 507);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new System.Drawing.Size(101, 102);
            pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 8;
            pictureBox6.TabStop = false;
            // 
            // button2
            // 
            button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            button2.Location = new System.Drawing.Point(950, 773);
            button2.Name = "button2";
            button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            button2.Size = new System.Drawing.Size(101, 60);
            button2.TabIndex = 9;
            button2.Text = "STRATA";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.KeyPress += Form1_KeyPress;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label2.Font = new System.Drawing.Font("Familiada", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Yellow;
            label2.Location = new System.Drawing.Point(379, 49);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(430, 95);
            label2.TabIndex = 10;
            label2.Text = "FAMILIADA";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label3.BackColor = System.Drawing.SystemColors.ControlText;
            label3.Font = new System.Drawing.Font("Familiada", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Yellow;
            label3.Location = new System.Drawing.Point(368, 159);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(505, 43);
            label3.TabIndex = 11;
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button3
            // 
            button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            button3.Location = new System.Drawing.Point(306, 159);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(43, 43);
            button3.TabIndex = 12;
            button3.Text = "1";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            button3.KeyPress += Form1_KeyPress;
            // 
            // button4
            // 
            button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            button4.Location = new System.Drawing.Point(306, 218);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(43, 43);
            button4.TabIndex = 13;
            button4.Text = "2";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            button4.KeyPress += Form1_KeyPress;
            // 
            // button5
            // 
            button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            button5.Location = new System.Drawing.Point(306, 282);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(43, 43);
            button5.TabIndex = 14;
            button5.Text = "3";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            button5.KeyPress += Form1_KeyPress;
            // 
            // button6
            // 
            button6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            button6.Location = new System.Drawing.Point(306, 345);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(43, 43);
            button6.TabIndex = 15;
            button6.Text = "4";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            button6.KeyPress += Form1_KeyPress;
            // 
            // button7
            // 
            button7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            button7.Location = new System.Drawing.Point(306, 415);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(43, 43);
            button7.TabIndex = 16;
            button7.Text = "5";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            button7.KeyPress += Form1_KeyPress;
            // 
            // button8
            // 
            button8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            button8.Location = new System.Drawing.Point(306, 477);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(43, 43);
            button8.TabIndex = 17;
            button8.Text = "6";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            button8.KeyPress += Form1_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.Font = new System.Drawing.Font("Familiada", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Yellow;
            label1.Location = new System.Drawing.Point(349, 679);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(460, 43);
            label1.TabIndex = 18;
            label1.Text = "Suma: ";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label4.Font = new System.Drawing.Font("Familiada", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.Yellow;
            label4.Location = new System.Drawing.Point(368, 218);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(505, 43);
            label4.TabIndex = 19;
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label5.Font = new System.Drawing.Font("Familiada", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.Yellow;
            label5.Location = new System.Drawing.Point(368, 282);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(505, 43);
            label5.TabIndex = 20;
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label6.Font = new System.Drawing.Font("Familiada", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.Yellow;
            label6.Location = new System.Drawing.Point(368, 345);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(505, 43);
            label6.TabIndex = 21;
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label7.Font = new System.Drawing.Font("Familiada", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.Yellow;
            label7.Location = new System.Drawing.Point(368, 415);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(505, 43);
            label7.TabIndex = 22;
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label8.Font = new System.Drawing.Font("Familiada", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.Yellow;
            label8.Location = new System.Drawing.Point(368, 477);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(505, 43);
            label8.TabIndex = 23;
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label8.Click += label8_Click;
            // 
            // button9
            // 
            button9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            button9.Location = new System.Drawing.Point(403, 806);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(43, 42);
            button9.TabIndex = 24;
            button9.Text = "1";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            button9.KeyPress += Form1_KeyPress;
            // 
            // button10
            // 
            button10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            button10.Location = new System.Drawing.Point(451, 806);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(43, 42);
            button10.TabIndex = 25;
            button10.Text = "2";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            button10.KeyPress += Form1_KeyPress;
            // 
            // button11
            // 
            button11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            button11.Location = new System.Drawing.Point(500, 806);
            button11.Name = "button11";
            button11.Size = new System.Drawing.Size(43, 42);
            button11.TabIndex = 26;
            button11.Text = "3";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            button11.KeyPress += Form1_KeyPress;
            // 
            // button12
            // 
            button12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            button12.Location = new System.Drawing.Point(549, 806);
            button12.Name = "button12";
            button12.Size = new System.Drawing.Size(43, 42);
            button12.TabIndex = 27;
            button12.Text = "4";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            button12.KeyPress += Form1_KeyPress;
            // 
            // label9
            // 
            label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Familiada", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.Color.Yellow;
            label9.Location = new System.Drawing.Point(402, 750);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(155, 29);
            label9.TabIndex = 28;
            label9.Text = "Runda:";
            // 
            // label10
            // 
            label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label10.Font = new System.Drawing.Font("Familiada", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.ForeColor = System.Drawing.Color.Yellow;
            label10.Location = new System.Drawing.Point(815, 679);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(116, 43);
            label10.TabIndex = 29;
            label10.Text = "0";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button13
            // 
            button13.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            button13.Location = new System.Drawing.Point(598, 806);
            button13.Name = "button13";
            button13.Size = new System.Drawing.Size(43, 42);
            button13.TabIndex = 30;
            button13.Text = "5";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            button13.KeyPress += Form1_KeyPress;
            // 
            // button14
            // 
            button14.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            button14.Location = new System.Drawing.Point(647, 806);
            button14.Name = "button14";
            button14.Size = new System.Drawing.Size(43, 42);
            button14.TabIndex = 31;
            button14.Text = "6";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            button14.KeyPress += Form1_KeyPress;
            // 
            // label11
            // 
            label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label11.Font = new System.Drawing.Font("Familiada", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.ForeColor = System.Drawing.Color.Yellow;
            label11.Location = new System.Drawing.Point(879, 159);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(65, 43);
            label11.TabIndex = 32;
            label11.Text = "...";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label12.Font = new System.Drawing.Font("Familiada", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label12.ForeColor = System.Drawing.Color.Yellow;
            label12.Location = new System.Drawing.Point(879, 218);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(65, 43);
            label12.TabIndex = 33;
            label12.Text = "...";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label13.Font = new System.Drawing.Font("Familiada", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label13.ForeColor = System.Drawing.Color.Yellow;
            label13.Location = new System.Drawing.Point(879, 282);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(65, 43);
            label13.TabIndex = 34;
            label13.Text = "...";
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label14.Font = new System.Drawing.Font("Familiada", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label14.ForeColor = System.Drawing.Color.Yellow;
            label14.Location = new System.Drawing.Point(879, 345);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(65, 43);
            label14.TabIndex = 35;
            label14.Text = "...";
            label14.Click += label14_Click;
            // 
            // label15
            // 
            label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label15.Font = new System.Drawing.Font("Familiada", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label15.ForeColor = System.Drawing.Color.Yellow;
            label15.Location = new System.Drawing.Point(879, 415);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(65, 43);
            label15.TabIndex = 36;
            label15.Text = "...";
            label15.Click += label15_Click;
            // 
            // label16
            // 
            label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label16.Font = new System.Drawing.Font("Familiada", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label16.ForeColor = System.Drawing.Color.Yellow;
            label16.Location = new System.Drawing.Point(879, 477);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(65, 43);
            label16.TabIndex = 37;
            label16.Text = "...";
            label16.Click += label16_Click;
            // 
            // button15
            // 
            button15.Location = new System.Drawing.Point(12, 12);
            button15.Name = "button15";
            button15.Size = new System.Drawing.Size(34, 29);
            button15.TabIndex = 38;
            button15.Text = "S";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            button15.KeyPress += Form1_KeyPress;
            // 
            // label17
            // 
            label17.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            label17.BackColor = System.Drawing.Color.Maroon;
            label17.Location = new System.Drawing.Point(100, 895);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(475, 50);
            label17.TabIndex = 39;
            label17.Click += label17_Click;
            // 
            // label18
            // 
            label18.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            label18.BackColor = System.Drawing.Color.MidnightBlue;
            label18.Location = new System.Drawing.Point(576, 895);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(475, 50);
            label18.TabIndex = 40;
            label18.Click += label18_Click;
            // 
            // label19
            // 
            label19.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label19.Font = new System.Drawing.Font("Familiada", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label19.ForeColor = System.Drawing.Color.Yellow;
            label19.Location = new System.Drawing.Point(937, 86);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(116, 43);
            label19.TabIndex = 41;
            label19.Text = "0";
            label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label20.Font = new System.Drawing.Font("Familiada", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label20.ForeColor = System.Drawing.Color.Yellow;
            label20.Location = new System.Drawing.Point(100, 86);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(116, 44);
            label20.TabIndex = 42;
            label20.Text = "0";
            label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button16
            // 
            button16.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            button16.Enabled = false;
            button16.Location = new System.Drawing.Point(696, 806);
            button16.Name = "button16";
            button16.Size = new System.Drawing.Size(43, 42);
            button16.TabIndex = 43;
            button16.Text = "7";
            button16.UseVisualStyleBackColor = true;
            button16.Visible = false;
            button16.Click += button16_Click;
            // 
            // label21
            // 
            label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label21.Font = new System.Drawing.Font("Familiada", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label21.ForeColor = System.Drawing.Color.Yellow;
            label21.Location = new System.Drawing.Point(879, 542);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(65, 43);
            label21.TabIndex = 46;
            label21.Text = "...";
            // 
            // label22
            // 
            label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label22.Font = new System.Drawing.Font("Familiada", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label22.ForeColor = System.Drawing.Color.Yellow;
            label22.Location = new System.Drawing.Point(368, 542);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(505, 43);
            label22.TabIndex = 45;
            label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button17
            // 
            button17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            button17.Location = new System.Drawing.Point(306, 542);
            button17.Name = "button17";
            button17.Size = new System.Drawing.Size(43, 43);
            button17.TabIndex = 44;
            button17.Text = "7";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            button17.KeyPress += Form1_KeyPress;
            // 
            // label23
            // 
            label23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label23.Font = new System.Drawing.Font("Familiada", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label23.ForeColor = System.Drawing.Color.Yellow;
            label23.Location = new System.Drawing.Point(879, 609);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(65, 43);
            label23.TabIndex = 49;
            label23.Text = "...";
            // 
            // label24
            // 
            label24.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label24.Font = new System.Drawing.Font("Familiada", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label24.ForeColor = System.Drawing.Color.Yellow;
            label24.Location = new System.Drawing.Point(368, 609);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(505, 43);
            label24.TabIndex = 48;
            label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button18
            // 
            button18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            button18.Location = new System.Drawing.Point(306, 609);
            button18.Name = "button18";
            button18.Size = new System.Drawing.Size(43, 43);
            button18.TabIndex = 47;
            button18.Text = "8";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            button18.KeyPress += Form1_KeyPress;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new System.Drawing.Point(576, 9);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(58, 20);
            label25.TabIndex = 50;
            label25.Text = "label25";
            // 
            // label26
            // 
            label26.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label26.Font = new System.Drawing.Font("Familiada", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label26.ForeColor = System.Drawing.Color.Yellow;
            label26.Location = new System.Drawing.Point(52, 12);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(55, 32);
            label26.TabIndex = 51;
            label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.SystemColors.ControlText;
            ClientSize = new System.Drawing.Size(1182, 976);
            Controls.Add(label26);
            Controls.Add(label25);
            Controls.Add(label23);
            Controls.Add(label24);
            Controls.Add(button18);
            Controls.Add(label21);
            Controls.Add(label22);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(button15);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            ForeColor = System.Drawing.SystemColors.ControlText;
            MinimumSize = new System.Drawing.Size(1198, 797);
            Name = "Form1";
            Text = "From1";
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
    }
}

