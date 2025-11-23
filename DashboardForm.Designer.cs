namespace PharmacyManagementSystem
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.SidebarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnReports = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.btnSales = new Guna.UI2.WinForms.Guna2Button();
            this.btnInventory = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.lblAppName = new System.Windows.Forms.Label();
            this.HeaderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SidebarPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidebarPanel
            // 
            this.SidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.SidebarPanel.Controls.Add(this.btnLogout);
            this.SidebarPanel.Controls.Add(this.btnReports);
            this.SidebarPanel.Controls.Add(this.btnCustomers);
            this.SidebarPanel.Controls.Add(this.btnSales);
            this.SidebarPanel.Controls.Add(this.btnInventory);
            this.SidebarPanel.Controls.Add(this.btnHome);
            this.SidebarPanel.Controls.Add(this.lblAppName);
            this.SidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.SidebarPanel.Name = "SidebarPanel";
            this.SidebarPanel.ShadowDecoration.Parent = this.SidebarPanel;
            this.SidebarPanel.Size = new System.Drawing.Size(220, 780);
            this.SidebarPanel.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogout.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogout.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnLogout.Location = new System.Drawing.Point(0, 720);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(220, 50);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextOffset = new System.Drawing.Point(5, 0);
           // this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReports
            // 
            this.btnReports.Animated = true;
            this.btnReports.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReports.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnReports.CheckedState.Parent = this.btnReports;
            this.btnReports.CustomImages.Parent = this.btnReports;
            this.btnReports.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.btnReports.HoverState.Parent = this.btnReports;
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReports.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnReports.Location = new System.Drawing.Point(0, 390);
            this.btnReports.Name = "btnReports";
            this.btnReports.ShadowDecoration.Parent = this.btnReports;
            this.btnReports.Size = new System.Drawing.Size(220, 50);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReports.TextOffset = new System.Drawing.Point(20, 0);
           // this.btnReports.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Animated = true;
            this.btnCustomers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCustomers.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.CheckedState.Parent = this.btnCustomers;
            this.btnCustomers.CustomImages.Parent = this.btnCustomers;
            this.btnCustomers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.btnCustomers.HoverState.Parent = this.btnCustomers;
            this.btnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomers.Image")));
            this.btnCustomers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomers.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnCustomers.Location = new System.Drawing.Point(0, 330);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.ShadowDecoration.Parent = this.btnCustomers;
            this.btnCustomers.Size = new System.Drawing.Size(220, 50);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomers.TextOffset = new System.Drawing.Point(20, 0);
          //  this.btnCustomers.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // btnSales
            // 
            this.btnSales.Animated = true;
            this.btnSales.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSales.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnSales.CheckedState.Parent = this.btnSales;
            this.btnSales.CustomImages.Parent = this.btnSales;
            this.btnSales.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.btnSales.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.btnSales.HoverState.Parent = this.btnSales;
            this.btnSales.Image = ((System.Drawing.Image)(resources.GetObject("btnSales.Image")));
            this.btnSales.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSales.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnSales.Location = new System.Drawing.Point(0, 270);
            this.btnSales.Name = "btnSales";
            this.btnSales.ShadowDecoration.Parent = this.btnSales;
            this.btnSales.Size = new System.Drawing.Size(220, 50);
            this.btnSales.TabIndex = 3;
            this.btnSales.Text = "Sales & Billing";
            this.btnSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSales.TextOffset = new System.Drawing.Point(20, 0);
         //   this.btnSales.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Animated = true;
            this.btnInventory.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInventory.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnInventory.CheckedState.Parent = this.btnInventory;
            this.btnInventory.CustomImages.Parent = this.btnInventory;
            this.btnInventory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.btnInventory.HoverState.Parent = this.btnInventory;
            this.btnInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnInventory.Image")));
            this.btnInventory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInventory.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnInventory.Location = new System.Drawing.Point(0, 210);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.ShadowDecoration.Parent = this.btnInventory;
            this.btnInventory.Size = new System.Drawing.Size(220, 50);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInventory.TextOffset = new System.Drawing.Point(20, 0);
           // this.btnInventory.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // btnHome
            // 
            this.btnHome.Animated = true;
            this.btnHome.Checked = true;
            this.btnHome.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHome.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnHome.Location = new System.Drawing.Point(0, 150);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(220, 50);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.TextOffset = new System.Drawing.Point(20, 0);
           // this.btnHome.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(10, 30);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(189, 60);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "Pharmacy\r\nManagement";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.HeaderPanel.Controls.Add(this.lblCurrentUser);
            this.HeaderPanel.Controls.Add(this.lblDate);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(220, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.ShadowDecoration.Parent = this.HeaderPanel;
            this.HeaderPanel.Size = new System.Drawing.Size(1080, 70);
            this.HeaderPanel.TabIndex = 1;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.lblCurrentUser.Location = new System.Drawing.Point(800, 20);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(270, 30);
            this.lblCurrentUser.TabIndex = 1;
            this.lblCurrentUser.Text = "Welcome, Admin!";
            this.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Gray;
            this.lblDate.Location = new System.Drawing.Point(20, 25);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 23);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Today\'s Date";
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(220, 70);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1080, 710);
            this.ContentPanel.TabIndex = 2;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 780);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.SidebarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            //this.StartPosition = System.Windows.Forms.StartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.SidebarPanel.ResumeLayout(false);
            this.SidebarPanel.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel SidebarPanel;
        private Guna.UI2.WinForms.Guna2Panel HeaderPanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Label lblAppName;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnInventory;
        private Guna.UI2.WinForms.Guna2Button btnReports;
        private Guna.UI2.WinForms.Guna2Button btnCustomers;
        private Guna.UI2.WinForms.Guna2Button btnSales;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private System.Windows.Forms.Label lblDate;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblCurrentUser;
    }
}