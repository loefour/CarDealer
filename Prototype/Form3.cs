﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;
using System.Collections;
using System.Reflection;
using System.Globalization;

namespace Prototype
{

    public partial class Form3 : Form
    {

        public bool sidbarExpand;


        private string connectionString = "Data Source=DESKTOP-RC7E9BL\\MSSQLSERVER01;Initial Catalog=loginapp;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";








        public Form3()
        {
            InitializeComponent();

            Debug.WriteLine(Class1.UserName + Class1.UserEmail + Class1.UserPass);

            string Id = Convert.ToString(Class1.UserId);

            label1.Text = Class1.UserName;
            label2.Text = Class1.UserEmail;
            Debug.WriteLine(Id + "Hello World");
            label4.Text = "$" + Convert.ToString(Class1.UserVault);


            pictureBox1.ImageLocation = Class1.UserImage;
            Debug.WriteLine(Class1.UserAdmin);
            /* Debug.WriteLine(Class1.UserImage + "Hello World");*/

            if (Class1.UserAdmin == "administrator")
            {
                userManageLabel.Enabled = true;
                updatebutton.Enabled = true;
                userManageLabel.Visible = true;
                updatebutton.Visible = true;
            }
            else if (Class1.UserAdmin == "admin")
            {
                userManageLabel.Enabled = true;
                updatebutton.Enabled = false;
                userManageLabel.Visible = true;
                updatebutton.Visible = false;
                updatebutton.Hide();


            }
            else
            {
                userManageLabel.Enabled = false;
                updatebutton.Enabled = false;
                userManageLabel.Visible = false;
                updatebutton.Visible = false;
                updatebutton.Hide();
                userManageLabel.Hide();
            }


        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sidbarExpand)
            {
                sideBar.Width -= 10;
                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    sidbarExpand = false;
                    pictureBox1.Hide();
                    label1.Hide();
                    label2.Hide();

                    sideBarTimer.Stop();
                }

            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sidbarExpand = true;
                    pictureBox1.Show();
                    label1.Show();
                    label2.Show();

