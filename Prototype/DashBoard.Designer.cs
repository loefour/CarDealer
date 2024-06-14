namespace Prototype
{
    partial class DashBoard
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            nameLabel = new Label();
            emailLabel = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)userImage).BeginInit();
            SuspendLayout();
            // 
            // userImage
            // 
            userImage.Location = new Point(628, 36);
            userImage.Name = "userImage";
            userImage.Size = new Size(211, 172);
            userImage.SizeMode = PictureBoxSizeMode.StretchImage;
            userImage.TabIndex = 0;
            userImage.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(34, 40, 45);
            flowLayoutPanel1.Location = new Point(12, 36);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5, 10, 10, 0);
            flowLayoutPanel1.Size = new Size(557, 547);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.Location = new Point(696, 229);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(94, 66);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "name";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailLabel
            // 
            emailLabel.Location = new Point(619, 295);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(255, 58);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "email";
            emailLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(671, 431);
            button1.Name = "button1";
            button1.Size = new Size(137, 63);
            button1.TabIndex = 0;
            button1.Text = "Back To Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 595);
            Controls.Add(button1);
            Controls.Add(emailLabel);
            Controls.Add(nameLabel);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(userImage);
            Name = "DashBoard";
            Text = "DashBoard";
            Load += DashBoard_Load;
            ((System.ComponentModel.ISupportInitialize)userImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox userImage;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label nameLabel;
        private Label emailLabel;
        private Button button1;
    }
}