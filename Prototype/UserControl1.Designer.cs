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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            deleteUser = new Button();
            ((System.ComponentModel.ISupportInitialize)userImage).BeginInit();
            SuspendLayout();
            // 
            // userImage
            // 
            userImage.Location = new Point(37, 60);
            userImage.Name = "userImage";
            userImage.Size = new Size(150, 150);
            userImage.SizeMode = PictureBoxSizeMode.StretchImage;
            userImage.TabIndex = 0;
            userImage.TabStop = false;
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Location = new Point(299, 84);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(50, 20);
            namelabel.TabIndex = 1;
            namelabel.Text = "label1";
            // 
            // budgetlabel
            // 
            budgetlabel.AutoSize = true;
            budgetlabel.Location = new Point(299, 159);
            budgetlabel.Name = "budgetlabel";
            budgetlabel.Size = new Size(50, 20);
            budgetlabel.TabIndex = 2;
            budgetlabel.Text = "label2";
            // 
            // userControll
            // 
            userControll.AutoSize = true;
            userControll.Location = new Point(299, 109);
            userControll.Name = "userControll";
            userControll.Size = new Size(50, 20);
            userControll.TabIndex = 3;
            userControll.Text = "label3";
            // 
            // LevelUpButton
            // 
            LevelUpButton.Location = new Point(33, 216);
            LevelUpButton.Name = "LevelUpButton";
            LevelUpButton.Size = new Size(158, 29);
            LevelUpButton.TabIndex = 4;
            LevelUpButton.Text = "User Level Up";
            LevelUpButton.UseVisualStyleBackColor = true;
            LevelUpButton.Click += LevelUpButton_Click;
            // 
            // uservaultButton
            // 
            uservaultButton.Location = new Point(33, 251);
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
            emailLabel.Location = new Point(299, 134);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(50, 20);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "label3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(243, 84);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 7;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 109);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 8;
            label2.Text = "Level :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(245, 134);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 10;
            label3.Text = "Email :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(245, 159);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 9;
            label4.Text = "Vault :";
            // 
            // deleteUser
            // 
            deleteUser.Location = new Point(371, 251);
            deleteUser.Name = "deleteUser";
            deleteUser.Size = new Size(94, 29);
            deleteUser.TabIndex = 11;
            deleteUser.Text = "Delete";
            deleteUser.UseVisualStyleBackColor = true;
            deleteUser.Click += deleteUser_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(deleteUser);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(emailLabel);
            Controls.Add(uservaultButton);
            Controls.Add(LevelUpButton);
            Controls.Add(userControll);
            Controls.Add(budgetlabel);
            Controls.Add(namelabel);
            Controls.Add(userImage);
            Name = "UserControl1";
            Size = new Size(488, 300);
            Load += UserControl1_Load;
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button deleteUser;
    }
}
