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
            removeButton.Location = new Point(723, 106);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(113, 47);
            removeButton.TabIndex = 1;
            removeButton.Text = "remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(256, 66);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(50, 20);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "label1";
            // 
            // updatePriceButton
            // 
            updatePriceButton.Location = new Point(723, 53);
            updatePriceButton.Name = "updatePriceButton";
            updatePriceButton.Size = new Size(113, 47);
            updatePriceButton.TabIndex = 3;
            updatePriceButton.Text = "Price";
            updatePriceButton.UseVisualStyleBackColor = true;
            updatePriceButton.Click += updatePriceButton_Click;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(256, 105);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(50, 20);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "label1";
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(priceLabel);
            Controls.Add(updatePriceButton);
            Controls.Add(nameLabel);
            Controls.Add(removeButton);
            Controls.Add(carPicture);
            Name = "UserControl2";
            Size = new Size(870, 199);
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
    }
}
