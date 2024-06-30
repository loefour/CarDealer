namespace Prototype
{
    partial class DashBoardControl
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
            carImage = new PictureBox();
            carnameLabel = new Label();
            PriceLabel = new Label();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            infolabel = new Label();
            ((System.ComponentModel.ISupportInitialize)carImage).BeginInit();
            SuspendLayout();
            // 
            // carImage
            // 
            carImage.Location = new Point(3, 3);
            carImage.Name = "carImage";
            carImage.Size = new Size(267, 171);
            carImage.SizeMode = PictureBoxSizeMode.StretchImage;
            carImage.TabIndex = 0;
            carImage.TabStop = false;
            // 
            // carnameLabel
            // 
            carnameLabel.AutoSize = true;
            carnameLabel.Font = new Font("Calisto MT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            carnameLabel.Location = new Point(63, 205);
            carnameLabel.Name = "carnameLabel";
            carnameLabel.Size = new Size(57, 21);
            carnameLabel.TabIndex = 2;
            carnameLabel.Text = "Name";
            carnameLabel.TextAlign = ContentAlignment.MiddleCenter;
            carnameLabel.Click += carnameLabel_Click;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Segoe UI Light", 10.2F);
            PriceLabel.Location = new Point(56, 324);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(52, 23);
            PriceLabel.TabIndex = 3;
            PriceLabel.Text = "label2";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(183, 324);
            button1.Name = "button1";
            button1.Size = new Size(84, 29);
            button1.TabIndex = 7;
            button1.Text = "sale";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 10.2F);
            label2.Location = new Point(3, 324);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 6;
            label2.Text = "Price :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 10.2F);
            label1.Location = new Point(3, 203);
            label1.Name = "label1";
            label1.Size = new Size(62, 23);
            label1.TabIndex = 8;
            label1.Text = "Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 10.2F);
            label3.Location = new Point(3, 248);
            label3.Name = "label3";
            label3.Size = new Size(47, 23);
            label3.TabIndex = 9;
            label3.Text = "Info :";
            // 
            // infolabel
            // 
            infolabel.Font = new Font("Segoe UI Light", 10.2F);
            infolabel.Location = new Point(63, 248);
            infolabel.Name = "infolabel";
            infolabel.Size = new Size(189, 49);
            infolabel.TabIndex = 10;
            infolabel.Text = "Info";
            // 
            // DashBoardControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.gradient__11_;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(infolabel);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(PriceLabel);
            Controls.Add(carnameLabel);
            Controls.Add(carImage);
            DoubleBuffered = true;
            Name = "DashBoardControl";
            Size = new Size(273, 365);
            Load += DashBoardControl_Load;
            Click += DashBoardControl_Click;
            ((System.ComponentModel.ISupportInitialize)carImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox carImage;
        private Label carnameLabel;
        private Label PriceLabel;
        private Button button1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label infolabel;
    }
}
