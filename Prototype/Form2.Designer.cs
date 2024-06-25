namespace Prototype
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            label3 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            CloseEyeImage = new PictureBox();
            OpenEyeImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseEyeImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OpenEyeImage).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(63, 119, 132);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bauhaus 93", 9F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(65, 458);
            button1.Name = "button1";
            button1.Size = new Size(261, 29);
            button1.TabIndex = 4;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Bauhaus 93", 12F);
            label3.ForeColor = Color.FromArgb(71, 222, 217);
            label3.Location = new Point(130, 508);
            label3.Name = "label3";
            label3.Size = new Size(143, 23);
            label3.TabIndex = 5;
            label3.Text = "Back to Signup";
            label3.Click += label3_Click;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(101, 338);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(222, 20);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(101, 409);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(222, 20);
            textBox5.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(65, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(287, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Window;
            label4.Font = new Font("Broadway", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(71, 222, 217);
            label4.Location = new Point(135, 21);
            label4.Name = "label4";
            label4.Size = new Size(138, 42);
            label4.TabIndex = 9;
            label4.Text = "Log In";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user_3917559;
            pictureBox2.Location = new Point(66, 326);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(66, 394);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(63, 119, 132);
            panel1.Location = new Point(76, 357);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 1);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(63, 119, 132);
            panel2.Location = new Point(76, 428);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 1);
            panel2.TabIndex = 13;
            // 
            // CloseEyeImage
            // 
            CloseEyeImage.Cursor = Cursors.Hand;
            CloseEyeImage.Image = Properties.Resources.invisible_98494;
            CloseEyeImage.Location = new Point(316, 397);
            CloseEyeImage.Name = "CloseEyeImage";
            CloseEyeImage.Size = new Size(32, 32);
            CloseEyeImage.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseEyeImage.TabIndex = 14;
            CloseEyeImage.TabStop = false;
            CloseEyeImage.Click += CloseEyeImage_Click;
            // 
            // OpenEyeImage
            // 
            OpenEyeImage.Cursor = Cursors.Hand;
            OpenEyeImage.Image = Properties.Resources.eye_close_up_61916;
            OpenEyeImage.Location = new Point(316, 397);
            OpenEyeImage.Name = "OpenEyeImage";
            OpenEyeImage.Size = new Size(32, 32);
            OpenEyeImage.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenEyeImage.TabIndex = 15;
            OpenEyeImage.TabStop = false;
            OpenEyeImage.Click += OpenEyeImage_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(411, 628);
            Controls.Add(OpenEyeImage);
            Controls.Add(CloseEyeImage);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseEyeImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)OpenEyeImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox5;
        private PictureBox pictureBox1;
        private Label label4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Panel panel2;
        private PictureBox CloseEyeImage;
        private PictureBox OpenEyeImage;
    }
}