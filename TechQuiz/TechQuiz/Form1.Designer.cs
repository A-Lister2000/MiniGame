namespace TechQuiz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label5 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(82, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(497, 218);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 19);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnA
            // 
            btnA.Location = new Point(165, 450);
            btnA.Name = "btnA";
            btnA.Size = new Size(75, 23);
            btnA.TabIndex = 2;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.Location = new Point(378, 450);
            btnB.Name = "btnB";
            btnB.Size = new Size(75, 23);
            btnB.TabIndex = 3;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += button2_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(569, 450);
            btnC.Name = "btnC";
            btnC.Size = new Size(75, 23);
            btnC.TabIndex = 4;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.WindowFrame;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(83, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(645, 390);
            panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(469, 304);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(110, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(490, 407);
            panel2.Name = "panel2";
            panel2.Size = new Size(89, 38);
            panel2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(469, 286);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 6;
            label5.Text = "PREVIOUS ANSWER";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(203, 276);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "OPTIONS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 48);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 73);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 16);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 4;
            label4.Text = "label4";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 485);
            Controls.Add(panel1);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Name = "Form1";
            Text = "TechQuiz";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox1;
        private Label label5;
        private Panel panel2;
        private PictureBox pictureBox2;
    }
}