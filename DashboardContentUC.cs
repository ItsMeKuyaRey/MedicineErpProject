using System;
using System.Drawing;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class DashboardContentUC : UserControl
    {
        public DashboardContentUC()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.FromArgb(248, 250, 254);
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            // Title
            var lblTitle = new Label
            {
                Text = "Welcome back! Here's what's happening with your pharmacy.",
                Font = new Font("Segoe UI", 14F, FontStyle.Regular),
                ForeColor = Color.FromArgb(80, 80, 80),
                Location = new Point(30, 20),
                AutoSize = true
            };

            // Stats Cards
            AddStatCard("Total Medicines", "1,284", "+12.5% from last month", Color.FromArgb(0, 150, 255), 30, 80);
            AddStatCard("Low Stock Items", "23", "+3 need reorder", Color.FromArgb(255, 100, 100), 380, 80);
            AddStatCard("Expiring Soon", "7", "Within 30 days", Color.FromArgb(255, 150, 0), 730, 80);
            AddStatCard("Daily Sales", "$4,235", "-2.4% from yesterday", Color.FromArgb(0, 200, 100), 1080, 80);

            // Charts (you can replace with LiveCharts, Guna Charts, etc.)
            AddChart("Sales Analytics", "Monthly sales and purchase trends", 30, 220, 650, 300);
            AddChart("Inventory Level by Category", "Current stock distribution", 720, 220, 550, 300);

            // Alerts & Recent Orders
            AddAlertsPanel(30, 540);
            AddRecentOrdersPanel(720, 540);

            this.Controls.Add(lblTitle);
        }

        private void AddStatCard(string title, string value, string subtitle, Color color, int x, int y)
        {
            var panel = new Panel
            {
                Size = new Size(320, 120),
                Location = new Point(x, y),
                BackColor = Color.White,
                BorderStyle = BorderStyle.None
            };
            panel.Paint += (s, e) =>
            {
                var rect = new Rectangle(0, 0, 8, panel.Height);
                e.Graphics.FillRectangle(new SolidBrush(color), rect);
            };

            var lblValue = new Label { Text = value, Font = new Font("Segoe UI", 28F, FontStyle.Bold), Location = new Point(20, 25), ForeColor = Color.FromArgb(15, 25, 45) };
            var lblTitle = new Label { Text = title, Font = new Font("Segoe UI", 10F), Location = new Point(20, 75), ForeColor = Color.Gray };
            var lblSub = new Label { Text = subtitle, Font = new Font("Segoe UI", 9F), Location = new Point(20, 95), ForeColor = Color.FromArgb(0, 180, 0), AutoSize = true };

            panel.Controls.AddRange(new Control[] { lblValue, lblTitle, lblSub });
            this.Controls.Add(panel);
        }

        private void AddChart(string title, string subtitle, int x, int y, int w, int h)
        {
            var panel = new Panel { Size = new Size(w, h), Location = new Point(x, y), BackColor = Color.White };
            var lbl = new Label { Text = title, Font = new Font("Segoe UI", 14F, FontStyle.Bold), Location = new Point(20, 15) };
            var lblSub = new Label { Text = subtitle, Font = new Font("Segoe UI", 10F), ForeColor = Color.Gray, Location = new Point(20, 50) };
            panel.Controls.AddRange(new Control[] { lbl, lblSub });
            this.Controls.Add(panel);
        }

        private void AddAlertsPanel(int x, int y)
        {
            var panel = new Panel { Size = new Size(650, 280), Location = new Point(x, y), BackColor = Color.White };
            var title = new Label { Text = "Alerts & Notifications", Font = new Font("Segoe UI", 14F, FontStyle.Bold), Location = new Point(20, 15) };

            string[] alerts = {
                "Amoxicillin 500mg - Stock: 15 (Min: 50)",
                "Paracetamol 650mg - Expires 2025-12-15 (27 days left)",
                "Ibuprofen 400mg - Stock: 8 (Min: 30)",
                "Vitamin D3 - Expires 2025-12-20 (32 days left)"
            };

            int py = 60;
            foreach (var alert in alerts)
            {
                var lbl = new Label { Text = alert, Location = new Point(20, py), AutoSize = true, ForeColor = Color.Red };
                panel.Controls.Add(lbl);
                py += 35;
            }

            panel.Controls.Add(title);
            this.Controls.Add(panel);
        }

        private void AddRecentOrdersPanel(int x, int y)
        {
            var panel = new Panel { Size = new Size(550, 280), Location = new Point(x, y), BackColor = Color.White };
            var title = new Label { Text = "Recent Purchase Orders", Font = new Font("Segoe UI", 14F, FontStyle.Bold), Location = new Point(20, 15) };

            string[] orders = { "PO-1324 MedSupply Co. $1,250 Pending", "PO-1323 PharmaWholesale $800 Completed", "PO-1322 MediCare Ltd. $1,200 Completed" };
            int py = 60;
            foreach (var order in orders)
            {
                var lbl = new Label { Text = order, Location = new Point(20, py), AutoSize = true };
                panel.Controls.Add(lbl);
                py += 40;
            }

            panel.Controls.Add(title);
            this.Controls.Add(panel);
        }
    }
}