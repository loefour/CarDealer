namespace Prototype
{
    partial class DashBoardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            carImage = new PictureBox();
            carnameLabel = new Label();
            PriceLabel = new Label();
            CountLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)carImage).BeginInit();
            SuspendLayout();
            // 
            // carImage
            // 
            carImage.Location = new Point(17, 24);
            carImage.Name = "carImage";
            carImage.Size = new Size(174, 142);
            carImage.SizeMode = PictureBoxSizeMode.StretchImage;
            carImage.TabIndex = 0;
            carImage.TabStop = false;
            // 
            // carnameLabel
            // 
            carnameLabel.AutoSize = true;
            carnameLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            carnameLabel.Location = new Point(303, 34);
            carnameLabel.Name = "carnameLabel";
            carnameLabel.Size = new Size(100, 38);
            carnameLabel.TabIndex = 2;
            carnameLabel.Text = "label2";
            carnameLabel.Click += carnameLabel_Click;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            PriceLabel.Location = new Point(303, 81);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(100, 38);
            PriceLabel.TabIndex = 3;
            PriceLabel.Text = "label2";
            // 
            // CountLabel
            // 
            CountLabel.AutoSize = true;
            CountLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CountLabel.Location = new Point(303, 119);
            CountLabel.Name = "CountLabel";
            CountLabel.Size = new Size(100, 38);
            CountLabel.TabIndex = 4;
            CountLabel.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(197, 119);
            label1.Name = "label1";
            label1.Size = new Size(140, 38);
            label1.TabIndex = 7;
            label1.Text = "Amount: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(197, 81);
            label2.Name = "label2";
            label2.Size = new Size(99, 38);
            label2.TabIndex = 6;
            label2.Text = "Price: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(197, 34);
            label3.Name = "label3";
            label3.Size = new Size(113, 38);
            label3.TabIndex = 5;
            label3.Text = "Name: ";
            // 
            // DashBoardControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(CountLabel);
            Controls.Add(PriceLabel);
            Controls.Add(carnameLabel);
            Controls.Add(carImage);
            Name = "DashBoardControl";
            Size = new Size(503, 189);
            ((System.ComponentModel.ISupportInitialize)carImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox carImage;
        private Label carnameLabel;
        private Label PriceLabel;
        private Label CountLabel;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
