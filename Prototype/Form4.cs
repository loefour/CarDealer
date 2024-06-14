using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client.NativeInterop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Prototype
{
    public partial class Form4 : Form
    {


        private string connectionString = "Data Source=DESKTOP-RC7E9BL\\MSSQLSERVER01;Initial Catalog=loginapp;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";



        public Form4()
        {
            InitializeComponent();
        }

        public int price = carGeter.price;

        private void Form4_Load(object sender, EventArgs e)
        {
            Nameform4.Text = carGeter.name;
            Infoform4.Text = carGeter.info;
            carImage.ImageLocation = carGeter.image;
            Priceform4.Text = "$" + Convert.ToString(carGeter.price);




        }


        public int clickCounter = 0;
        public int carAmount = 1;


        private void button1_Click(object sender, EventArgs e)
        {



            string query = "UPDATE loginapp SET Vault = @vault WHERE Username = @username";


            string query2 = $"INSERT INTO loefour (Image, Name) VALUES (@image, @name)";


            string query3 = "DELETE FROM image_list WHERE Name = @name";




            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                int newBudget = Class1.UserVault;


                if (newBudget >= price)
                {
                    newBudget = Class1.UserVault - price;
                }

                else
                {
                    MessageBox.Show("to Expensive");
                }

                Debug.WriteLine(newBudget);

                cmd.Parameters.AddWithValue("@vault", newBudget);
                cmd.Parameters.AddWithValue("@username", Class1.UserName);


                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    string newVualt = rdr["vault"].ToString();

                    labeltotalcost.Text = newVualt;
                }




                userDashBoardClass.image = carGeter.image;
                userDashBoardClass.count = clickCounter;
                userDashBoardClass.name = carGeter.name;

                /*creatring DashBoear Class for user Dhaboard*/

                conn.Close();

            }


            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query2, conn))
            {
                cmd.Parameters.AddWithValue("@name", carGeter.name);
                cmd.Parameters.AddWithValue("@image", carGeter.image);

                conn.Open();
                cmd.ExecuteNonQuery();
            }


            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand deletcmd = new SqlCommand(query3, conn))
            {
                deletcmd.Parameters.AddWithValue("@name", carGeter.name);
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


                this.Close();
        }            
    }
}
