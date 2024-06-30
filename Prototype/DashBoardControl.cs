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
    public partial class DashBoardControl : UserControl
    {


        private string connectionString = "Data Source=DESKTOP-RC7E9BL\\MSSQLSERVER01;Initial Catalog=loginapp;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";


        public DashBoardControl()
        {
            InitializeComponent();
        }



        public string name
        {
            get { return carnameLabel.Text; }
            set { carnameLabel.Text = value; }
        }


        public string image
        {
            get { return carImage.ImageLocation; }
            set { carImage.ImageLocation = value; }
        }

        public string price
        {
            get { return PriceLabel.Text; }
            set { PriceLabel.Text = value; }
        }


        public string info
        {
            get { return infolabel.Text; }
            set { infolabel.Text = value; }
        }



        private void carnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void DashBoardControl_Load(object sender, EventArgs e)
        {
            if (num >= 1)
            {
                button1.Enabled = false;
            }
        }

        private void DashBoardControl_Click(object sender, EventArgs e)
        {

        }

        public int num = 0;
        private void button1_Click(object sender, EventArgs e)
        {


            


            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to Sale Your {name}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string query = $"DELETE FROM {Class1.UserName} WHERE Name = @name";


                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand deletcmd = new SqlCommand(query, conn))
                {
                    deletcmd.Parameters.AddWithValue("@name", name);
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


                string query2 = "INSERT INTO image_list (Name, Info, Price, Image) VALUES (@name, @info, @price, @image)";

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query2, con))
                {

                    int IntPrice = int.Parse(price, NumberStyles.Currency);

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@info", info);
                    cmd.Parameters.AddWithValue("@price", IntPrice);
                    cmd.Parameters.AddWithValue("@image", image);

                    con.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show($"You Sale your {Name}.");

                    }

                }

                string query3 = "UPDATE loginapp SET Vault = @vault WHERE Username = @username";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query3, conn))
                {
                    Class1.UserVault = Class1.UserVault + int.Parse(price, NumberStyles.Currency);
                    

                    cmd.Parameters.AddWithValue("@vault", Class1.UserVault);
                    cmd.Parameters.AddWithValue("@username", Class1.UserName);
                    Debug.WriteLine(Class1.UserVault);

                    conn.Open();
                    cmd.ExecuteReader();
                }

            }

            num++;
        }
    }
}
