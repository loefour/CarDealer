namespace Prototype
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            label5 = new Label();
            label6 = new Label();
            OpenEyeImage = new PictureBox();
            CloseEyeImage = new PictureBox();
            label7 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OpenEyeImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseEyeImage).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(63, 119, 132);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bauhaus 93", 9F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(82, 533);
            button1.Name = "button1";
            button1.Size = new Size(250, 29);
            button1.TabIndex = 13;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bauhaus 93", 10.8F);
            label3.Location = new Point(79, 401);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 12;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bauhaus 93", 10.8F);
            label2.Location = new Point(83, 456);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 11;
            label2.Text = "Pass:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 10.8F);
            label1.Location = new Point(78, 347);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 10;
            label1.Text = "Name:";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(140, 455);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(196, 20);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(140, 400);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(196, 20);
            textBox2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Bauhaus 93", 12F);
            label4.ForeColor = Color.FromArgb(71, 222, 217);
            label4.Location = new Point(180, 580);
            label4.Name = "label4";
            label4.Size = new Size(57, 23);
            label4.TabIndex = 14;
            label4.Text = "Login";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(140, 345);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 20);
            textBox1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(128, 128, 255);
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.default_avatar_profile_icon_of_social_media_user_vector;
            pictureBox1.Location = new Point(119, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(63, 119, 132);
            panel2.Location = new Point(84, 420);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 1);
            panel2.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(63, 119, 132);
            panel1.Location = new Point(84, 475);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 1);
            panel1.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(63, 119, 132);
            panel3.Location = new Point(84, 365);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 1);
            panel3.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Window;
            label5.Font = new Font("Broadway", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(71, 222, 217);
            label5.Location = new Point(133, 273);
            label5.Name = "label5";
            label5.Size = new Size(167, 42);
            label5.TabIndex = 18;
            label5.Text = "Sign Up";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bauhaus 93", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(63, 119, 132);
            label6.Location = new Point(131, 222);
            label6.Name = "label6";
            label6.Size = new Size(175, 23);
            label6.TabIndex = 19;
            label6.Text = "Select Your Picture";
            // 
            // OpenEyeImage
            // 
            OpenEyeImage.Cursor = Cursors.Hand;
            OpenEyeImage.Image = Properties.Resources.eye_close_up_61916;
            OpenEyeImage.Location = new Point(327, 446);
            OpenEyeImage.Name = "OpenEyeImage";
            OpenEyeImage.Size = new Size(32, 32);
            OpenEyeImage.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenEyeImage.TabIndex = 21;
            OpenEyeImage.TabStop = false;
            OpenEyeImage.Click += OpenEyeImage_Click_1;
            // 
            // CloseEyeImage
            // 
            CloseEyeImage.Cursor = Cursors.Hand;
            CloseEyeImage.Image = Properties.Resources.invisible_98494;
            CloseEyeImage.Location = new Point(327, 446);
            CloseEyeImage.Name = "CloseEyeImage";
            CloseEyeImage.Size = new Size(32, 32);
            CloseEyeImage.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseEyeImage.TabIndex = 20;
            CloseEyeImage.TabStop = false;
            CloseEyeImage.Click += CloseEyeImage_Click_1;
            // 
            // label7
            // 
            label7.ForeColor = Color.Red;
            label7.Location = new Point(84, 492);
            label7.Name = "label7";
            label7.Size = new Size(248, 20);
            label7.TabIndex = 22;
            label7.Text = "label7";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            label7.Visible = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.cross__1_;
            button3.Location = new Point(-1, -1);
            button3.Name = "button3";
            button3.Size = new Size(40, 43);
            button3.TabIndex = 23;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(430, 646);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(panel2);
            Controls.Add(OpenEyeImage);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Controls.Add(CloseEyeImage);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(panel3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0.9D;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)OpenEyeImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseEyeImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Label label5;
        private Label label6;
        private PictureBox OpenEyeImage;
        private PictureBox CloseEyeImage;
        private Label label7;
        private Button button3;
    }
}
