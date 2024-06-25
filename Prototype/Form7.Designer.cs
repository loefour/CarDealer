namespace Prototype
{
    partial class Form7
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
            userImage = new PictureBox();
            nameLebel = new Label();
            emailLabel = new Label();
            vaultTextBox = new TextBox();
            label1 = new Label();
            saveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)userImage).BeginInit();
            SuspendLayout();
            // 
            // userImage
            // 
            userImage.Location = new Point(84, 35);
            userImage.Name = "userImage";
            userImage.Size = new Size(210, 192);
            userImage.SizeMode = PictureBoxSizeMode.StretchImage;
            userImage.TabIndex = 0;
            userImage.TabStop = false;
            // 
            // nameLebel
            // 
            nameLebel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            nameLebel.Location = new Point(87, 229);
            nameLebel.Name = "nameLebel";
            nameLebel.Size = new Size(210, 48);
            nameLebel.TabIndex = 2;
            nameLebel.Text = "label1";
            nameLebel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailLabel
            // 
            emailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(84, 292);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(210, 48);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "label2";
            emailLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // vaultTextBox
            // 
            vaultTextBox.Location = new Point(123, 343);
            vaultTextBox.Name = "vaultTextBox";
            vaultTextBox.Size = new Size(157, 27);
            vaultTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 345);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 6;
            label1.Text = "Vault :";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(122, 383);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(134, 47);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 507);
            Controls.Add(saveButton);
            Controls.Add(label1);
            Controls.Add(vaultTextBox);
            Controls.Add(emailLabel);
            Controls.Add(nameLebel);
            Controls.Add(userImage);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)userImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox userImage;
        private Label nameLebel;
        private Label emailLabel;
        private TextBox vaultTextBox;
        private Label label1;
        private Button saveButton;
    }
}