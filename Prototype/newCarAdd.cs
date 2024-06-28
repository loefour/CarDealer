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
using System.Xml;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Prototype
{
    public partial class newCarAdd : Form
    {


        private string connectionString = "Data Source=DESKTOP-RC7E9BL\\MSSQLSERVER01;Initial Catalog=loginapp;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";


        public newCarAdd()
        {
            InitializeComponent();
        }

        private void newCarAdd_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, carImage.Width - 3, carImage.Height - 3);
            Region rg = new Region(gp);
            carImage.Region = rg;
        }

        public string image = "";

        private void carImage_Click(object sender, EventArgs e)
        {
            DialogResult pictur = openFileDialog1.ShowDialog();
            Debug.WriteLine(pictur);
            if (pictur == DialogResult.OK)
            {
                image = openFileDialog1.FileName;
                carImage.ImageLocation = image;
                Debug.WriteLine(carImage.ImageLocation);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want Add {nameTexBox.Text} ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "INSERT INTO image_list (Name, Info, Price, Image) VALUES (@name, @info, @price, @image)";


                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("@name", nameTexBox.Text);
                    cmd.Parameters.AddWithValue("@info", infoTextBox.Text);
                    cmd.Parameters.AddWithValue("@price", priceTextBox.Text);
                    cmd.Parameters.AddWithValue("@image", image);



                    try
                    {

                        if (string.IsNullOrEmpty(image))

                        {
                            MessageBox.Show("Please Enter Valid Value");
                        }
                        else if (string.IsNullOrEmpty(nameTexBox.Text))

                        {
                            MessageBox.Show("Please Enter Valid Value");
                        }

                        else if (string.IsNullOrEmpty(infoTextBox.Text))

                        {
                            MessageBox.Show("Please Enter Valid Value");
                        }

                        else if (string.IsNullOrEmpty(priceTextBox.Text))

                        {
                            MessageBox.Show("Please Enter Valid Value");
                        }

                        else
                        {
                            con.Open();
                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show($"Registration successful {Name}.");
                                this.Close();
                            }
                        }





                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Invalid input. Please enter a valid integer.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }






                }
            }

                

        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid integer.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 form3 = new Form3();  
            form3.ShowDialog();

            this.Close();
        }
    }
}
