using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Prototype
{
    public partial class Form7 : Form
    {

        private string connectionString = "Data Source=DESKTOP-RC7E9BL\\MSSQLSERVER01;Initial Catalog=loginapp;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";



        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, userImage.Width - 3, userImage.Height - 3);
            Region rg = new Region(gp);
            userImage.Region = rg;

            nameLebel.Text = userManager.name;
            userImage.ImageLocation = userManager.image;
            emailLabel.Text = userManager.email;
            vaultTextBox.Text = userManager.vault.ToString();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to Change Vault {userManager.name} ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "UPDATE loginapp SET Vault = @vault WHERE Username = @username";


                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    int newVault = int.Parse(vaultTextBox.Text);

                    cmd.Parameters.AddWithValue("@vault", newVault);
                    cmd.Parameters.AddWithValue("@username", nameLebel.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Vault has been changed Successfully", "Successfully Admin");
                }

                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
