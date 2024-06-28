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
using static System.Net.Mime.MediaTypeNames;

namespace Prototype
{
    public partial class Form5 : Form
    {


        private string connectionString = "Data Source=DESKTOP-RC7E9BL\\MSSQLSERVER01;Initial Catalog=loginapp;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";



        public Form5()
        {
            InitializeComponent();



        }


        private void CreateUserControll(string name, string vault, string image, string usertype, string email)
        {
            UserControl1 userlabel = new UserControl1();
            {
                userlabel.name = name;
                userlabel.vault = "$" + vault;
                userlabel.usertype = usertype;
                userlabel.image = image;
                userlabel.email = email;



            };


            flowLayoutPanel1.Controls.Add(userlabel);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM loginapp";



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader["username"].ToString();
                            string vault = reader["vault"].ToString();
                            string usertype = reader["admin"].ToString();
                            string image = reader["image"].ToString();
                            string email = reader["email"].ToString();



                            CreateUserControll(name, vault, image, usertype, email);

                        }



                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
    
            this.Close();
        }
    }
}
