using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    public partial class Form6 : Form
    {

        private string connectionString = "Data Source=DESKTOP-RC7E9BL\\MSSQLSERVER01;Initial Catalog=loginapp;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";


        public Form6()
        {
            InitializeComponent();


        }

        private void Form6_Load(object sender, EventArgs e)
        {

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, userPicture.Width - 3, userPicture.Height - 3);
            Region rg = new Region(gp);
            userPicture.Region = rg;


            nameLebel.Text = userManager.name;
            userPicture.ImageLocation = userManager.image;
            emailLabel.Text = userManager.email;
            userTypeLabel.Text = userManager.userIsAdmin;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to LevelUp {userManager.name} ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "UPDATE loginapp SET Admin = @admin WHERE Username = @username";


                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    string isAdmin = userTypeLabel.Text;
                    string newAdmin = "";

                    if (isAdmin != "admin")
                    {
                        newAdmin = "admin";

                        cmd.Parameters.AddWithValue("@admin", newAdmin);
                        cmd.Parameters.AddWithValue("@username", nameLebel.Text);

                        conn.Open();
                        SqlDataReader rdr = cmd.ExecuteReader();
                        if (rdr.Read())
                        {
                            string admin = rdr["admin"].ToString();

                            Debug.WriteLine(admin);
                        }

                        MessageBox.Show("user successfully add to admin", "Successfully Admin");

                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("This user is Allready Admin", "Allready Admin");
                        newAdmin = userTypeLabel.Text;

                        this.Close();
                    }
                }
            }
                
        }

        private void NormallButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to make {userManager.name} as normal User ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "UPDATE loginapp SET Admin = @admin WHERE Username = @username";


                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    string isAdmin = userTypeLabel.Text;
                    string newAdmin = "";

                    if (isAdmin == "admin")
                    {
                        newAdmin = "";

                        cmd.Parameters.AddWithValue("@admin", newAdmin);
                        cmd.Parameters.AddWithValue("@username", nameLebel.Text);
                        /*  Class1.UserAdmin = newAdmin;*/

                        conn.Open();
                        SqlDataReader rdr = cmd.ExecuteReader();
                        if (rdr.Read())
                        {
                            string admin = rdr["admin"].ToString();

                            Debug.WriteLine(admin);
                        }

                        MessageBox.Show("user successfully add to normall", "Successfully normall");

                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("This user is Allready Normall", "Allready Normall");
                        newAdmin = userTypeLabel.Text;

                        this.Close();
                    }
                }
            }


                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
