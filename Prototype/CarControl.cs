using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    public partial class CarControl : UserControl
    {
        public CarControl()
        {
            InitializeComponent();
        }


        public string name
        {
            get { return labelname.Text; }
            set { labelname.Text = value; }
        }



        public string info
        {
            get { return labelinfo.Text; }
            set { labelinfo.Text = value; }
        }


        public string price
        {
            get { return labelprice.Text; }
            set { labelprice.Text = value; }
        }


        public string image
        {
            get { return carimage.ImageLocation; }
            set { carimage.ImageLocation = value; }
        }

        

        /*public event EventHandler ButtonClicked;

        private void OnButtonClicked()
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }*/


        private void carimage_Click(object sender, EventArgs e)
        {

            
            carGeter.name = name;
            carGeter.info = info;
            carGeter.price = int.Parse(price, NumberStyles.Currency);
            carGeter.image = image;


            /*OnButtonClicked();*/


            Form4 form4 = new Form4();

            form4.ShowDialog();


        }
    }
}
