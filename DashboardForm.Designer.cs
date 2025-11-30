// DashboardForm.Designer.cs - FINAL & 100% WORKING
using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PharmacyManagementSystem
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            SidebarPanel = new Guna2Panel();
            panelIndicator = new Guna2Panel();
            lblAppName = new Label();
            btnHome = new Guna2Button();
            btnInventory = new Guna2Button();
            btnSales = new Guna2Button();
            btnCustomers = new Guna2Button();
            btnReports = new Guna2Button();
            btnLogout = new Guna2Button();
            HeaderPanel = new Guna2Panel();
            lblPageTitle = new Label();
            lblDate = new Label();
            picUserAvatar = new Guna2CirclePictureBox();
            lblCurrentUser = new Label();
            ContentPanel = new Panel();
            guna2Elipse1 = new Guna2Elipse(components);
            SidebarPanel.SuspendLayout();
            HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUserAvatar).BeginInit();
            SuspendLayout();
            // 
            // SidebarPanel
            // 
            SidebarPanel.BackColor = Color.FromArgb(15, 25, 45);
            SidebarPanel.Controls.Add(panelIndicator);
            SidebarPanel.Controls.Add(lblAppName);
            SidebarPanel.Controls.Add(btnHome);
            SidebarPanel.Controls.Add(btnInventory);
            SidebarPanel.Controls.Add(btnSales);
            SidebarPanel.Controls.Add(btnCustomers);
            SidebarPanel.Controls.Add(btnReports);
            SidebarPanel.Controls.Add(btnLogout);
            SidebarPanel.CustomizableEdges = customizableEdges15;
            SidebarPanel.Dock = DockStyle.Left;
            SidebarPanel.Location = new Point(0, 0);
            SidebarPanel.Name = "SidebarPanel";
            SidebarPanel.ShadowDecoration.CustomizableEdges = customizableEdges16;
            SidebarPanel.Size = new Size(280, 780);
            SidebarPanel.TabIndex = 2;
            // 
            // panelIndicator
            // 
            panelIndicator.BackColor = Color.Cyan;
            panelIndicator.CustomizableEdges = customizableEdges1;
            panelIndicator.Location = new Point(0, 210);
            panelIndicator.Name = "panelIndicator";
            panelIndicator.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelIndicator.Size = new Size(6, 60);
            panelIndicator.TabIndex = 0;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(25, 50);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(203, 50);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "PharmERP";
            // 
            // btnHome
            // 
            btnHome.CustomizableEdges = customizableEdges3;
            btnHome.Font = new Font("Segoe UI", 9F);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnHome.Size = new Size(180, 45);
            btnHome.TabIndex = 2;
            // 
            // btnInventory
            // 
            btnInventory.CustomizableEdges = customizableEdges5;
            btnInventory.Font = new Font("Segoe UI", 9F);
            btnInventory.ForeColor = Color.White;
            btnInventory.Location = new Point(0, 0);
            btnInventory.Name = "btnInventory";
            btnInventory.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnInventory.Size = new Size(180, 45);
            btnInventory.TabIndex = 3;
            // 
            // btnSales
            // 
            btnSales.CustomizableEdges = customizableEdges7;
            btnSales.Font = new Font("Segoe UI", 9F);
            btnSales.ForeColor = Color.White;
            btnSales.Location = new Point(0, 0);
            btnSales.Name = "btnSales";
            btnSales.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSales.Size = new Size(180, 45);
            btnSales.TabIndex = 4;
            // 
            // btnCustomers
            // 
            btnCustomers.CustomizableEdges = customizableEdges9;
            btnCustomers.Font = new Font("Segoe UI", 9F);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Location = new Point(0, 0);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnCustomers.Size = new Size(180, 45);
            btnCustomers.TabIndex = 5;
            // 
            // btnReports
            // 
            btnReports.CustomizableEdges = customizableEdges11;
            btnReports.Font = new Font("Segoe UI", 9F);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(0, 0);
            btnReports.Name = "btnReports";
            btnReports.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnReports.Size = new Size(180, 45);
            btnReports.TabIndex = 6;
            // 
            // btnLogout
            // 
            btnLogout.CustomizableEdges = customizableEdges13;
            btnLogout.Font = new Font("Segoe UI", 9F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnLogout.Size = new Size(180, 45);
            btnLogout.TabIndex = 7;
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = Color.White;
            HeaderPanel.Controls.Add(lblPageTitle);
            HeaderPanel.Controls.Add(lblDate);
            HeaderPanel.Controls.Add(picUserAvatar);
            HeaderPanel.Controls.Add(lblCurrentUser);
            HeaderPanel.CustomizableEdges = customizableEdges18;
            HeaderPanel.Dock = DockStyle.Top;
            HeaderPanel.Location = new Point(280, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.ShadowDecoration.CustomizableEdges = customizableEdges19;
            HeaderPanel.Size = new Size(1020, 100);
            HeaderPanel.TabIndex = 1;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(15, 25, 45);
            lblPageTitle.Location = new Point(30, 30);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(229, 54);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Dashboard";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 10F);
            lblDate.ForeColor = Color.Gray;
            lblDate.Location = new Point(30, 70);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(0, 23);
            lblDate.TabIndex = 1;
            // 
            // picUserAvatar
            // 
            picUserAvatar.ErrorImage = null;
            picUserAvatar.FillColor = Color.LightGray;
            picUserAvatar.Image = Properties.Resources.user_avatar;
            picUserAvatar.ImageRotate = 0F;
            picUserAvatar.InitialImage = null;
            picUserAvatar.Location = new Point(943, 19);
            picUserAvatar.Name = "picUserAvatar";
            picUserAvatar.ShadowDecoration.CustomizableEdges = customizableEdges17;
            picUserAvatar.Size = new Size(65, 65);
            picUserAvatar.TabIndex = 2;
            picUserAvatar.TabStop = false;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblCurrentUser.ForeColor = Color.FromArgb(15, 25, 45);
            lblCurrentUser.Location = new Point(1030, 38);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(0, 30);
            lblCurrentUser.TabIndex = 3;
            // 
            // ContentPanel
            // 
            ContentPanel.BackColor = Color.FromArgb(248, 250, 254);
            ContentPanel.Dock = DockStyle.Fill;
            ContentPanel.Location = new Point(280, 100);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(1020, 680);
            ContentPanel.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 22;
            guna2Elipse1.TargetControl = this;
            // 
            // DashboardForm
            // 
            ClientSize = new Size(1300, 780);
            Controls.Add(ContentPanel);
            Controls.Add(HeaderPanel);
            Controls.Add(SidebarPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PharmERP - Pharmacy Management";
            SidebarPanel.ResumeLayout(false);
            SidebarPanel.PerformLayout();
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUserAvatar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna2Panel SidebarPanel;
        private Guna2Panel HeaderPanel;
        private Panel ContentPanel;
        private Label lblAppName;
        private Guna2Button btnHome;
        private Guna2Button btnInventory;
        private Guna2Button btnSales;
        private Guna2Button btnCustomers;
        private Guna2Button btnReports;
        private Guna2Button btnLogout;
        private Label lblPageTitle;
        private Label lblDate;
        private Guna2CirclePictureBox picUserAvatar;
        private Label lblCurrentUser;
        private Guna2Panel panelIndicator;
        private Guna2Elipse guna2Elipse1;
    }
}