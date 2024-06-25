using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    public partial class SearchCarControl : UserControl
    {
        public static string name;

        public SearchCarControl()
        {
            InitializeComponent();
        }
        string temp_name;

        private void SearchCarControl_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;

        }

        public void details(DataSearch search)
        {
            nameLabel.Text = search.name;
            pricelabel.Text = search.price;
            pictureBox1.ImageLocation = search.image;
            temp_name = search.name;
        }

        public void search_Resualt(string key)
        {
            DataSearch get = new DataSearch();
            get.search(key);
            nameLabel.Text = get.name;
            pricelabel.Text = get.price;
            pictureBox1.ImageLocation = get.image;
        }

        private void SearchCarControl_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void SearchCarControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

        }

        public static bool clicked = false;

        private void SearchCarControl_Click(object sender, EventArgs e)
        {
            clicked = true;
            name = temp_name;
            
        }
    }
}
