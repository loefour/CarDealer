namespace Prototype
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            carImage = new PictureBox();
            Nameform4 = new Label();
            Infoform4 = new Label();
            Priceform4 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)carImage).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // carImage
            // 
            carImage.Location = new Point(166, 45);
            carImage.Name = "carImage";
            carImage.Size = new Size(200, 200);
            carImage.SizeMode = PictureBoxSizeMode.StretchImage;
            carImage.TabIndex = 0;
            carImage.TabStop = false;
            // 
            // Nameform4
            // 
            Nameform4.BackColor = Color.Transparent;
            Nameform4.ForeColor = Color.White;
            Nameform4.Location = new Point(208, 269);
            Nameform4.Name = "Nameform4";
            Nameform4.Size = new Size(112, 43);
            Nameform4.TabIndex = 1;
            Nameform4.Text = "label1";
            Nameform4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Infoform4
            // 
            Infoform4.BackColor = Color.Transparent;
            Infoform4.ForeColor = Color.White;
            Infoform4.Location = new Point(139, 330);
            Infoform4.Name = "Infoform4";
            Infoform4.Size = new Size(250, 43);
            Infoform4.TabIndex = 2;
            Infoform4.Text = "label2";
            // 
            // Priceform4
            // 
            Priceform4.BackColor = Color.Transparent;
            Priceform4.Font = new Font("Arial Black", 10.8F, FontStyle.Bold);
            Priceform4.ForeColor = Color.White;
            Priceform4.Location = new Point(208, 388);
            Priceform4.Name = "Priceform4";
            Priceform4.Size = new Size(112, 43);
            Priceform4.TabIndex = 3;
            Priceform4.Text = "label3";
            Priceform4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(116, 452);
            button1.Name = "button1";
            button1.Size = new Size(293, 43);
            button1.TabIndex = 4;
            button1.Text = "Purchus";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(187, 315);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 1);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 1);
            panel2.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 128);
            panel3.Location = new Point(139, 380);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 1);
            panel3.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 192, 128);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(87, 437);
            panel4.Name = "panel4";
            panel4.Size = new Size(350, 1);
            panel4.TabIndex = 16;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 192, 128);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 1);
            panel5.TabIndex = 15;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(210, 213, 213);
            button2.Image = Properties.Resources.cross__1_;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(39, 36);
            button2.TabIndex = 17;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(87, 280);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 18;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(87, 330);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 19;
            label2.Text = "Info :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(87, 400);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 20;
            label3.Text = "Price :";
            label3.Click += label3_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gradient__11_4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(527, 518);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(Priceform4);
            Controls.Add(Infoform4);
            Controls.Add(Nameform4);
            Controls.Add(carImage);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)carImage).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox carImage;
        private Label Nameform4;
        private Label Infoform4;
        private Label Priceform4;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}