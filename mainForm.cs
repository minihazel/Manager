using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Manager
{
    public partial class mainForm : Form
    {
        public Color listBackcolor = Color.FromArgb(255, 28, 28, 28);
        public Color listSelectedcolor = Color.FromArgb(255, 40, 40, 40);
        public Color listHovercolor = Color.FromArgb(255, 35, 35, 35);

        public string currentDir = Environment.CurrentDirectory;
        public string currentDbName = "db.json";

        public mainForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            settings wnd = new settings(this);
            wnd.Show();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            string currentUser = Properties.Settings.Default.currentUser;

            if (currentUser != "" && currentUser.Length > 0)
            {
                this.Text = $"Manager - {currentUser}";
                this.Tag = $"Manager - {currentUser}";

                listInstallations(fetchCurrentUser(this.Text));
            }
            else
            {
                this.Text = $"Manager - uninitiated";
                this.Tag = $"Manager - uninitiated";
            }
        }

        public string fetchCurrentUser(string text)
        {
            string inputText = text;
            int startIndex = inputText.IndexOf("Manager - ") + "Manager - ".Length;
            string result = inputText.Substring(startIndex);

            return result;
        }

        static JObject FindUserByUsername(string path, string targetValue)
        {
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                JObject dbObject = JObject.Parse(json);
                JArray usersArray = (JArray)dbObject["Users"];

                return usersArray.Children<JObject>()
                    .FirstOrDefault(obj => string.Equals((string)obj["Username"], targetValue, StringComparison.OrdinalIgnoreCase));
            }
            else
            {
                Console.WriteLine($"File not found: {path}");
                return null;
            }
        }

        public void listInstallations(string username)
        {
            JObject userObject = FindUserByUsername(Path.Combine(currentDir, currentDbName), username);
            if (userObject != null)
            {
                int widthspacer = 25;
                JArray installations = (JArray)userObject["Installations"];
                string[] installs = installations.Select(i => (string)i).ToArray();

                for (int i = 0; i < installs.Length; i++)
                {
                    Label lbl = new Label();
                    lbl.Text = installs[i];
                    lbl.AutoSize = false;
                    lbl.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                    lbl.TextAlign = ContentAlignment.MiddleLeft;
                    lbl.Size = new Size(this.Size.Width - 4, widthspacer);
                    lbl.Location = new Point(0, 1 + (i * widthspacer));
                    lbl.Font = new Font("Bahnschrift Light", 12, FontStyle.Regular);
                    lbl.BackColor = this.BackColor;
                    lbl.ForeColor = this.ForeColor;
                    lbl.Margin = new Padding(1, 1, 1, 1);
                    lbl.Cursor = Cursors.Hand;
                    panelInstallations.Controls.Add(lbl);
                }
            }
        }
    }
}
