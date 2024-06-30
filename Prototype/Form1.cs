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







            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (textBox2.Text.Contains("@gmail.com"))
                {
                    if (textBox3.Text.Length >= 6)
                    {
                        if (textBox3.Text.Length <= 15)
                        {
                            int isUpper = textBox3.Text.Count(char.IsUpper);

                            if (isUpper >= 2)
                            {

                                string username = textBox1.Text;
                                string email = textBox2.Text;
                                string password = textBox3.Text;

                                using (SqlConnection connection = new SqlConnection(connectionString))
                                {
                                    connection.Open();
                                    string createTableQuery = $"CREATE TABLE {username} (image VARCHAR(MAX), name VARCHAR(50), price VARCHAR(50), info VARCHAR(MAX))";
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
                                        if (image == "")
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
                            else
                            {
                                label7.Visible = true;

                                label7.Text = "Your Password should contain 2 Upper Character";

                            }
                        }
                        else
                        {
                            label7.Visible = true;

                            label7.Text = "Your Password is to long";

                        }
                    }
                    else
                    {
                        label7.Visible = true;


                        label7.Text = "Your Password is to weak";
                    }
                }
                else
                {
                    label7.Visible = true;


                    label7.Text = "Your Gmail Info is not valid";

                }
            }
            else
            {
                label7.Visible = true;


                label7.Text = "Please fill the form";
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
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to Close The App?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
