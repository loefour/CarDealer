using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    public class DataSearch
    {

        string connectionString = "Data Source=DESKTOP-RC7E9BL\\MSSQLSERVER01;Initial Catalog=loginapp;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public string name { get; set; }
        public string info { get; set; }
        public string price { get; set; }
        public string image { get; set; }


        public static List<DataSearch> list = new List<DataSearch>();

        public void search(string key)
        {

            string query = "SELECT * FROM image_list WHERE Name LIKE @name";
           


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name","%" + key + "%");


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        list.Clear();


                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                DataSearch data = new DataSearch()
                                {
                                    name = reader["name"].ToString(),
                                    info = reader["info"].ToString(),
                                    price = reader["price"].ToString(),
                                    image = reader["image"].ToString()

                                };
                                

                                list.Add(data);
                            }
                        }
                        reader.Dispose();
                        cmd.Dispose();
                        connection.Close();



                    }
                }
            }



        }

        public void SelectedData(string name)
        {
            string query = "SELECT * FROM image_list WHERE Name = @name";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {

                    cmd.Parameters.AddWithValue("@name", name);


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            this.name = reader["name"].ToString();
                            this.info = reader["info"].ToString();
                            this.price = reader["price"].ToString();
                            this.image = reader["image"].ToString();
                        }
                        reader.Dispose();
                        cmd.Dispose();
                        connection.Close();



                    }
                }
            }
        }
    }  
}
