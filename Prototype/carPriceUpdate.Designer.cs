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
            label2 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)carImage).BeginInit();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(44, 194, 123);
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(92, 425);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(210, 47);
            saveButton.TabIndex = 12;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(63, 373);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 11;
            label1.Text = "Price :";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(127, 373);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(157, 27);
            priceTextBox.TabIndex = 10;
            // 
            // nameLabel
            // 
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic);
            nameLabel.Location = new Point(127, 282);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(189, 48);
            nameLabel.TabIndex = 9;
            nameLabel.Text = "label1";
            nameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // carImage
            // 
            carImage.Location = new Point(92, 63);
            carImage.Name = "carImage";
            carImage.Size = new Size(210, 192);
            carImage.SizeMode = PictureBoxSizeMode.StretchImage;
            carImage.TabIndex = 8;
            carImage.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(63, 294);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 13;
            label2.Text = "Name :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(210, 213, 213);
            button2.Image = Properties.Resources.cross__1_;
            button2.Location = new Point(-1, 0);
            button2.Name = "button2";
            button2.Size = new Size(39, 36);
            button2.TabIndex = 20;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // carPriceUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gradient__11_8;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(385, 507);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(saveButton);
            Controls.Add(label1);
            Controls.Add(priceTextBox);
            Controls.Add(nameLabel);
            Controls.Add(carImage);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
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
        private Label label2;
        private Button button2;
    }
}