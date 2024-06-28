using Microsoft.Data.SqlClient;
using System;
using System.Collections;
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
    public partial class update : Form
    {

        private string connectionString = "Data Source=DESKTOP-RC7E9BL\\MSSQLSERVER01;Initial Catalog=loginapp;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";


        public update()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void CreateUserControll(string name, string image, string price)
        {
            UserControl2 control = new UserControl2();
            {
                control.name = name;
                control.image = image;
                control.price = price;
            }

            flowLayoutPanel1.Controls.Add(control);

        }


        private void update_Load(object sender, EventArgs e)
        {


            string query = $"SELECT * FROM image_list";


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
                            string price = "$" + reader["price"].ToString();
                            Debug.WriteLine(price);


                            CreateUserControll(name, image, price);

                        }



                    }
                }
            }
        }

        private void CarAdderButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            newCarAdd newCar = new newCarAdd();

            newCar.ShowDialog();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
