namespace Manager
{
    partial class addInstallation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addInstallation));
            this.titleCountNonSPT = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.titleURL = new System.Windows.Forms.Label();
            this.cmbCountNonSPT = new System.Windows.Forms.ComboBox();
            this.btnAddInstallation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleCountNonSPT
            // 
            this.titleCountNonSPT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleCountNonSPT.Location = new System.Drawing.Point(12, 82);
            this.titleCountNonSPT.Name = "titleCountNonSPT";
            this.titleCountNonSPT.Size = new System.Drawing.Size(455, 20);
            this.titleCountNonSPT.TabIndex = 14;
            this.titleCountNonSPT.Text = "Count non-SPT folders";
            this.titleCountNonSPT.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.Location = new System.Drawing.Point(15, 44);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(452, 25);
            this.txtURL.TabIndex = 13;
            // 
            // titleURL
            // 
            this.titleURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleURL.Location = new System.Drawing.Point(12, 21);
            this.titleURL.Name = "titleURL";
            this.titleURL.Size = new System.Drawing.Size(455, 20);
            this.titleURL.TabIndex = 12;
            this.titleURL.Text = "URL / Path";
            this.titleURL.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbCountNonSPT
            // 
            this.cmbCountNonSPT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCountNonSPT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountNonSPT.FormattingEnabled = true;
            this.cmbCountNonSPT.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmbCountNonSPT.Location = new System.Drawing.Point(15, 105);
            this.cmbCountNonSPT.Name = "cmbCountNonSPT";
            this.cmbCountNonSPT.Size = new System.Drawing.Size(452, 26);
            this.cmbCountNonSPT.TabIndex = 16;
            // 
            // btnAddInstallation
            // 
            this.btnAddInstallation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddInstallation.Location = new System.Drawing.Point(317, 272);
            this.btnAddInstallation.Name = "btnAddInstallation";
            this.btnAddInstallation.Size = new System.Drawing.Size(150, 35);
            this.btnAddInstallation.TabIndex = 17;
            this.btnAddInstallation.Text = "Add Installation";
            this.btnAddInstallation.UseVisualStyleBackColor = true;
            this.btnAddInstallation.Click += new System.EventHandler(this.btnAddInstallation_Click);
            // 
            // addInstallation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 341);
            this.Controls.Add(this.btnAddInstallation);
            this.Controls.Add(this.cmbCountNonSPT);
            this.Controls.Add(this.titleCountNonSPT);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.titleURL);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "addInstallation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new installation";
            this.Load += new System.EventHandler(this.addInstallation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleCountNonSPT;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label titleURL;
        private System.Windows.Forms.ComboBox cmbCountNonSPT;
        private System.Windows.Forms.Button btnAddInstallation;
    }
}