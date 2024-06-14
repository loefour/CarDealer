using Microsoft.Data.SqlClient;
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
    public partial class DashBoard : Form
    {

        private string connectionString = "Data Source=DESKTOP-RC7E9BL\\MSSQLSERVER01;Initial Catalog=loginapp;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";


        public DashBoard()
        {
            InitializeComponent();
        }


        private void CreateUserControll(string name, string image)
        {
            DashBoardControl control = new DashBoardControl();
            {
                control.name = name;
                control.image = image;
            }

            flowLayoutPanel1.Controls.Add(control);

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            nameLabel.Text = Class1.UserName;
            emailLabel.Text = Class1.UserEmail;
            userImage.ImageLocation = Class1.UserImage;



            string query = $"SELECT * FROM {Class1.UserName}";



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
                            string image = reader["image"].ToString();




                            CreateUserControll(name, image);

                        }



                    }
                }
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 newform = new Form3();

            newform.ShowDialog();

            this.Close();
        }
    }
}
