﻿namespace Prototype
{
    partial class newCarAdd
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
            nameTexBox = new TextBox();
            infoTextBox = new TextBox();
            priceTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            label4 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)carImage).BeginInit();
            SuspendLayout();
            // 
            // carImage
            // 
            carImage.Image = Properties.Resources.car;
            carImage.Location = new Point(89, 48);
            carImage.Name = "carImage";
            carImage.Size = new Size(200, 200);
            carImage.SizeMode = PictureBoxSizeMode.StretchImage;
            carImage.TabIndex = 1;
            carImage.TabStop = false;
            carImage.Click += carImage_Click;
            // 
            // nameTexBox
            // 
            nameTexBox.Location = new Point(87, 299);
            nameTexBox.Name = "nameTexBox";
            nameTexBox.Size = new Size(210, 27);
            nameTexBox.TabIndex = 2;
            // 
            // infoTextBox
            // 
            infoTextBox.Location = new Point(87, 361);
            infoTextBox.Multiline = true;
            infoTextBox.Name = "infoTextBox";
            infoTextBox.Size = new Size(210, 126);
            infoTextBox.TabIndex = 3;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(87, 517);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(210, 27);
            priceTextBox.TabIndex = 4;
            priceTextBox.KeyPress += priceTextBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(13, 299);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 5;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(27, 361);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 6;
            label2.Text = "Info :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(22, 517);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 7;
            label3.Text = "Price :";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(44, 194, 123);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(95, 565);
            button1.Name = "button1";
            button1.Size = new Size(192, 47);
            button1.TabIndex = 8;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(125, 256);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 9;
            label4.Text = "SELECT IMAGE";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(210, 213, 213);
            button2.Image = Properties.Resources.cross__1_;
            button2.Location = new Point(-2, 0);
            button2.Name = "button2";
            button2.Size = new Size(39, 36);
            button2.TabIndex = 19;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // newCarAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gradient__11_7;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(385, 624);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(priceTextBox);
            Controls.Add(infoTextBox);
            Controls.Add(nameTexBox);
            Controls.Add(carImage);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "newCarAdd";
            Text = "newCarAdd";
            Load += newCarAdd_Load;
            ((System.ComponentModel.ISupportInitialize)carImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox carImage;
        private TextBox nameTexBox;
        private TextBox infoTextBox;
        private TextBox priceTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private Label label4;
        private Button button2;
    }
}