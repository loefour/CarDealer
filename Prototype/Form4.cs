﻿using Microsoft.Data.SqlClient;
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


        private int FirstCarcount = 0;


        public Form4()
        {
            InitializeComponent();
        }

        public int price = carGeter.price;

        private void Form4_Load(object sender, EventArgs e)
        {

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, carImage.Width - 3, carImage.Height - 3);
            Region rg = new Region(gp);
            carImage.Region = rg;



            Nameform4.Text = carGeter.name;
            Infoform4.Text = carGeter.info;
            carImage.ImageLocation = carGeter.image;
            Priceform4.Text = "$" + Convert.ToString(carGeter.price);


        }


        public int clickCounter = 0;
        public int carAmount = 1;


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to Purchuse {carGeter.name}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "UPDATE loginapp SET Vault = @vault WHERE Username = @username";


                string query2 = $"INSERT INTO {Class1.UserName} (Image, Name, Price, Info) VALUES (@image, @name, @price, @info)";


                string query3 = "DELETE FROM image_list WHERE Name = @name";




                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    int newBudget = Class1.UserVault;


                    if (newBudget >= price)
                    {

                        newBudget = Class1.UserVault - price;
                        Debug.WriteLine(newBudget);

                        cmd.Parameters.AddWithValue("@vault", newBudget);
                        cmd.Parameters.AddWithValue("@username", Class1.UserName);


                        conn.Open();
                        SqlDataReader rdr = cmd.ExecuteReader();
                        if (rdr.Read())
                        {
                            string newVualt = rdr["vault"].ToString();
                        }




                        userDashBoardClass.image = carGeter.image;
                        userDashBoardClass.name = carGeter.name;



                        conn.Close();


                        using (SqlConnection con = new SqlConnection(connectionString))
                        using (SqlCommand cd = new SqlCommand(query2, con))
                        {
                            cd.Parameters.AddWithValue("@name", carGeter.name);
                            cd.Parameters.AddWithValue("@image", carGeter.image);
                            cd.Parameters.AddWithValue("@price", carGeter.price);
                            cd.Parameters.AddWithValue("@info", carGeter.info);




                            con.Open();
                            cd.ExecuteNonQuery();


                        }


                        using (SqlConnection co = new SqlConnection(connectionString))
                        using (SqlCommand deletcmd = new SqlCommand(query3, co))
                        {
                            deletcmd.Parameters.AddWithValue("@name", carGeter.name);
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





                this.Close();
            }


               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
