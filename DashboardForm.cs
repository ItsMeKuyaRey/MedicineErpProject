using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PharmacyManagementSystem
{
    public partial class DashboardForm : Form
    {
        private Guna2Button currentActiveButton;
        private readonly string CurrentUsername;

        public DashboardForm(string username)
        {
            InitializeComponent();
            this.CurrentUsername = username;
            InitializeDashboard();
        }

        private void InitializeDashboard()
        {
            lblDate.Text = DateTime.Now.ToLongDateString();

            lblCurrentUser.Text = $"Welcome, {CurrentUsername}!";

            currentActiveButton = btnHome;
            SetActiveButtonStyle(btnHome);

            LoadHomeView();
        }

        private void NavButton_Click(object sender, EventArgs e)
        {
            Guna2Button clickedButton = sender as Guna2Button;

            if (clickedButton != null && clickedButton != currentActiveButton)
            {
                ResetActiveButtonStyle(currentActiveButton);

                SetActiveButtonStyle(clickedButton);

                currentActiveButton = clickedButton;

                LoadContentView(clickedButton.Name);
            }
        }

        private void SetActiveButtonStyle(Guna2Button button)
        {
            button.FillColor = Color.FromArgb(0, 192, 192);
            button.Font = new Font(button.Font, FontStyle.Bold);
            button.Checked = true;
        }

        private void ResetActiveButtonStyle(Guna2Button button)
        {
            button.FillColor = Color.FromArgb(4, 103, 130);
            button.Font = new Font(button.Font, FontStyle.Regular);
            button.Checked = false;
        }

        private void LoadContentView(string buttonName)
        {
            ContentPanel.Controls.Clear();

            Label lblPlaceholder = new Label
            {
                Text = $"{buttonName.Replace("btn", "")} View is Under Construction",
                Font = new Font("Segoe UI", 24F, FontStyle.Bold),
                ForeColor = Color.DarkGray,
                AutoSize = true,
                Anchor = AnchorStyles.None
            };

            ContentPanel.Controls.Add(lblPlaceholder);
            lblPlaceholder.Location = new Point(
                (ContentPanel.Width - lblPlaceholder.Width) / 2,
                (ContentPanel.Height - lblPlaceholder.Height) / 2
            );
        }

        private void LoadHomeView()
        {
            Label lblWelcome = new Label
            {
                Text = $"Welcome to the Pharmacy Management System, {CurrentUsername}!",
                Font = new Font("Segoe UI", 28F, FontStyle.Bold),
                ForeColor = Color.FromArgb(4, 103, 130),
                AutoSize = true,
                Anchor = AnchorStyles.None
            };

            ContentPanel.Controls.Add(lblWelcome);
            lblWelcome.Location = new Point(
                (ContentPanel.Width - lblWelcome.Width) / 2,
                (ContentPanel.Height - lblWelcome.Height) / 2
            );
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Close();
            }
        }
    }
}