 using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prototype
{
    public partial class Form1 : Form
    {

        private string connectionString = "Data Source=DESKTOP-RC7E9BL\\MSSQLSERVER01;Initial Catalog=loginapp;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";



        public Form1()
        {
            InitializeComponent();
        }

        public string image = "";

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult pictur = openFileDialog1.ShowDialog();
            Debug.WriteLine(pictur);
            if (pictur == DialogResult.OK)
            {
                image = openFileDialog1.FileName;
                pictureBox1.ImageLocation = image;
                Debug.WriteLine(pictureBox1.ImageLocation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            


            string username = textBox1.Text;
            string email = textBox2.Text;
            string password = textBox3.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string createTableQuery = $"CREATE TABLE {username} (image VARCHAR(MAX), name VARCHAR(50), price VARCHAR(50), count VARCHAR(50))";
                using (SqlCommand command = new SqlCommand(createTableQuery, connection))
                {
                    Debug.WriteLine("Open Connction createTabel");
                    int resualt = command.ExecuteNonQuery();
                    if (resualt > 0)
                    {


                        MessageBox.Show("Table 'Customer' created successfully!");

                    }

                }
            }


            string query = "INSERT INTO loginapp (Username, Email, Password, Image, Vault) VALUES (@username, @email, @password, @image, @vault)";


            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {

                int newVautl = 0;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@image", image);
                cmd.Parameters.AddWithValue("@vault", newVautl);



                con.Open();

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show($"Registration successful {username}.");
                    if(image == "")
                    {
                        image = "C:\\Users\\Arian\\Downloads\\default-avatar-profile-icon-of-social-media-user-vector.jpg";
                    }

                    Class1.UserName = username;
                    Class1.UserPass = password;
                    Class1.UserEmail = email;
                    Class1.UserImage = image;


                    this.Hide();

                    Form3 form3 = new Form3();

                    form3.ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Registration failed. Please try again.");
                }

                con.Close();
            }








        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 form2 = new Form2();

            form2 = new Form2();

            form2.ShowDialog();
            this.Close();
        }



        private void OpenEyeImage_Click_1(object sender, EventArgs e)
        {
            if (textBox3.PasswordChar == '\0')
            {
                CloseEyeImage.BringToFront();
                textBox3.PasswordChar = '*';
            }
        }

        private void CloseEyeImage_Click_1(object sender, EventArgs e)
        {
            if (textBox3.PasswordChar == '*')
            {
                OpenEyeImage.BringToFront();
                textBox3.PasswordChar = '\0';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
