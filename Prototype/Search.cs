using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    public partial class Search : Form
    {
       


        public string Carname;
        public string Carprice;
        public string Carimage;
        public string Carinfo;


        private string connectionString = "Data Source=DESKTOP-RC7E9BL\\MSSQLSERVER01;Initial Catalog=loginapp;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";



        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, CarPicture.Width - 3, CarPicture.Height - 3);
            Region rg = new Region(gp);
            CarPicture.Region = rg;


            if(lbname.Text == "label1")
            {
                purchusButton.Visible = false;
            }
            

        }

        private void loadDetails()
        {
            foreach (DataSearch data in DataSearch.list)
            {
                SearchCarControl car = new SearchCarControl();
                car.details(data);
                containerResualt.Controls.Add(car);
                Debug.WriteLine(car.Name);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength >= 1)
            {
                containerResualt.Controls.Clear();
                SearchCarControl ser = new SearchCarControl();
                ser.search_Resualt(textBox1.Text);
                loadDetails();
                containerResualt.Height = containerResualt.Controls.Count * 100;
            }
            else
            {
                containerResualt.Height = 0;
            }
        }

        private void resualtContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SearchCarControl.clicked == true)
            {
                DataSearch get = new DataSearch();
                get.SelectedData(SearchCarControl.name);
                lbname.Text = get.name;
                lbprice.Text = "$" + get.price;
                lbinfo.Text = get.info;
                CarPicture.ImageLocation = get.image;
                textBox1.Clear();
                SearchCarControl.clicked = false;
                purchusButton.Visible = true;
            }
        }

        private void purchusButton_Click(object sender, EventArgs e)
        {
            string query = "UPDATE loginapp SET Vault = @vault WHERE Username = @username";


            string query2 = $"INSERT INTO {Class1.UserName} (Image, Name, Price) VALUES (@image, @name, @price)";


            string query3 = "DELETE FROM image_list WHERE Name = @name";

            DataSearch get = new DataSearch();
            get.SelectedData(SearchCarControl.name);
            string price = get.price;
            int intPrice = int.Parse(price);


            Debug.WriteLine("Price:" +  intPrice);
            Debug.WriteLine("name:" + get.name);
            Debug.WriteLine("Price:" + get.image);


            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                int newBudget = Class1.UserVault;


                if (newBudget >= intPrice)
                {

                    newBudget = Class1.UserVault - intPrice;
                    Debug.WriteLine(newBudget);

                    cmd.Parameters.AddWithValue("@vault", newBudget);
                    cmd.Parameters.AddWithValue("@username", Class1.UserName);


                    conn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        string newVualt = rdr["vault"].ToString();
                    }


                    conn.Close();


                    using (SqlConnection con = new SqlConnection(connectionString))
                    using (SqlCommand cd = new SqlCommand(query2, con))
                    {
                        cd.Parameters.AddWithValue("@name", get.name);
                        cd.Parameters.AddWithValue("@image", get.image);
                        cd.Parameters.AddWithValue("@price", intPrice);




                        con.Open();
                        cd.ExecuteNonQuery();


                    }


                    using (SqlConnection co = new SqlConnection(connectionString))
                    using (SqlCommand deletcmd = new SqlCommand(query3, co))
                    {
                        deletcmd.Parameters.AddWithValue("@name", get.name);
                        try
                        {
                            co.Open();
                            int rowsAffected = deletcmd.ExecuteNonQuery();
                            Console.WriteLine($"Deleted {rowsAffected} row(s)!");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }
                }

                else
                {
                    MessageBox.Show("to Expensive Or Car Your Selected Is out of sale");
                }



            }



            this.Hide();

            Form3 form3 = new Form3();
            form3.ShowDialog();

            this.Close();
        }
    }
}
