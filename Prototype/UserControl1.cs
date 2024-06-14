using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public string name
        {
            get { return namelabel.Text; }
            set { namelabel.Text = value; }
        }


        public string vault
        {
            get { return budgetlabel.Text; }
            set { budgetlabel.Text = value; }
        }


        public string usertype
        {
            get { return userControll.Text; }
            set { userControll.Text = value; }
        }

        public string email
        {
            get { return emailLabel.Text; }
            set { emailLabel.Text = value; }
        }


        public string image
        {
            get { return userImage.ImageLocation; }
            set { userImage.ImageLocation = value; }
        }

        private void LevelUpButton_Click(object sender, EventArgs e)
        {
            userManager.image = image;
            userManager.name = name;
            userManager.email = email;
            userManager.userIsAdmin = usertype;





            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void uservaultButton_Click(object sender, EventArgs e)
        {
            userManager.image = image;
            userManager.name = name;
            userManager.email = email;
            Debug.WriteLine(vault);
            userManager.vault = int.Parse(vault, NumberStyles.Currency);



            Form7 form7 = new Form7();
            form7.ShowDialog();
        }
    }
}
