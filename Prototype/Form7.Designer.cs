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
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)userImage).BeginInit();
            SuspendLayout();
            // 
            // userImage
            // 
            userImage.Location = new Point(94, 64);
            userImage.Name = "userImage";
            userImage.Size = new Size(210, 192);
            userImage.SizeMode = PictureBoxSizeMode.StretchImage;
            userImage.TabIndex = 0;
            userImage.TabStop = false;
            // 
            // nameLebel
            // 
            nameLebel.BackColor = Color.Transparent;
            nameLebel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic);
            nameLebel.Location = new Point(115, 282);
            nameLebel.Name = "nameLebel";
            nameLebel.Size = new Size(192, 48);
            nameLebel.TabIndex = 2;
            nameLebel.Text = "label1";
            nameLebel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // emailLabel
            // 
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(115, 338);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(189, 48);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "label2";
            emailLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // vaultTextBox
            // 
            vaultTextBox.Location = new Point(115, 396);
            vaultTextBox.Name = "vaultTextBox";
            vaultTextBox.Size = new Size(157, 27);
            vaultTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(41, 396);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 6;
            label1.Text = "Vault :";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(44, 194, 123);
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(94, 461);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(210, 47);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(41, 294);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 8;
            label2.Text = "Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(41, 348);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 9;
            label3.Text = "Email :";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(210, 213, 213);
            button2.Image = Properties.Resources.cross__1_;
            button2.Location = new Point(1, 0);
            button2.Name = "button2";
            button2.Size = new Size(39, 36);
            button2.TabIndex = 19;
            button2.UseVisualStyleBackColor = false;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gradient__11_6;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(385, 544);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(saveButton);
            Controls.Add(label1);
            Controls.Add(vaultTextBox);
            Controls.Add(emailLabel);
            Controls.Add(nameLebel);
            Controls.Add(userImage);
            Cursor = Cursors.Default;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
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
        private Label label2;
        private Label label3;
        private Button button2;
    }
}