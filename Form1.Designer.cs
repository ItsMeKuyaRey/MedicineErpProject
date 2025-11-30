namespace PharmacyManagementSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            loginPanel = new Guna.UI2.WinForms.Guna2Panel();
            signInButton = new Guna.UI2.WinForms.Guna2Button();
            forgotPasswordLink = new LinkLabel();
            rememberMeCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            passwordLabel = new Label();
            emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            emailLabel = new Label();
            subtitleLabel = new Label();
            titleLabel = new Label();
            iconPlaceholderPanel = new Guna.UI2.WinForms.Guna2Panel();
            loginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // loginPanel
            // 
            loginPanel.Anchor = AnchorStyles.None;
            loginPanel.BackColor = Color.Transparent;
            loginPanel.BorderRadius = 15;
            loginPanel.Controls.Add(signInButton);
            loginPanel.Controls.Add(forgotPasswordLink);
            loginPanel.Controls.Add(rememberMeCheckBox);
            loginPanel.Controls.Add(passwordTextBox);
            loginPanel.Controls.Add(passwordLabel);
            loginPanel.Controls.Add(emailTextBox);
            loginPanel.Controls.Add(emailLabel);
            loginPanel.Controls.Add(subtitleLabel);
            loginPanel.Controls.Add(titleLabel);
            loginPanel.Controls.Add(iconPlaceholderPanel);
            loginPanel.CustomizableEdges = customizableEdges9;
            loginPanel.FillColor = Color.White;
            loginPanel.Location = new Point(0, 4);
            loginPanel.Name = "loginPanel";
            loginPanel.Padding = new Padding(20);
            loginPanel.ShadowDecoration.BorderRadius = 15;
            loginPanel.ShadowDecoration.CustomizableEdges = customizableEdges10;
            loginPanel.ShadowDecoration.Depth = 10;
            loginPanel.ShadowDecoration.Enabled = true;
            loginPanel.Size = new Size(411, 487);
            loginPanel.TabIndex = 0;
            // 
            // signInButton
            // 
            signInButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            signInButton.BorderRadius = 8;
            signInButton.CustomizableEdges = customizableEdges1;
            signInButton.DisabledState.BorderColor = Color.DarkGray;
            signInButton.DisabledState.CustomBorderColor = Color.DarkGray;
            signInButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            signInButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            signInButton.FillColor = Color.FromArgb(41, 128, 185);
            signInButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signInButton.ForeColor = Color.White;
            signInButton.Location = new Point(20, 339);
            signInButton.Name = "signInButton";
            signInButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            signInButton.Size = new Size(371, 40);
            signInButton.TabIndex = 7;
            signInButton.Text = "Sign In";
            signInButton.Click += signInButton_Click;
            // 
            // forgotPasswordLink
            // 
            forgotPasswordLink.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            forgotPasswordLink.AutoSize = true;
            forgotPasswordLink.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forgotPasswordLink.LinkColor = Color.FromArgb(41, 128, 185);
            forgotPasswordLink.Location = new Point(276, 307);
            forgotPasswordLink.Name = "forgotPasswordLink";
            forgotPasswordLink.Size = new Size(127, 20);
            forgotPasswordLink.TabIndex = 9;
            forgotPasswordLink.TabStop = true;
            forgotPasswordLink.Text = "Forgot password?";
            // 
            // rememberMeCheckBox
            // 
            rememberMeCheckBox.AutoSize = true;
            rememberMeCheckBox.CheckedState.BorderColor = Color.FromArgb(41, 128, 185);
            rememberMeCheckBox.CheckedState.BorderRadius = 0;
            rememberMeCheckBox.CheckedState.BorderThickness = 0;
            rememberMeCheckBox.CheckedState.FillColor = Color.FromArgb(41, 128, 185);
            rememberMeCheckBox.Font = new Font("Segoe UI", 9F);
            rememberMeCheckBox.Location = new Point(20, 305);
            rememberMeCheckBox.Name = "rememberMeCheckBox";
            rememberMeCheckBox.Size = new Size(129, 24);
            rememberMeCheckBox.TabIndex = 8;
            rememberMeCheckBox.Text = "Remember me";
            rememberMeCheckBox.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            rememberMeCheckBox.UncheckedState.BorderRadius = 0;
            rememberMeCheckBox.UncheckedState.BorderThickness = 0;
            rememberMeCheckBox.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            rememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.BorderRadius = 8;
            passwordTextBox.Cursor = Cursors.IBeam;
            passwordTextBox.CustomizableEdges = customizableEdges3;
            passwordTextBox.DefaultText = "Enter your password";
            passwordTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            passwordTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            passwordTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            passwordTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            passwordTextBox.FillColor = Color.FromArgb(248, 250, 252);
            passwordTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            passwordTextBox.Font = new Font("Segoe UI", 10F);
            passwordTextBox.ForeColor = Color.DimGray;
            passwordTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            passwordTextBox.Location = new Point(20, 260);
            passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '•';
            passwordTextBox.PlaceholderText = "";
            passwordTextBox.SelectedText = "";
            passwordTextBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            passwordTextBox.Size = new Size(371, 40);
            passwordTextBox.TabIndex = 6;
            passwordTextBox.TextOffset = new Point(5, 0);
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(17, 238);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(85, 23);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password";
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            emailTextBox.BorderRadius = 8;
            emailTextBox.Cursor = Cursors.IBeam;
            emailTextBox.CustomizableEdges = customizableEdges5;
            emailTextBox.DefaultText = "";
            emailTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            emailTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            emailTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            emailTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            emailTextBox.FillColor = Color.FromArgb(248, 250, 252);
            emailTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            emailTextBox.Font = new Font("Segoe UI", 10F);
            emailTextBox.ForeColor = Color.DimGray;
            emailTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            emailTextBox.Location = new Point(20, 190);
            emailTextBox.Margin = new Padding(3, 4, 3, 4);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "";
            emailTextBox.SelectedText = "";
            emailTextBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            emailTextBox.Size = new Size(371, 40);
            emailTextBox.TabIndex = 4;
            emailTextBox.TextOffset = new Point(5, 0);
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(18, 166);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(89, 23);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Username";
            // 
            // subtitleLabel
            // 
            subtitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            subtitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subtitleLabel.ForeColor = Color.Gray;
            subtitleLabel.Location = new Point(20, 137);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(371, 30);
            subtitleLabel.TabIndex = 2;
            subtitleLabel.Text = "Sign in to your pharmacy management account";
            subtitleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(20, 113);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(371, 24);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Medicine ERP System";
            titleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // iconPlaceholderPanel
            // 
            iconPlaceholderPanel.BackColor = Color.Transparent;
            iconPlaceholderPanel.BorderRadius = 25;
            iconPlaceholderPanel.CustomizableEdges = customizableEdges7;
            iconPlaceholderPanel.FillColor = Color.FromArgb(41, 128, 185);
            iconPlaceholderPanel.Location = new Point(181, 40);
            iconPlaceholderPanel.Name = "iconPlaceholderPanel";
            iconPlaceholderPanel.ShadowDecoration.CustomizableEdges = customizableEdges8;
            iconPlaceholderPanel.Size = new Size(50, 50);
            iconPlaceholderPanel.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(415, 496);
            Controls.Add(loginPanel);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign In";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel loginPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private Guna.UI2.WinForms.Guna2Button signInButton;
        private Guna.UI2.WinForms.Guna2CheckBox rememberMeCheckBox;
        private System.Windows.Forms.LinkLabel forgotPasswordLink;
        private Guna.UI2.WinForms.Guna2Panel iconPlaceholderPanel;
    }
}