using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PharmacyManagementSystem
{
    public partial class DashboardForm : Form
    {
        private Guna2Button? currentActiveButton;
        private readonly string CurrentUsername;

        public DashboardForm(string username)
        {
            InitializeComponent();
            this.CurrentUsername = username;
            SetupNavigationButtons();
            InitializeDashboard();
        }

        private void InitializeDashboard()
        {
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            lblCurrentUser.Text = $"Welcome, {CurrentUsername}!";

            // Set Home as default active
            currentActiveButton = btnHome;
            SetActiveButtonStyle(btnHome);
            panelIndicator.Top = btnHome.Top;
            panelIndicator.Height = btnHome.Height;

            // User avatar fallback (initial letter)
            if (picUserAvatar.Image == null)
            {
                picUserAvatar.Image = null;
                picUserAvatar.Text = CurrentUsername.Length > 0
                    ? CurrentUsername[0].ToString().ToUpper()
                    : "U";
                picUserAvatar.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
                picUserAvatar.BackColor = Color.FromArgb(0, 180, 220);
                picUserAvatar.ForeColor = Color.White;
            }

            LoadHomeView();
        }

        private void NavButton_Click(object sender, EventArgs e)
        {
            if (sender is not Guna2Button clickedButton || clickedButton == currentActiveButton)
                return;

            // Reset previous button
            if (currentActiveButton != null)
                ResetActiveButtonStyle(currentActiveButton);

            // Activate new button
            currentActiveButton = clickedButton;
            SetActiveButtonStyle(clickedButton);
            panelIndicator.Top = clickedButton.Top;
            panelIndicator.Height = clickedButton.Height;

            // Update page title
            lblPageTitle.Text = clickedButton.Text.TrimStart();

            // Load corresponding view
            LoadContentView(clickedButton.Name);
        }

        private void SetActiveButtonStyle(Guna2Button button)
        {
            button.Checked = true;
            button.FillColor = Color.FromArgb(0, 180, 200);
            button.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        }

        private void ResetActiveButtonStyle(Guna2Button button)
        {
            if (button == null) return;
            button.Checked = false;
            button.FillColor = Color.Transparent;
            button.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
        }

        private void LoadContentView(string buttonName)
        {
            ContentPanel.Controls.Clear();

            switch (buttonName)
            {
                case "btnHome":
                    LoadHomeView();
                    break;

                case "btnInventory":
                    var inventoryUC = new MedicineInventoryUC();  // CORRECT NAME (Uc)
                    inventoryUC.Dock = DockStyle.Fill;
                    ContentPanel.Controls.Add(inventoryUC);
                    lblPageTitle.Text = "Medicine Inventory";
                    break;

                case "btnSales":
                    LoadPlaceholder("Sales & Billing", "Manage sales, invoices, and payments");
                    break;

                case "btnCustomers":
                    LoadPlaceholder("Customers", "View and manage customer information");
                    break;

                case "btnReports":
                    LoadPlaceholder("Reports & Analytics", "View sales, stock, and expiry reports");
                    break;

                default:
                    LoadPlaceholder("Under Development", "This feature is coming soon...");
                    break;
            }
        }

        private void LoadHomeView()
        {
            var welcomePanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent
            };

            var lblWelcome = new Label
            {
                Text = $"Welcome back,\n{CurrentUsername}!",
                Font = new Font("Segoe UI", 38F, FontStyle.Bold),
                ForeColor = Color.FromArgb(15, 25, 45),
                AutoSize = true,
                MaximumSize = new Size(800, 0),
                TextAlign = ContentAlignment.MiddleCenter
            };

            var lblSub = new Label
            {
                Text = "Manage your pharmacy efficiently with PharmERP",
                Font = new Font("Segoe UI", 16F, FontStyle.Regular),
                ForeColor = Color.Gray,
                AutoSize = true,
                Top = 120
            };

            lblWelcome.Left = (welcomePanel.Width - lblWelcome.Width) / 2;
            lblWelcome.Top = 180;
            lblSub.Left = (welcomePanel.Width - lblSub.Width) / 2;

            welcomePanel.Controls.Add(lblWelcome);
            welcomePanel.Controls.Add(lblSub);
            welcomePanel.Resize += (s, e) =>
            {
                lblWelcome.Left = (welcomePanel.Width - lblWelcome.Width) / 2;
                lblSub.Left = (welcomePanel.Width - lblSub.Width) / 2;
            };

            ContentPanel.Controls.Add(welcomePanel);
        }

        private void LoadPlaceholder(string title, string subtitle = "")
        {
            ContentPanel.Controls.Clear();

            var panel = new Panel { Dock = DockStyle.Fill };

            var lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 32F, FontStyle.Bold),
                ForeColor = Color.FromArgb(15, 25, 45),
                AutoSize = true
            };

            var lblSubtitle = new Label
            {
                Text = subtitle.Length > 0 ? subtitle : "This feature is under development",
                Font = new Font("Segoe UI", 16F),
                ForeColor = Color.Gray,
                AutoSize = true,
                Top = 80
            };

            var lblComing = new Label
            {
                Text = "Coming Soon...",
                Font = new Font("Segoe UI", 18F, FontStyle.Italic),
                ForeColor = Color.FromArgb(0, 180, 220),
                AutoSize = true,
                Top = 140
            };

            void CenterControls(object s, EventArgs e)
            {
                int centerX = panel.Width / 2;
                lblTitle.Left = centerX - (lblTitle.Width / 2);
                lblSubtitle.Left = centerX - (lblSubtitle.Width / 2);
                lblComing.Left = centerX - (lblComing.Width / 2);
            }

            lblTitle.Top = 200;
            panel.Controls.AddRange(new Control[] { lblTitle, lblSubtitle, lblComing });
            panel.Resize += CenterControls;
            CenterControls(null, null);

            ContentPanel.Controls.Add(panel);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                new Form1().Show();
                this.Close();
            }
        }

        // PERFECT SIDEBAR BUTTON SETUP
        private void SetupNavigationButtons()
        {
            Guna2Button[] buttons = { btnHome, btnInventory, btnSales, btnCustomers, btnReports, btnLogout };
            string[] texts = { "  Dashboard", "  Medicine Inventory", "  Sales & Billing", "  Customers", "  Reports & Analytics", "  Logout" };
            string[] icons = { "dashboard", "medicine", "sales", "customers", "reports", "logout" };

            int startY = 180;

            for (int i = 0; i < buttons.Length; i++)
            {
                var btn = buttons[i];
                btn.Text = texts[i];
                btn.Location = new Point(0, startY + (i * 65));
                btn.Size = new Size(280, 60);
                btn.FillColor = Color.Transparent;
                btn.HoverState.FillColor = Color.FromArgb(25, 40, 65);
                btn.CheckedState.FillColor = Color.FromArgb(0, 180, 200);
                btn.BorderRadius = 0;
                btn.Font = new Font("Segoe UI", 11F);
                btn.ForeColor = Color.White;
                btn.ImageAlign = HorizontalAlignment.Left;
                btn.ImageOffset = new Point(40, 0);
                btn.TextAlign = HorizontalAlignment.Left;
                btn.TextOffset = new Point(85, 0);
                btn.Animated = true;

                try
                {
                    var img = Properties.Resources.ResourceManager.GetObject(icons[i]) as Image;
                    if (img != null) btn.Image = img;
                }
                catch { }

                // Assign click events
                if (btn != btnLogout)
                    btn.Click += NavButton_Click;
                else
                    btn.Click += btnLogout_Click;
            }

            // Pre-activate Home
            btnHome.Checked = true;
        }
    }
}