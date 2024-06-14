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
            ((System.ComponentModel.ISupportInitialize)carimage).BeginInit();
            SuspendLayout();
            // 
            // carimage
            // 
            carimage.Location = new Point(19, 17);
            carimage.Name = "carimage";
            carimage.Size = new Size(178, 103);
            carimage.SizeMode = PictureBoxSizeMode.StretchImage;
            carimage.TabIndex = 0;
            carimage.TabStop = false;
            carimage.Click += carimage_Click;
            // 
            // labelname
            // 
            labelname.AutoSize = true;
            labelname.Location = new Point(203, 27);
            labelname.Name = "labelname";
            labelname.Size = new Size(46, 20);
            labelname.TabIndex = 1;
            labelname.Text = "name";
            // 
            // labelinfo
            // 
            labelinfo.AutoSize = true;
            labelinfo.Location = new Point(203, 58);
            labelinfo.Name = "labelinfo";
            labelinfo.Size = new Size(35, 20);
            labelinfo.TabIndex = 2;
            labelinfo.Text = "info";
            // 
            // labelprice
            // 
            labelprice.AutoSize = true;
            labelprice.Location = new Point(203, 89);
            labelprice.Name = "labelprice";
            labelprice.Size = new Size(42, 20);
            labelprice.TabIndex = 3;
            labelprice.Text = "price";
            // 
            // CarControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(labelprice);
            Controls.Add(labelinfo);
            Controls.Add(labelname);
            Controls.Add(carimage);
            Name = "CarControl";
            Size = new Size(961, 136);
            ((System.ComponentModel.ISupportInitialize)carimage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox carimage;
        private Label labelname;
        private Label labelinfo;
        private Label labelprice;
    }
}
