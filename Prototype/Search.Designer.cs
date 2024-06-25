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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CarPicture).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(490, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // CarPicture
            // 
            CarPicture.Image = Properties.Resources.photo_2024_06_07_22_13_25;
            CarPicture.Location = new Point(228, 161);
            CarPicture.Name = "CarPicture";
            CarPicture.Size = new Size(150, 150);
            CarPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            CarPicture.TabIndex = 3;
            CarPicture.TabStop = false;
            // 
            // lbname
            // 
            lbname.AutoSize = true;
            lbname.Location = new Point(276, 340);
            lbname.Name = "lbname";
            lbname.Size = new Size(50, 20);
            lbname.TabIndex = 4;
            lbname.Text = "label1";
            // 
            // lbinfo
            // 
            lbinfo.Location = new Point(100, 370);
            lbinfo.Name = "lbinfo";
            lbinfo.Size = new Size(402, 59);
            lbinfo.TabIndex = 5;
            lbinfo.Text = "label2";
            lbinfo.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbprice
            // 
            lbprice.AutoSize = true;
            lbprice.Location = new Point(276, 445);
            lbprice.Name = "lbprice";
            lbprice.Size = new Size(50, 20);
            lbprice.TabIndex = 6;
            lbprice.Text = "label3";
            // 
            // purchusButton
            // 
            purchusButton.Location = new Point(175, 500);
            purchusButton.Name = "purchusButton";
            purchusButton.Size = new Size(251, 40);
            purchusButton.TabIndex = 7;
            purchusButton.Text = "Purchus";
            purchusButton.UseVisualStyleBackColor = true;
            purchusButton.Click += purchusButton_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(3, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(400, 20);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(78, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 46);
            panel1.TabIndex = 9;
            // 
            // containerResualt
            // 
            containerResualt.AutoScroll = true;
            containerResualt.Location = new Point(78, 88);
            containerResualt.Name = "containerResualt";
            containerResualt.Size = new Size(405, 0);
            containerResualt.TabIndex = 10;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(588, 581);
            Controls.Add(containerResualt);
            Controls.Add(panel1);
            Controls.Add(purchusButton);
            Controls.Add(lbprice);
            Controls.Add(lbinfo);
            Controls.Add(lbname);
            Controls.Add(CarPicture);
            Controls.Add(pictureBox1);
            Name = "Search";
            Text = "Search";
            Load += Search_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CarPicture).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}