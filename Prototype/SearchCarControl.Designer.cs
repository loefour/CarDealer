namespace Prototype
{
    partial class SearchCarControl
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
            pricelabel = new Label();
            nameLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pricelabel
            // 
            pricelabel.AutoSize = true;
            pricelabel.Location = new Point(196, 48);
            pricelabel.Name = "pricelabel";
            pricelabel.Size = new Size(50, 20);
            pricelabel.TabIndex = 0;
            pricelabel.Text = "label1";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(196, 21);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(50, 20);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(140, 21);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 3;
            label3.Text = "Name: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(140, 48);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 2;
            label4.Text = "Price:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.default_avatar_profile_icon_of_social_media_user_vector;
            pictureBox1.Location = new Point(14, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // SearchCarControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(nameLabel);
            Controls.Add(pricelabel);
            Name = "SearchCarControl";
            Size = new Size(405, 87);
            Load += SearchCarControl_Load;
            Click += SearchCarControl_Click;
            MouseLeave += SearchCarControl_MouseLeave;
            MouseHover += SearchCarControl_MouseHover;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pricelabel;
        private Label nameLabel;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}
