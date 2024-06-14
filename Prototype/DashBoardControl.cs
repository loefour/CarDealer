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
    public partial class DashBoardControl : UserControl
    {
        public DashBoardControl()
        {
            InitializeComponent();
        }

        public string name
        {
            get { return carnameLabel.Text; }
            set { carnameLabel.Text = value; }
        }


        public string image
        {
            get { return carImage.ImageLocation; }
            set { carImage.ImageLocation = value; }
        }

        private void carnameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
