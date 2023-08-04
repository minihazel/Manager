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
        public Color listBackcolor = SystemColors.Control;
        public Color listSelectedcolor = Color.Silver;
        public Color listHovercolor = Color.Gainsboro;

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

        private void deSelectAll(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                ctrl.BackColor = listBackcolor;
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

                    lbl.MouseEnter += new EventHandler(installation_MouseEnter);
                    lbl.MouseLeave += new EventHandler(installation_MouseLeave);
                    lbl.MouseDown += new MouseEventHandler(installation_MouseDown);

                    lbl.Margin = new Padding(1, 1, 1, 1);
                    lbl.Cursor = Cursors.Hand;
                    panelInstallations.Controls.Add(lbl);
                }
            }
        }

        private void installation_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (label.Text != "")
            {
                if (label.BackColor != listSelectedcolor)
                {
                    label.BackColor = listHovercolor;
                }
            }
        }

        private void installation_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (label.Text != "")
            {
                if (label.BackColor != listSelectedcolor)
                {
                    label.BackColor = listBackcolor;
                }
            }
        }

        private void installation_MouseDown(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;

            if (label.Text != "")
            {
                deSelectAll(label.Parent);
                label.BackColor = listSelectedcolor;
            }
        }
    }
}
