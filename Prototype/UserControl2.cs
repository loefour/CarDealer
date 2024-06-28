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
    public partial class UserControl2 : UserControl
    {

        private string connectionString = "Data Source=DESKTOP-RC7E9BL\\MSSQLSERVER01;Initial Catalog=loginapp;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";


        public UserControl2()
        {
            InitializeComponent();
        }

        public string name
        {
            get { return nameLabel.Text; }
            set { nameLabel.Text = value; }
        }


        public string image
        {
            get { return carPicture.ImageLocation; }
            set { carPicture.ImageLocation = value; }
        }

        public string price
        {
            get { return priceLabel.Text; }
            set {  priceLabel.Text = value; }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to Delete  Car {name}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "DELETE FROM image_list WHERE Name = @name";


                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand deletcmd = new SqlCommand(query, conn))
                {
                    deletcmd.Parameters.AddWithValue("@name", name);
                    try
                    {
                        conn.Open();
                        int rowsAffected = deletcmd.ExecuteNonQuery();
                        Console.WriteLine($"Deleted {rowsAffected} row(s)!");
                        MessageBox.Show($"The {name} remove from shop");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                        MessageBox.Show($"The {name} didn't remove from shop");

                    }
                }
            }

                
        }

        private void updatePriceButton_Click(object sender, EventArgs e)
        {
         
            UpdateCar.price = int.Parse(price, NumberStyles.Currency);
            UpdateCar.name = name;
            UpdateCar.image = image;


            carPriceUpdate update = new carPriceUpdate();

            update.ShowDialog();

        }
    }
}
