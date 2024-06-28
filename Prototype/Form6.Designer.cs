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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)userPicture).BeginInit();
            SuspendLayout();
            // 
            // userPicture
            // 
            userPicture.Location = new Point(90, 66);
            userPicture.Name = "userPicture";
            userPicture.Size = new Size(200, 200);
            userPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            userPicture.TabIndex = 0;
            userPicture.TabStop = false;
            // 
            // nameLebel
            // 
            nameLebel.BackColor = Color.Transparent;
            nameLebel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            nameLebel.Location = new Point(96, 293);
            nameLebel.Name = "nameLebel";
            nameLebel.Size = new Size(210, 48);
            nameLebel.TabIndex = 1;
            nameLebel.Text = "label1";
            nameLebel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // emailLabel
            // 
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(96, 354);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(210, 48);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "label2";
            emailLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // userTypeLabel
            // 
            userTypeLabel.BackColor = Color.Transparent;
            userTypeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userTypeLabel.Location = new Point(133, 401);
            userTypeLabel.Name = "userTypeLabel";
            userTypeLabel.Size = new Size(210, 48);
            userTypeLabel.TabIndex = 3;
            userTypeLabel.Text = "label3";
            userTypeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AdminButton
            // 
            AdminButton.BackColor = Color.FromArgb(44, 194, 123);
            AdminButton.BackgroundImage = Properties.Resources.peakpx__2_1;
            AdminButton.BackgroundImageLayout = ImageLayout.Stretch;
            AdminButton.FlatStyle = FlatStyle.Flat;
            AdminButton.ForeColor = Color.White;
            AdminButton.Location = new Point(0, 487);
            AdminButton.Name = "AdminButton";
            AdminButton.Size = new Size(192, 47);
            AdminButton.TabIndex = 4;
            AdminButton.Text = "Admin";
            AdminButton.UseVisualStyleBackColor = false;
            AdminButton.Click += button1_Click;
            // 
            // NormallButton
            // 
            NormallButton.BackColor = Color.White;
            NormallButton.FlatStyle = FlatStyle.Flat;
            NormallButton.Location = new Point(192, 487);
            NormallButton.Name = "NormallButton";
            NormallButton.Size = new Size(192, 47);
            NormallButton.TabIndex = 5;
            NormallButton.Text = "Normal";
            NormallButton.UseVisualStyleBackColor = false;
            NormallButton.Click += NormallButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(24, 307);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 6;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(24, 364);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 7;
            label2.Text = "Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(24, 412);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 8;
            label3.Text = "User Level :";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(210, 213, 213);
            button2.Image = Properties.Resources.cross__1_;
            button2.Location = new Point(0, -1);
            button2.Name = "button2";
            button2.Size = new Size(39, 36);
            button2.TabIndex = 18;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gradient__11_5;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(385, 544);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NormallButton);
            Controls.Add(AdminButton);
            Controls.Add(userTypeLabel);
            Controls.Add(emailLabel);
            Controls.Add(nameLebel);
            Controls.Add(userPicture);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)userPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox userPicture;
        private Label nameLebel;
        private Label emailLabel;
        private Label userTypeLabel;
        private Button AdminButton;
        private Button NormallButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
    }
}