namespace Prototype
{
    partial class carPriceUpdate
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
            saveButton = new Button();
            label1 = new Label();
            priceTextBox = new TextBox();
            nameLabel = new Label();
            carImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)carImage).BeginInit();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.Location = new Point(130, 397);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(134, 47);
            saveButton.TabIndex = 12;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 359);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 11;
            label1.Text = "Price :";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(131, 357);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(157, 27);
            priceTextBox.TabIndex = 10;
            // 
            // nameLabel
            // 
            nameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(95, 243);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(210, 48);
            nameLabel.TabIndex = 9;
            nameLabel.Text = "label1";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // carImage
            // 
            carImage.Location = new Point(92, 49);
            carImage.Name = "carImage";
            carImage.Size = new Size(210, 192);
            carImage.SizeMode = PictureBoxSizeMode.StretchImage;
            carImage.TabIndex = 8;
            carImage.TabStop = false;
            // 
            // carPriceUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 507);
            Controls.Add(saveButton);
            Controls.Add(label1);
            Controls.Add(priceTextBox);
            Controls.Add(nameLabel);
            Controls.Add(carImage);
            Name = "carPriceUpdate";
            Text = "carPriceUpdate";
            Load += carPriceUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)carImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveButton;
        private Label label1;
        private TextBox priceTextBox;
        private Label nameLabel;
        private PictureBox carImage;
    }
}