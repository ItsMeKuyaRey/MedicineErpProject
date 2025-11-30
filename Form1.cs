using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;

namespace PharmacyManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            emailTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            signInButton.Enabled = false;

            string username = emailTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                signInButton.Enabled = true;
                return;
            }

            string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=PharmacyManagementSystem;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT password FROM Accounts WHERE username=@username";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string hashedPassword = reader["password"].ToString();

                                bool isValid = BCrypt.Net.BCrypt.Verify(password, hashedPassword);

                                if (isValid)
                                {
                                    MessageBox.Show("WELCOME! " + username);

                                    this.Hide();
                                    DashboardForm mainForm = new DashboardForm(username);
                                    mainForm.FormClosed += (s, args) => this.Close();
                                    mainForm.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid password.");
                                    passwordTextBox.Clear();
                                    passwordTextBox.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Username not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                signInButton.Enabled = true;
            }
        }

    }
}