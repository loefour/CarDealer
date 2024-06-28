using Microsoft.Data.SqlClient;
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
    public partial class DashBoard : Form
    {

        private string connectionString = "Data Source=DESKTOP-RC7E9BL\\MSSQLSERVER01;Initial Catalog=loginapp;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";


        public DashBoard()
        {
            InitializeComponent();
        }


        private void CreateUserControll(string name, string image, string price, string info)
        {
            DashBoardControl control = new DashBoardControl();
            {
                control.name = name;
                control.image = image;
                control.price = price;
                control.info = info;



            }

            flowLayoutPanel1.Controls.Add(control);

        }

        public int spend = 0;
        public string totalSpend;

        private void DashBoard_Load(object sender, EventArgs e)
        {

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, userImage.Width - 3, userImage.Height - 3);
            Region rg = new Region(gp);
            userImage.Region = rg;

            flowLayoutPanel1.HorizontalScroll.Visible = false; // Hide horizontal scroll bar
            flowLayoutPanel1.VerticalScroll.Visible = false;


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
                            string price = "$" + reader["price"].ToString();
                            string info = reader["info"].ToString();


                            spend = spend + int.Parse(price, NumberStyles.Currency);

                            totalSpend = spend.ToString();

                            CreateUserControll(name, image, price, info);

                        }



                    }
                }
            }

            spendLabel.Text = "$" + totalSpend;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 newform = new Form3();

            newform.ShowDialog();

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }



        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            flowLayoutPanel1.AutoScroll = true;
               // Hide vertical scroll bar
        }

        private void DashBoard_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScroll = false;
               // Hide vertical scroll bar

        }
    }
}
