using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;   // <-- SAME AS YOUR LOGIN FORM

namespace PharmacyManagementSystem
{
    public partial class MedicineInventoryUC : UserControl
    {
        // Use the same connection string as your login
        private readonly string connectionString =
            "Data Source=MSI\\SQLEXPRESS;Initial Catalog=PharmacyManagementSystem;Integrated Security=True;TrustServerCertificate=True";

        public MedicineInventoryUC()
        {
            InitializeComponent();
            LoadMedicinesFromDatabase();

            // Live search
            txtSearch.TextChanged += (s, e) => LoadMedicinesFromDatabase(txtSearch.Text.Trim());
        }

        private void LoadMedicinesFromDatabase(string search = "")
        {
            pnlMedicineList.Controls.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
    SELECT 
        m.medicine_name     AS MedicineName,
        ISNULL(m.generic_name, '') AS GenericName,
        ISNULL(c.category_name, 'Unknown') AS Category,
        m.quantity_in_stock AS Quantity,
        m.price,
        m.expiry_date       AS ExpiryDate,
        m.batch_no          AS BatchNo,
        CASE 
            WHEN m.expiry_date < GETDATE() THEN 'Expired'
            WHEN m.expiry_date <= DATEADD(day, 60, GETDATE()) THEN 'Expiring Soon'
            WHEN m.quantity_in_stock < 20 THEN 'Low Stock'
            ELSE 'In Stock'
        END AS StockStatus
    FROM Medicines m
    LEFT JOIN Categories c ON m.category_id = c.id
    WHERE (@Search = '%' 
        OR m.medicine_name LIKE @Search
        OR m.generic_name LIKE @Search
        OR c.category_name LIKE @Search
        OR m.batch_no LIKE @Search)
    ORDER BY m.medicine_name";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Search", $"%{search}%");
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            bool hasData = false;
                            while (reader.Read())
                            {
                                hasData = true;
                                AddMedicineRow(
                                    reader["MedicineName"].ToString(),
                                    reader["GenericName"]?.ToString() ?? "",
                                    reader["Category"]?.ToString() ?? "",
                                    Convert.ToInt32(reader["Quantity"]),
                                    Convert.ToDouble(reader["Price"]),
                                    Convert.ToDateTime(reader["ExpiryDate"]).ToString("yyyy-MM-dd"),
                                    reader["BatchNo"]?.ToString() ?? "",
                                    reader["StockStatus"].ToString()
                                );
                            }
                            if (!hasData) AddEmptyRow(search);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Connection Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddEmptyRow();
            }
        }

        private void AddEmptyRow(string search = "")
        {
            Label lbl = new Label
            {
                Text = string.IsNullOrEmpty(search)
                    ? "No medicines found in database.\nClick 'Add Medicine' to start."
                    : $"No results for '{search}'",
                Font = new Font("Segoe UI", 16F, FontStyle.Italic),
                ForeColor = Color.Gray,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };
            pnlMedicineList.Controls.Add(lbl);
        }

        private void AddMedicineRow(string name, string generic, string category, int qty, double price, string expiry, string batch, string status)
        {
            var row = new TableLayoutPanel
            {
                RowCount = 1,
                ColumnCount = 9,
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = Color.White,
                Margin = new Padding(0, 0, 0, 2),
                Padding = new Padding(15, 10, 15, 10)
            };

            row.MouseEnter += (s, e) => row.BackColor = Color.FromArgb(245, 250, 255);
            row.MouseLeave += (s, e) => row.BackColor = Color.White;

            // Column widths
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9F));

            // Add cells
            row.Controls.Add(new Label { Text = name, Font = new Font("Segoe UI", 10F), ForeColor = Color.FromArgb(30, 30, 50), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft });
            row.Controls.Add(new Label { Text = generic, Font = new Font("Segoe UI", 9F), ForeColor = Color.Gray, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft });
            row.Controls.Add(new Label { Text = category, Font = new Font("Segoe UI", 9F), ForeColor = Color.Gray, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter });

            var qtyLbl = new Label { Text = qty.ToString(), Font = new Font("Segoe UI", 10F, FontStyle.Bold), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter };
            qtyLbl.ForeColor = qty < 20 ? Color.FromArgb(220, 53, 69) : Color.FromArgb(40, 167, 69);
            row.Controls.Add(qtyLbl);

            row.Controls.Add(new Label { Text = "$" + price.ToString("F2"), Font = new Font("Segoe UI", 10F), ForeColor = Color.FromArgb(0, 150, 136), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter });
            row.Controls.Add(new Label { Text = expiry, Font = new Font("Segoe UI", 9F), ForeColor = Color.Gray, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter });
            row.Controls.Add(new Label { Text = batch, Font = new Font("Segoe UI", 9F), ForeColor = Color.Gray, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter });

            // Status Badge
            var badge = new Guna2Button
            {
                Text = "  " + status,
                FillColor = status.Contains("Low") ? Color.FromArgb(255, 193, 7) :
                           status.Contains("Expiring") ? Color.FromArgb(220, 53, 69) :
                           Color.FromArgb(40, 167, 69),
                ForeColor = Color.White,
                BorderRadius = 8,
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                Height = 30,
                Width = 110
            };
            row.Controls.Add(badge);

            // Action Buttons (Simple)
            var editBtn = new Guna2Button { Width = 38, Height = 38, BorderRadius = 19, FillColor = Color.FromArgb(0, 150, 136) };
            var deleteBtn = new Guna2Button { Width = 38, Height = 38, BorderRadius = 19, FillColor = Color.FromArgb(220, 53, 69) };

            var actions = new FlowLayoutPanel { Width = 90 };
            actions.Controls.Add(editBtn);
            actions.Controls.Add(deleteBtn);
            row.Controls.Add(actions);

            pnlMedicineList.Controls.Add(row);
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Medicine Form - Coming Soon!", "Pharmacy Pro");
        }
    }
}