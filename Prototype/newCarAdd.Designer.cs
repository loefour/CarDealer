namespace Prototype
{
    partial class newCarAdd
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
            carImage = new PictureBox();
            nameTexBox = new TextBox();
            infoTextBox = new TextBox();
            priceTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)carImage).BeginInit();
            SuspendLayout();
            // 
            // carImage
            // 
            carImage.Location = new Point(87, 43);
            carImage.Name = "carImage";
            carImage.Size = new Size(210, 192);
            carImage.SizeMode = PictureBoxSizeMode.StretchImage;
            carImage.TabIndex = 1;
            carImage.TabStop = false;
            carImage.Click += carImage_Click;
            // 
            // nameTexBox
            // 
            nameTexBox.Location = new Point(87, 260);
            nameTexBox.Name = "nameTexBox";
            nameTexBox.Size = new Size(210, 27);
            nameTexBox.TabIndex = 2;
            // 
            // infoTextBox
            // 
            infoTextBox.Location = new Point(87, 333);
            infoTextBox.Multiline = true;
            infoTextBox.Name = "infoTextBox";
            infoTextBox.Size = new Size(210, 126);
            infoTextBox.TabIndex = 3;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(87, 489);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(210, 27);
            priceTextBox.TabIndex = 4;
            priceTextBox.KeyPress += priceTextBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 267);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 5;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 333);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 6;
            label2.Text = "Info :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 496);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 7;
            label3.Text = "Price :";
            // 
            // button1
            // 
            button1.Location = new Point(87, 550);
            button1.Name = "button1";
            button1.Size = new Size(210, 29);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // newCarAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 624);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(priceTextBox);
            Controls.Add(infoTextBox);
            Controls.Add(nameTexBox);
            Controls.Add(carImage);
            Name = "newCarAdd";
            Text = "newCarAdd";
            Load += newCarAdd_Load;
            ((System.ComponentModel.ISupportInitialize)carImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox carImage;
        private TextBox nameTexBox;
        private TextBox infoTextBox;
        private TextBox priceTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private OpenFileDialog openFileDialog1;
    }
}