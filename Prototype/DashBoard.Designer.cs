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
            label3 = new Label();
            spendLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)userImage).BeginInit();
            SuspendLayout();
            // 
            // userImage
            // 
            userImage.Location = new Point(49, 34);
            userImage.Name = "userImage";
            userImage.Size = new Size(200, 200);
            userImage.SizeMode = PictureBoxSizeMode.StretchImage;
            userImage.TabIndex = 0;
            userImage.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(308, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5, 10, 10, 0);
            flowLayoutPanel1.Size = new Size(580, 571);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // nameLabel
            // 
            nameLabel.BackColor = Color.Transparent;
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(87, 270);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(196, 28);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "  name";
            nameLabel.TextAlign = ContentAlignment.MiddleLeft;
            nameLabel.Click += nameLabel_Click;
            // 
            // emailLabel
            // 
            emailLabel.BackColor = Color.Transparent;
            emailLabel.ForeColor = Color.White;
            emailLabel.Location = new Point(84, 363);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(196, 34);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "   email";
            emailLabel.TextAlign = ContentAlignment.MiddleLeft;
            emailLabel.Click += emailLabel_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(30, 501);
            button1.Name = "button1";
            button1.Size = new Size(255, 63);
            button1.TabIndex = 0;
            button1.Text = "Back To Menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(18, 444);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 10;
            label3.Text = "Total Spend : ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // spendLabel
            // 
            spendLabel.AutoSize = true;
            spendLabel.BackColor = Color.Transparent;
            spendLabel.ForeColor = Color.White;
            spendLabel.Location = new Point(123, 444);
            spendLabel.Name = "spendLabel";
            spendLabel.Size = new Size(49, 20);
            spendLabel.TabIndex = 9;
            spendLabel.Text = "spend";
            spendLabel.TextAlign = ContentAlignment.MiddleCenter;
            spendLabel.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 276);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 11;
            label1.Text = "Name :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(18, 368);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 12;
            label2.Text = "Email :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Location = new Point(35, 299);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 1);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Location = new Point(30, 394);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 1);
            panel2.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 128);
            panel3.Location = new Point(35, 467);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 1);
            panel3.TabIndex = 15;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(63, 119, 132);
            ClientSize = new Size(903, 595);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(spendLabel);
            Controls.Add(userImage);
            Controls.Add(button1);
            Controls.Add(emailLabel);
            Controls.Add(nameLabel);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashBoard";
            Text = "DashBoard";
            Load += DashBoard_Load;
            Click += DashBoard_Click;
            ((System.ComponentModel.ISupportInitialize)userImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox userImage;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label nameLabel;
        private Label emailLabel;
        private Button button1;
        private Label label3;
        private Label spendLabel;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}