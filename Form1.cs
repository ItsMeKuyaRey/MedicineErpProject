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

            string email = emailTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Required Fields Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                signInButton.Enabled = true;
                return;
            }

            string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=PharmacyManagementSystem;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string query = "SELECT Username FROM Accounts WHERE Username = @username AND Password = @password";

                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", email);
                cmd.Parameters.AddWithValue("@password", password);

                using SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string loggedInUsername = reader["Username"].ToString()!;

                    MessageBox.Show($"WELCOME! {loggedInUsername}", "Login Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();

                    DashboardForm mainForm = new DashboardForm(loggedInUsername);
                    mainForm.FormClosed += (s, args) => this.Close();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed: Invalid username or password.", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passwordTextBox.Clear();
                    passwordTextBox.Focus();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Connection Failure",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Application Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                signInButton.Enabled = true;
            }
        }
    }
}