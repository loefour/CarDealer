namespace Prototype
{
    partial class Search
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            CarPicture = new PictureBox();
            lbname = new Label();
            lbinfo = new Label();
            lbprice = new Label();
            purchusButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            panel1 = new Panel();
            containerResualt = new FlowLayoutPanel();
            button1 = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CarPicture).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.search__1_;
            pictureBox1.Location = new Point(497, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 37);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // CarPicture
            // 
            CarPicture.BackColor = Color.Transparent;
            CarPicture.Image = Properties.Resources.photo_2024_06_07_22_13_25;
            CarPicture.Location = new Point(226, 150);
            CarPicture.Name = "CarPicture";
            CarPicture.Size = new Size(150, 150);
            CarPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            CarPicture.TabIndex = 3;
            CarPicture.TabStop = false;
            // 
            // lbname
            // 
            lbname.BackColor = Color.Transparent;
            lbname.ForeColor = Color.FromArgb(224, 224, 224);
            lbname.Location = new Point(276, 327);
            lbname.Name = "lbname";
            lbname.Size = new Size(50, 20);
            lbname.TabIndex = 4;
            lbname.Text = "label1";
            lbname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbinfo
            // 
            lbinfo.BackColor = Color.Transparent;
            lbinfo.ForeColor = Color.FromArgb(224, 224, 224);
            lbinfo.Location = new Point(100, 370);
            lbinfo.Name = "lbinfo";
            lbinfo.Size = new Size(402, 55);
            lbinfo.TabIndex = 5;
            lbinfo.Text = "label2";
            lbinfo.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbprice
            // 
            lbprice.BackColor = Color.Transparent;
            lbprice.ForeColor = Color.FromArgb(224, 224, 224);
            lbprice.Location = new Point(276, 451);
            lbprice.Name = "lbprice";
            lbprice.Size = new Size(50, 20);
            lbprice.TabIndex = 6;
            lbprice.Text = "label3";
            lbprice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // purchusButton
            // 
            purchusButton.BackColor = Color.Transparent;
            purchusButton.FlatStyle = FlatStyle.Flat;
            purchusButton.ForeColor = Color.FromArgb(224, 224, 224);
            purchusButton.Location = new Point(176, 498);
            purchusButton.Name = "purchusButton";
            purchusButton.Size = new Size(251, 40);
            purchusButton.TabIndex = 7;
            purchusButton.Text = "Purchus";
            purchusButton.UseVisualStyleBackColor = false;
            purchusButton.Click += purchusButton_Click;
            purchusButton.MouseLeave += purchusButton_MouseLeave;
            purchusButton.MouseHover += purchusButton_MouseHover;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(3, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(400, 27);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(63, 119, 132);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(88, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 30);
            panel1.TabIndex = 9;
            // 
            // containerResualt
            // 
            containerResualt.AutoScroll = true;
            containerResualt.BackColor = Color.FromArgb(116, 150, 158);
            containerResualt.Location = new Point(86, 88);
            containerResualt.Name = "containerResualt";
            containerResualt.Size = new Size(410, 0);
            containerResualt.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(65, 120, 133);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(65, 120, 133);
            button1.Image = Properties.Resources.cross__1_;
            button1.Location = new Point(2, 1);
            button1.Name = "button1";
            button1.Size = new Size(39, 36);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseHover += button1_MouseHover;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 128);
            panel3.Location = new Point(126, 428);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 1);
            panel3.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 192, 128);
            panel4.Location = new Point(176, 360);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 1);
            panel4.TabIndex = 16;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 192, 128);
            panel5.Location = new Point(176, 472);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 1);
            panel5.TabIndex = 17;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.gradient__10_1;
            ClientSize = new Size(588, 581);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(button1);
            Controls.Add(containerResualt);
            Controls.Add(panel1);
            Controls.Add(purchusButton);
            Controls.Add(CarPicture);
            Controls.Add(pictureBox1);
            Controls.Add(lbprice);
            Controls.Add(lbinfo);
            Controls.Add(lbname);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Search";
            Text = "Search";
            Load += Search_Load;
            MouseHover += Search_MouseHover;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CarPicture).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox CarPicture;
        private Label lbname;
        private Label lbinfo;
        private Label lbprice;
        private Button purchusButton;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
        private Panel panel1;
        private FlowLayoutPanel containerResualt;
        private Button button1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}