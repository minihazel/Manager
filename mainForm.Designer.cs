namespace Manager
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panelInstallations = new System.Windows.Forms.Panel();
            this.titleInstallations = new System.Windows.Forms.Label();
            this.titleInstallationStatus = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageSettings = new System.Windows.Forms.PictureBox();
            this.imageAddNew = new System.Windows.Forms.PictureBox();
            this.imageInstallationStatus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAddNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageInstallationStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInstallations
            // 
            this.panelInstallations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelInstallations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInstallations.Location = new System.Drawing.Point(12, 67);
            this.panelInstallations.Name = "panelInstallations";
            this.panelInstallations.Size = new System.Drawing.Size(301, 353);
            this.panelInstallations.TabIndex = 0;
            // 
            // titleInstallations
            // 
            this.titleInstallations.Location = new System.Drawing.Point(12, 23);
            this.titleInstallations.Name = "titleInstallations";
            this.titleInstallations.Size = new System.Drawing.Size(226, 27);
            this.titleInstallations.TabIndex = 1;
            this.titleInstallations.Text = "Installations";
            this.titleInstallations.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // titleInstallationStatus
            // 
            this.titleInstallationStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.titleInstallationStatus.Location = new System.Drawing.Point(45, 424);
            this.titleInstallationStatus.Name = "titleInstallationStatus";
            this.titleInstallationStatus.Size = new System.Drawing.Size(268, 27);
            this.titleInstallationStatus.TabIndex = 2;
            this.titleInstallationStatus.Text = "0 available";
            this.titleInstallationStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(319, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 470);
            this.panel2.TabIndex = 1;
            // 
            // imageSettings
            // 
            this.imageSettings.BackgroundImage = global::Manager.Properties.Resources.settings;
            this.imageSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageSettings.Location = new System.Drawing.Point(289, 23);
            this.imageSettings.Name = "imageSettings";
            this.imageSettings.Size = new System.Drawing.Size(24, 24);
            this.imageSettings.TabIndex = 5;
            this.imageSettings.TabStop = false;
            this.imageSettings.Click += new System.EventHandler(this.imageSettings_Click);
            // 
            // imageAddNew
            // 
            this.imageAddNew.BackgroundImage = global::Manager.Properties.Resources.add_small;
            this.imageAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageAddNew.Location = new System.Drawing.Point(247, 23);
            this.imageAddNew.Name = "imageAddNew";
            this.imageAddNew.Size = new System.Drawing.Size(24, 24);
            this.imageAddNew.TabIndex = 4;
            this.imageAddNew.TabStop = false;
            this.imageAddNew.Click += new System.EventHandler(this.imageAddNew_Click);
            // 
            // imageInstallationStatus
            // 
            this.imageInstallationStatus.Location = new System.Drawing.Point(12, 423);
            this.imageInstallationStatus.Name = "imageInstallationStatus";
            this.imageInstallationStatus.Size = new System.Drawing.Size(27, 27);
            this.imageInstallationStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageInstallationStatus.TabIndex = 3;
            this.imageInstallationStatus.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 505);
            this.Controls.Add(this.imageSettings);
            this.Controls.Add(this.imageAddNew);
            this.Controls.Add(this.imageInstallationStatus);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.titleInstallationStatus);
            this.Controls.Add(this.titleInstallations);
            this.Controls.Add(this.panelInstallations);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAddNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageInstallationStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInstallations;
        private System.Windows.Forms.Label titleInstallations;
        private System.Windows.Forms.Label titleInstallationStatus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox imageInstallationStatus;
        private System.Windows.Forms.PictureBox imageAddNew;
        private System.Windows.Forms.PictureBox imageSettings;
    }
}

