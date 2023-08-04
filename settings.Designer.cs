namespace Manager
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.groupAuthentication = new System.Windows.Forms.GroupBox();
            this.txtInstallationPath = new System.Windows.Forms.TextBox();
            this.titleInstallationPath = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.titlePassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.listUsers = new System.Windows.Forms.ComboBox();
            this.titleUsername = new System.Windows.Forms.Label();
            this.btnEditCurrentUser = new System.Windows.Forms.Button();
            this.groupAuthentication.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupAuthentication
            // 
            this.groupAuthentication.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupAuthentication.Controls.Add(this.btnEditCurrentUser);
            this.groupAuthentication.Controls.Add(this.txtInstallationPath);
            this.groupAuthentication.Controls.Add(this.titleInstallationPath);
            this.groupAuthentication.Controls.Add(this.btnAddUser);
            this.groupAuthentication.Controls.Add(this.txtPassword);
            this.groupAuthentication.Controls.Add(this.titlePassword);
            this.groupAuthentication.Controls.Add(this.txtUsername);
            this.groupAuthentication.Controls.Add(this.listUsers);
            this.groupAuthentication.Controls.Add(this.titleUsername);
            this.groupAuthentication.Location = new System.Drawing.Point(12, 21);
            this.groupAuthentication.Name = "groupAuthentication";
            this.groupAuthentication.Size = new System.Drawing.Size(479, 308);
            this.groupAuthentication.TabIndex = 7;
            this.groupAuthentication.TabStop = false;
            this.groupAuthentication.Text = "Authentication";
            // 
            // txtInstallationPath
            // 
            this.txtInstallationPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInstallationPath.Location = new System.Drawing.Point(9, 206);
            this.txtInstallationPath.Name = "txtInstallationPath";
            this.txtInstallationPath.Size = new System.Drawing.Size(452, 25);
            this.txtInstallationPath.TabIndex = 13;
            // 
            // titleInstallationPath
            // 
            this.titleInstallationPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleInstallationPath.Location = new System.Drawing.Point(6, 183);
            this.titleInstallationPath.Name = "titleInstallationPath";
            this.titleInstallationPath.Size = new System.Drawing.Size(455, 20);
            this.titleInstallationPath.TabIndex = 12;
            this.titleInstallationPath.Text = "Installations path";
            this.titleInstallationPath.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUser.Location = new System.Drawing.Point(331, 256);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(130, 35);
            this.btnAddUser.TabIndex = 14;
            this.btnAddUser.Text = "Add user";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(9, 146);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(452, 25);
            this.txtPassword.TabIndex = 11;
            // 
            // titlePassword
            // 
            this.titlePassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titlePassword.Location = new System.Drawing.Point(6, 123);
            this.titlePassword.Name = "titlePassword";
            this.titlePassword.Size = new System.Drawing.Size(455, 20);
            this.titlePassword.TabIndex = 10;
            this.titlePassword.Text = "Password";
            this.titlePassword.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(9, 85);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(452, 25);
            this.txtUsername.TabIndex = 9;
            // 
            // listUsers
            // 
            this.listUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listUsers.FormattingEnabled = true;
            this.listUsers.Location = new System.Drawing.Point(9, 24);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(369, 26);
            this.listUsers.TabIndex = 0;
            this.listUsers.SelectedIndexChanged += new System.EventHandler(this.listUsers_SelectedIndexChanged);
            // 
            // titleUsername
            // 
            this.titleUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleUsername.Location = new System.Drawing.Point(6, 62);
            this.titleUsername.Name = "titleUsername";
            this.titleUsername.Size = new System.Drawing.Size(455, 20);
            this.titleUsername.TabIndex = 8;
            this.titleUsername.Text = "Username";
            this.titleUsername.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnEditCurrentUser
            // 
            this.btnEditCurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCurrentUser.Location = new System.Drawing.Point(166, 256);
            this.btnEditCurrentUser.Name = "btnEditCurrentUser";
            this.btnEditCurrentUser.Size = new System.Drawing.Size(150, 35);
            this.btnEditCurrentUser.TabIndex = 15;
            this.btnEditCurrentUser.Text = "Edit current user";
            this.btnEditCurrentUser.UseVisualStyleBackColor = true;
            this.btnEditCurrentUser.Click += new System.EventHandler(this.btnEditCurrentUser_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 341);
            this.Controls.Add(this.groupAuthentication);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.settings_FormClosing);
            this.Load += new System.EventHandler(this.settings_Load);
            this.groupAuthentication.ResumeLayout(false);
            this.groupAuthentication.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupAuthentication;
        private System.Windows.Forms.ComboBox listUsers;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label titleUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label titlePassword;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtInstallationPath;
        private System.Windows.Forms.Label titleInstallationPath;
        private System.Windows.Forms.Button btnEditCurrentUser;
    }
}