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
    public partial class Form2 : Form
    {

        private string connectionString = "Data Source=DESKTOP-RC7E9BL\\MSSQLSERVER01;Initial Catalog=loginapp;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";



        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            string username = textBox4.Text;
            string password = textBox5.Text;
            int uservault = 0;

            string query = "SELECT * FROM loginapp WHERE Username = @username AND Password = @password";


            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);





                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    string name = rdr["username"].ToString();
                    string email = rdr["email"].ToString();
                    string image = rdr["image"].ToString();
                    string pass = rdr["password"].ToString();
                    string vault = rdr["vault"].ToString();
                    string admin = rdr["admin"].ToString();




                    MessageBox.Show($"Login successful as {name}");


                    Class1.UserName = name;
                    Class1.UserEmail = email;
                    Class1.UserImage = image;
                    Class1.UserPass = pass;
                    Class1.UserVault = int.Parse(vault);
                    Class1.UserAdmin = admin;


                    this.Hide();
                    Form3 form3 = new Form3();
                    form3.ShowDialog();
                    this.Close();
                }
                else
                {

                    MessageBox.Show("Login failed. Please check your username and password.");


                }

            }

        }

        private void OpenEyeImage_Click(object sender, EventArgs e)
        {
            if (textBox5.PasswordChar == '\0')
            {
                CloseEyeImage.BringToFront();
                textBox5.PasswordChar = '*';
            }
        }

        private void CloseEyeImage_Click(object sender, EventArgs e)
        {
            {
                if (textBox5.PasswordChar == '*')
                {
                    OpenEyeImage.BringToFront();
                    textBox5.PasswordChar = '\0';
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to Close The App?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
