namespace Prototype
{
    partial class UserControl2
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
            carPicture = new PictureBox();
            removeButton = new Button();
            nameLabel = new Label();
            updatePriceButton = new Button();
            priceLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)carPicture).BeginInit();
            SuspendLayout();
            // 
            // carPicture
            // 
            carPicture.Location = new Point(13, 13);
            carPicture.Name = "carPicture";
            carPicture.Size = new Size(195, 169);
            carPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            carPicture.TabIndex = 0;
            carPicture.TabStop = false;
            // 
            // removeButton
            // 
            removeButton.BackColor = Color.Red;
            removeButton.FlatStyle = FlatStyle.Flat;
            removeButton.ForeColor = Color.White;
            removeButton.Location = new Point(221, 151);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(113, 28);
            removeButton.TabIndex = 1;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += removeButton_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Location = new Point(289, 62);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(50, 20);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "label1";
            // 
            // updatePriceButton
            // 
            updatePriceButton.BackColor = Color.FromArgb(0, 192, 0);
            updatePriceButton.FlatStyle = FlatStyle.Flat;
            updatePriceButton.ForeColor = Color.White;
            updatePriceButton.Location = new Point(375, 151);
            updatePriceButton.Name = "updatePriceButton";
            updatePriceButton.Size = new Size(113, 28);
            updatePriceButton.TabIndex = 3;
            updatePriceButton.Text = "Price";
            updatePriceButton.UseVisualStyleBackColor = false;
            updatePriceButton.Click += updatePriceButton_Click;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.BackColor = Color.Transparent;
            priceLabel.Location = new Point(289, 101);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(50, 20);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(226, 101);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 6;
            label1.Text = "Price :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(224, 62);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 5;
            label2.Text = "Name :";
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.gradient__10_3;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(priceLabel);
            Controls.Add(updatePriceButton);
            Controls.Add(nameLabel);
            Controls.Add(removeButton);
            Controls.Add(carPicture);
            DoubleBuffered = true;
            Name = "UserControl2";
            Size = new Size(500, 199);
            ((System.ComponentModel.ISupportInitialize)carPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox carPicture;
        private Button removeButton;
        private Label nameLabel;
        private Button updatePriceButton;
        private Label priceLabel;
        private Label label1;
        private Label label2;
    }
}
