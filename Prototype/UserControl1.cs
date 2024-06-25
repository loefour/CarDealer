using Microsoft.Data.SqlClient;
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

        


        private string connectionString = "Data Source=DESKTOP-RC7E9BL\\MSSQLSERVER01;Initial Catalog=loginapp;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";


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

        private void UserControl1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, userImage.Width - 3, userImage.Height - 3);
            Region rg = new Region(gp);
            userImage.Region = rg;

            if (Class1.UserAdmin == "administrator")
            {
                if(usertype== "administrator")
                {
                    deleteUser.Enabled = false;
                    deleteUser.Visible = false;
                    LevelUpButton.Enabled = false;
                    LevelUpButton.Visible = false;
                }
            }


            else if(Class1.UserAdmin == "admin")
            {
               deleteUser.Enabled = false;
               deleteUser.Visible = false;
               if(usertype == "admin" || usertype == "administrator")
                {
                    LevelUpButton.Enabled = false;
                    LevelUpButton.Visible = false;
                    uservaultButton.Enabled = false;
                    uservaultButton.Visible = false;
                }
            }




        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            

                string query3 = "DELETE FROM loginapp WHERE Username = @username";


                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand deletcmd = new SqlCommand(query3, conn))
                {
                    deletcmd.Parameters.AddWithValue("@username", name);
                    try
                    {
                        conn.Open();
                        int rowsAffected = deletcmd.ExecuteNonQuery();
                        Console.WriteLine($"Deleted {rowsAffected} row(s)!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
        }
    }
}
