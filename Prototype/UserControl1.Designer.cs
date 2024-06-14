namespace Prototype
{
    partial class UserControl1
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
            userImage = new PictureBox();
            namelabel = new Label();
            budgetlabel = new Label();
            userControll = new Label();
            LevelUpButton = new Button();
            uservaultButton = new Button();
            emailLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)userImage).BeginInit();
            SuspendLayout();
            // 
            // userImage
            // 
            userImage.Location = new Point(15, 14);
            userImage.Name = "userImage";
            userImage.Size = new Size(262, 112);
            userImage.SizeMode = PictureBoxSizeMode.StretchImage;
            userImage.TabIndex = 0;
            userImage.TabStop = false;
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Location = new Point(283, 23);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(50, 20);
            namelabel.TabIndex = 1;
            namelabel.Text = "label1";
            // 
            // budgetlabel
            // 
            budgetlabel.AutoSize = true;
            budgetlabel.Location = new Point(283, 98);
            budgetlabel.Name = "budgetlabel";
            budgetlabel.Size = new Size(50, 20);
            budgetlabel.TabIndex = 2;
            budgetlabel.Text = "label2";
            // 
            // userControll
            // 
            userControll.AutoSize = true;
            userControll.Location = new Point(283, 48);
            userControll.Name = "userControll";
            userControll.Size = new Size(50, 20);
            userControll.TabIndex = 3;
            userControll.Text = "label3";
            // 
            // LevelUpButton
            // 
            LevelUpButton.Location = new Point(722, 35);
            LevelUpButton.Name = "LevelUpButton";
            LevelUpButton.Size = new Size(158, 29);
            LevelUpButton.TabIndex = 4;
            LevelUpButton.Text = "User Level Up";
            LevelUpButton.UseVisualStyleBackColor = true;
            LevelUpButton.Click += LevelUpButton_Click;
            // 
            // uservaultButton
            // 
            uservaultButton.Location = new Point(722, 70);
            uservaultButton.Name = "uservaultButton";
            uservaultButton.Size = new Size(158, 29);
            uservaultButton.TabIndex = 5;
            uservaultButton.Text = "User Vault";
            uservaultButton.UseVisualStyleBackColor = true;
            uservaultButton.Click += uservaultButton_Click;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(283, 73);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(50, 20);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "label3";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(emailLabel);
            Controls.Add(uservaultButton);
            Controls.Add(LevelUpButton);
            Controls.Add(userControll);
            Controls.Add(budgetlabel);
            Controls.Add(namelabel);
            Controls.Add(userImage);
            Name = "UserControl1";
            Size = new Size(898, 142);
            ((System.ComponentModel.ISupportInitialize)userImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox userImage;
        private Label namelabel;
        private Label budgetlabel;
        private Label userControll;
        private Button LevelUpButton;
        private Button uservaultButton;
        private Label emailLabel;
    }
}
