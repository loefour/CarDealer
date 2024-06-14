namespace Prototype
{
    partial class Form6
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
            userPicture = new PictureBox();
            nameLebel = new Label();
            emailLabel = new Label();
            userTypeLabel = new Label();
            AdminButton = new Button();
            NormallButton = new Button();
            ((System.ComponentModel.ISupportInitialize)userPicture).BeginInit();
            SuspendLayout();
            // 
            // userPicture
            // 
            userPicture.Location = new Point(84, 35);
            userPicture.Name = "userPicture";
            userPicture.Size = new Size(210, 192);
            userPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            userPicture.TabIndex = 0;
            userPicture.TabStop = false;
            // 
            // nameLebel
            // 
            nameLebel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            nameLebel.Location = new Point(84, 230);
            nameLebel.Name = "nameLebel";
            nameLebel.Size = new Size(210, 48);
            nameLebel.TabIndex = 1;
            nameLebel.Text = "label1";
            nameLebel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailLabel
            // 
            emailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(84, 291);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(210, 48);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "label2";
            emailLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userTypeLabel
            // 
            userTypeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userTypeLabel.Location = new Point(84, 339);
            userTypeLabel.Name = "userTypeLabel";
            userTypeLabel.Size = new Size(210, 48);
            userTypeLabel.TabIndex = 3;
            userTypeLabel.Text = "label3";
            userTypeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdminButton
            // 
            AdminButton.Location = new Point(122, 390);
            AdminButton.Name = "AdminButton";
            AdminButton.Size = new Size(134, 47);
            AdminButton.TabIndex = 4;
            AdminButton.Text = "Admin";
            AdminButton.UseVisualStyleBackColor = true;
            AdminButton.Click += button1_Click;
            // 
            // NormallButton
            // 
            NormallButton.Location = new Point(122, 443);
            NormallButton.Name = "NormallButton";
            NormallButton.Size = new Size(134, 47);
            NormallButton.TabIndex = 5;
            NormallButton.Text = "Normal";
            NormallButton.UseVisualStyleBackColor = true;
            NormallButton.Click += NormallButton_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 507);
            Controls.Add(NormallButton);
            Controls.Add(AdminButton);
            Controls.Add(userTypeLabel);
            Controls.Add(emailLabel);
            Controls.Add(nameLebel);
            Controls.Add(userPicture);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)userPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox userPicture;
        private Label nameLebel;
        private Label emailLabel;
        private Label userTypeLabel;
        private Button AdminButton;
        private Button NormallButton;
    }
}