                    sideBarTimer.Stop();
                }
            }
        }

        public int active = 0;
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            sideBarTimer.Start();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();


            DashBoard dashBoard = new DashBoard();

            dashBoard.ShowDialog();

            this.Close();

        }


        private void Form3_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;



            string query = "SELECT * FROM image_list";



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader["name"].ToString();
                            string info = reader["info"].ToString();
                            string price = reader["price"].ToString();
                            string image = reader["image"].ToString();


                            CreateUserControll(name, info, price, image);

                        }



                    }
                }
            }
        }




        private void CreateUserControll(string name, string info, string price, string image)
        {
            CarControl nameLabel = new CarControl();
            {
                nameLabel.name = name;
                nameLabel.info = info;
                nameLabel.price = "$" + price;
                nameLabel.image = image;


            };




            flowLayoutPanel1.Controls.Add(nameLabel);
        }

        private void buttonRefrsh_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM loginapp WHERE Username = @username";



            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", Class1.UserName);
                Debug.WriteLine(Class1.UserName);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    string newVualt = rdr["vault"].ToString();
                    Debug.WriteLine(newVualt);
                    int isZero = int.Parse(newVualt);
                    if (isZero <= 0)
                    {
                        isZero = 0;

                        label4.Text = "$" + isZero;
                    }

                    Debug.WriteLine(newVualt);
                    Class1.UserVault = int.Parse(newVualt);
                    Debug.WriteLine(Class1.UserVault);
                    label4.Text = "$" + newVualt;
                }
            }


            /*  string query3 = "UPDATE loginapp SET Vault = @vault WHERE Username = @username";

              using (SqlConnection conn = new SqlConnection(connectionString))
              using (SqlCommand cmd = new SqlCommand(query3, conn))
              {

                  cmd.Parameters.AddWithValue("@vault", Class1.UserVault);
                  cmd.Parameters.AddWithValue("@username", Class1.UserName);
                  Debug.WriteLine(Class1.UserVault);
                  label4.Text = Class1.UserVault.ToString();


                  conn.Open();
                  cmd.ExecuteReader();
              }*/



            this.Hide();
            Debug.WriteLine("Slama mashty");
            Form3 newForm = new Form3();
            newForm.FormClosed += (s, args) => this.Close();


            newForm.ShowDialog();
            Debug.WriteLine("khodahafez mashty");
            this.Close();




        }

        private void userManageLabel_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to LogOut?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Debug.WriteLine("Slama mashty");
                Form2 newForm = new Form2();
                newForm.FormClosed += (s, args) => this.Close();


                newForm.ShowDialog();
                Debug.WriteLine("khodahafez mashty");
                this.Close();
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {

            update update = new update();
            update.ShowDialog();

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Search search = new Search();
            search.ShowDialog();

            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void sideBar_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_MouseHover(object sender, EventArgs e)
        {
            if (Class1.UserAdmin == "administrator" || Class1.UserAdmin == "admin")
            {
                button1.BackColor = Color.FromArgb(255, 192, 128);
                button1.ForeColor = Color.White;
            }
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (Class1.UserAdmin == "administrator" || Class1.UserAdmin == "admin")
            {
                button1.BackColor = Color.Transparent;
                button1.ForeColor = Color.White;
            }
        }

        private void buttonRefrsh_MouseHover(object sender, EventArgs e)
        {
            if (Class1.UserAdmin == "administrator" || Class1.UserAdmin == "admin")
            {
                buttonRefrsh.BackColor = Color.FromArgb(255, 192, 128);
                buttonRefrsh.ForeColor = Color.White;
            }
        }

        private void buttonRefrsh_MouseLeave(object sender, EventArgs e)
        {
            if (Class1.UserAdmin == "administrator" || Class1.UserAdmin == "admin")
            {
                buttonRefrsh.BackColor = Color.Transparent;
                buttonRefrsh.ForeColor = Color.White;
            }
        }

        private void SearchButton_MouseHover(object sender, EventArgs e)
        {
            if (Class1.UserAdmin == "administrator" || Class1.UserAdmin == "admin")
            {
                SearchButton.BackColor = Color.FromArgb(255, 192, 128);
                SearchButton.ForeColor = Color.White;
            }
        }

        private void SearchButton_MouseLeave(object sender, EventArgs e)
        {
            if (Class1.UserAdmin == "administrator" || Class1.UserAdmin == "admin")
            {
                SearchButton.BackColor = Color.Transparent;
                SearchButton.ForeColor = Color.White;
            }
        }

        private void logOutButton_MouseHover(object sender, EventArgs e)
        {
            if (Class1.UserAdmin == "administrator" || Class1.UserAdmin == "admin")
            {
                logOutButton.BackColor = Color.FromArgb(255, 192, 128);
                logOutButton.ForeColor = Color.White;
            }
        }

        private void logOutButton_MouseLeave(object sender, EventArgs e)
        {
            if (Class1.UserAdmin == "administrator" || Class1.UserAdmin == "admin")
            {
                logOutButton.BackColor = Color.Transparent;
                logOutButton.ForeColor = Color.White;
            }
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            if (Class1.UserAdmin == "administrator" || Class1.UserAdmin == "admin")
            {
                button2.BackColor = Color.FromArgb(255, 192, 128);
                button2.ForeColor = Color.White;
            }
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            if (Class1.UserAdmin == "administrator" || Class1.UserAdmin == "admin")
            {
                button2.BackColor = Color.Transparent;
                button2.ForeColor = Color.White;
            }
        }

        private void userManageLabel_MouseHover(object sender, EventArgs e)
        {
            if (Class1.UserAdmin == "administrator" || Class1.UserAdmin == "admin")
            {
                userManageLabel.BackColor = Color.FromArgb(255, 192, 128);
                userManageLabel.ForeColor = Color.White;
            }
        }

        private void userManageLabel_MouseLeave(object sender, EventArgs e)
        {
            if (Class1.UserAdmin == "administrator" || Class1.UserAdmin == "admin")
            {
                userManageLabel.BackColor = Color.Transparent;
                userManageLabel.ForeColor = Color.White;
            }
        }

        private void updatebutton_MouseHover(object sender, EventArgs e)
        {
            if (Class1.UserAdmin == "administrator" || Class1.UserAdmin == "admin")
            {
                updatebutton.BackColor = Color.FromArgb(255, 192, 128);
                updatebutton.ForeColor = Color.White;
            }
        }

        private void updatebutton_MouseLeave(object sender, EventArgs e)
        {
            if (Class1.UserAdmin == "administrator" || Class1.UserAdmin == "admin")
            {
                updatebutton.BackColor = Color.Transparent;
                updatebutton.ForeColor = Color.White;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            About about = new About();

            about.Show();

            
        }

        private void label4_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to Close The App?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
