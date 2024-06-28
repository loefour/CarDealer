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
            userImage.Location = new Point(37, 51);
            userImage.Name = "userImage";
            userImage.Size = new Size(150, 150);
            userImage.SizeMode = PictureBoxSizeMode.StretchImage;
            userImage.TabIndex = 0;
            userImage.TabStop = false;
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.BackColor = Color.Transparent;
            namelabel.ForeColor = Color.White;
            namelabel.Location = new Point(265, 93);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(50, 20);
            namelabel.TabIndex = 1;
            namelabel.Text = "label1";
            // 
            // budgetlabel
            // 
            budgetlabel.AutoSize = true;
            budgetlabel.BackColor = Color.Transparent;
            budgetlabel.ForeColor = Color.White;
            budgetlabel.Location = new Point(265, 168);
            budgetlabel.Name = "budgetlabel";
            budgetlabel.Size = new Size(50, 20);
            budgetlabel.TabIndex = 2;
            budgetlabel.Text = "label2";
            // 
            // userControll
            // 
            userControll.AutoSize = true;
            userControll.BackColor = Color.Transparent;
            userControll.ForeColor = Color.White;
            userControll.Location = new Point(265, 118);
            userControll.Name = "userControll";
            userControll.Size = new Size(50, 20);
            userControll.TabIndex = 3;
            userControll.Text = "label3";
            // 
            // LevelUpButton
            // 
            LevelUpButton.BackColor = Color.FromArgb(255, 192, 128);
            LevelUpButton.FlatStyle = FlatStyle.Flat;
            LevelUpButton.ForeColor = Color.Black;
            LevelUpButton.Location = new Point(37, 215);
            LevelUpButton.Name = "LevelUpButton";
            LevelUpButton.Size = new Size(150, 29);
            LevelUpButton.TabIndex = 4;
            LevelUpButton.Text = "User Level Up";
            LevelUpButton.UseVisualStyleBackColor = false;
            LevelUpButton.Click += LevelUpButton_Click;
            // 
            // uservaultButton
            // 
            uservaultButton.BackColor = Color.FromArgb(255, 192, 128);
            uservaultButton.FlatStyle = FlatStyle.Flat;
            uservaultButton.ForeColor = Color.Black;
            uservaultButton.Location = new Point(37, 253);
            uservaultButton.Name = "uservaultButton";
            uservaultButton.Size = new Size(150, 29);
            uservaultButton.TabIndex = 5;
            uservaultButton.Text = "User Vault";
            uservaultButton.UseVisualStyleBackColor = false;
            uservaultButton.Click += uservaultButton_Click;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.ForeColor = Color.White;
            emailLabel.Location = new Point(265, 143);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(50, 20);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "label3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.FromArgb(255, 192, 128);
            label1.Location = new Point(203, 93);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 7;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.FromArgb(255, 192, 128);
            label2.Location = new Point(205, 118);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 8;
            label2.Text = "Level :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.FromArgb(255, 192, 128);
            label3.Location = new Point(205, 143);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 10;
            label3.Text = "Email :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.FromArgb(255, 192, 128);
            label4.Location = new Point(205, 168);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 9;
            label4.Text = "Vault :";
            // 
            // deleteUser
            // 
            deleteUser.BackColor = Color.Red;
            deleteUser.FlatStyle = FlatStyle.Flat;
            deleteUser.ForeColor = Color.White;
            deleteUser.Location = new Point(366, 253);
            deleteUser.Name = "deleteUser";
            deleteUser.Size = new Size(94, 29);
            deleteUser.TabIndex = 11;
            deleteUser.Text = "Delete";
            deleteUser.UseVisualStyleBackColor = false;
            deleteUser.Click += deleteUser_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.gradient__12_;
            BackgroundImageLayout = ImageLayout.Stretch;
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
            DoubleBuffered = true;
            Name = "UserControl1";
            Size = new Size(490, 300);
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
