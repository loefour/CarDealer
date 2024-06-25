using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Prototype
{
    public partial class carPriceUpdate : Form
    {

        private string connectionString = "Data Source=DESKTOP-RC7E9BL\\MSSQLSERVER01;Initial Catalog=loginapp;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";


        public carPriceUpdate()
        {
            InitializeComponent();
        }

        private void carPriceUpdate_Load(object sender, EventArgs e)
        {
            nameLabel.Text = UpdateCar.name;
            carImage.ImageLocation = UpdateCar.image;
            priceTextBox.Text = UpdateCar.price.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string query = "UPDATE image_list SET Price = @price WHERE Name = @name";


            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand updateCmd = new SqlCommand(query, conn))
            {
                updateCmd.Parameters.AddWithValue("@name", nameLabel.Text);
                updateCmd.Parameters.AddWithValue("@price", priceTextBox.Text);
                try
                {
                    conn.Open();
                    int rowsAffected = updateCmd.ExecuteNonQuery();
                    Debug.WriteLine($"update {rowsAffected} row(s)!");
                    MessageBox.Show($"The {nameLabel.Text} price updated");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"update: {ex.Message}");
                    MessageBox.Show($"The {nameLabel.Text} price didn't update \n Error: {ex.Message}");

                }
            }
        }
    }
}
