namespace Prototype
{
    partial class update
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            CarAdderButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.LightGray;
            flowLayoutPanel1.ForeColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel1.Location = new Point(0, 45);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10, 0, 10, 0);
            flowLayoutPanel1.Size = new Size(541, 417);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // CarAdderButton
            // 
            CarAdderButton.BackgroundImage = Properties.Resources.gradient__11_2;
            CarAdderButton.BackgroundImageLayout = ImageLayout.Stretch;
            CarAdderButton.Location = new Point(0, 461);
            CarAdderButton.Name = "CarAdderButton";
            CarAdderButton.Size = new Size(541, 76);
            CarAdderButton.TabIndex = 0;
            CarAdderButton.Text = "AddCar";
            CarAdderButton.UseVisualStyleBackColor = true;
            CarAdderButton.Click += CarAdderButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(213, 214, 215);
            button1.Image = Properties.Resources.cross__1_;
            button1.Location = new Point(0, 3);
            button1.Name = "button1";
            button1.Size = new Size(39, 36);
            button1.TabIndex = 12;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(540, 536);
            Controls.Add(button1);
            Controls.Add(CarAdderButton);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "update";
            Text = "update";
            Load += update_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button CarAdderButton;
        private Button button1;
    }
}