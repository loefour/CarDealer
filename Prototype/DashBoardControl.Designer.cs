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
            carnameLabel.Location = new Point(306, 75);
            carnameLabel.Name = "carnameLabel";
            carnameLabel.Size = new Size(100, 38);
            carnameLabel.TabIndex = 2;
            carnameLabel.Text = "label2";
            carnameLabel.Click += carnameLabel_Click;
            // 
            // DashBoardControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
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
    }
}
