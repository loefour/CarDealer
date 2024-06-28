namespace Prototype
{
    partial class CarControl
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
            carimage = new PictureBox();
            labelname = new Label();
            labelinfo = new Label();
            labelprice = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)carimage).BeginInit();
            SuspendLayout();
            // 
            // carimage
            // 
            carimage.Location = new Point(5, 3);
            carimage.Name = "carimage";
            carimage.Size = new Size(201, 151);
            carimage.SizeMode = PictureBoxSizeMode.StretchImage;
            carimage.TabIndex = 0;
            carimage.TabStop = false;
            carimage.Click += carimage_Click;
            // 
            // labelname
            // 
            labelname.AutoSize = true;
            labelname.BackColor = Color.Transparent;
            labelname.Location = new Point(268, 20);
            labelname.Name = "labelname";
            labelname.Size = new Size(46, 20);
            labelname.TabIndex = 1;
            labelname.Text = "name";
            // 
            // labelinfo
            // 
            labelinfo.BackColor = Color.Transparent;
            labelinfo.Location = new Point(268, 60);
            labelinfo.Name = "labelinfo";
            labelinfo.Size = new Size(531, 31);
            labelinfo.TabIndex = 2;
            labelinfo.Text = "info";
            // 
            // labelprice
            // 
            labelprice.AutoSize = true;
            labelprice.BackColor = Color.Transparent;
            labelprice.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelprice.Location = new Point(267, 107);
            labelprice.Name = "labelprice";
            labelprice.Size = new Size(62, 26);
            labelprice.TabIndex = 3;
            labelprice.Text = "price";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Location = new Point(272, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 1);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Location = new Point(272, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 1);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Location = new Point(272, 136);
            panel3.Name = "panel3";
            panel3.Size = new Size(150, 1);
            panel3.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(212, 20);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 7;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(212, 60);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 8;
            label2.Text = "Info :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(212, 108);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 9;
            label3.Text = "Price :";
            // 
            // CarControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.gradient__10_;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(labelprice);
            Controls.Add(labelinfo);
            Controls.Add(labelname);
            Controls.Add(carimage);
            Name = "CarControl";
            Size = new Size(850, 157);
            Load += CarControl_Load;
            ((System.ComponentModel.ISupportInitialize)carimage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox carimage;
        private Label labelname;
        private Label labelinfo;
        private Label labelprice;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
