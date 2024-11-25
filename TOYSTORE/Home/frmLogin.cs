
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace TOYSTORE
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void EmptyBox()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
        private void picShow_Click(object sender, EventArgs e)
        {
            if (picShow.Visible == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                picShow.Visible = false;
                picHide.Visible = true;
            }
        }
        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void picHide_Click(object sender, EventArgs e)
        {
            if (picHide.Visible == true)
            {
                txtPassword.UseSystemPasswordChar = true;
                picShow.Visible = true;
                picHide.Visible = false;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Define your connection string
            string connectionString = "Data Source=HOANGPHUC;Initial Catalog=Users_Login;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            // Define the query
            string query = "SELECT COUNT(*) FROM dbo.Login_Users WHERE usersname=@usersname AND password=@password";

            // Use the 'using' statement to ensure the connection is closed properly
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Open the connection
                con.Open();

                // Create the command
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Add parameters
                    cmd.Parameters.AddWithValue("@usersname", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                    // Execute the command
                    int count = (int)cmd.ExecuteScalar();

                    // Close the connection (this is handled automatically by the 'using' statement)
                    // con.Close(); // No need to manually close the connection here

                    // Check the result
                    if (count > 0)
                    {
                        MessageBox.Show("Login Success", " INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Main formmain = new Main();
                        this.Hide();
                        formmain.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login failed. Please check your username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
