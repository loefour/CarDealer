﻿namespace Prototype
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
            ((System.ComponentModel.ISupportInitialize)carImage).BeginInit();
            SuspendLayout();
            // 
            // carImage
            // 
            carImage.Location = new Point(12, 128);
            carImage.Name = "carImage";
            carImage.Size = new Size(218, 168);
            carImage.SizeMode = PictureBoxSizeMode.StretchImage;
            carImage.TabIndex = 0;
            carImage.TabStop = false;
            // 
            // Nameform4
            // 
            Nameform4.Location = new Point(236, 134);
            Nameform4.Name = "Nameform4";
            Nameform4.Size = new Size(293, 43);
            Nameform4.TabIndex = 1;
            Nameform4.Text = "label1";
            Nameform4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Infoform4
            // 
            Infoform4.Location = new Point(236, 191);
            Infoform4.Name = "Infoform4";
            Infoform4.Size = new Size(293, 43);
            Infoform4.TabIndex = 2;
            Infoform4.Text = "label2";
            Infoform4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Priceform4
            // 
            Priceform4.Location = new Point(236, 248);
            Priceform4.Name = "Priceform4";
            Priceform4.Size = new Size(293, 43);
            Priceform4.TabIndex = 3;
            Priceform4.Text = "label3";
            Priceform4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(12, 326);
            button1.Name = "button1";
            button1.Size = new Size(218, 43);
            button1.TabIndex = 4;
            button1.Text = "Purchus";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Priceform4);
            Controls.Add(Infoform4);
            Controls.Add(Nameform4);
            Controls.Add(carImage);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)carImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox carImage;
        private Label Nameform4;
        private Label Infoform4;
        private Label Priceform4;
        private Button button1;
    }
}