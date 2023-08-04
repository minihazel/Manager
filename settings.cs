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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Manager
{
    public partial class settings : Form
    {
        public string updatedUser { get; private set; }

        public string currentDir = Environment.CurrentDirectory;
        public string currentDbName = "db.json";

        private mainForm frm;

        public settings(mainForm instance)
        {
            InitializeComponent();
            frm = instance;
        }

        private void settings_Load(object sender, EventArgs e)
        {
            string db = Path.Combine(currentDir, currentDbName);
            bool dbExists = File.Exists(db);
            if (dbExists)
            {
                listPeople(db);
            }

            titleUsername.Select();
        }

        private void clearBoxes()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtInstallationPath.Text = "";
        }

        private void listPeople(string path)
        {
            string dbPath = path;
            string json = File.ReadAllText(dbPath);

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            dynamic dbObject = serializer.Deserialize<dynamic>(json);

            if (dbObject["Users"].Length > 0)
            {
                List<string> usernames = new List<string>();
                foreach (var user in dbObject["Users"])
                {
                    string username = user["Username"];
                    string pw = user["Password"];
                    string iP = user["Installation_Path"];

                    listUsers.Items.Add(username);
                }
            }
            else
            {
                listUsers.Items.Add("No users detected");
            }

            fetchInfo(Properties.Settings.Default.currentUser);
            listUsers.SelectedItem = Properties.Settings.Default.currentUser;
        }

        private void fetchInfo(string _username)
        {
            string dbPath = Path.Combine(currentDir, currentDbName);
            string json = File.ReadAllText(dbPath);

            JObject dbObject = JObject.Parse(json);
            foreach (var item in (JArray)dbObject["Users"])
            {
                string username = item["Username"].ToString();
                if (username == _username)
                {
                    string pw = item["Password"].ToString();
                    string installPath = item["Installation_Path"].ToString();

                    txtUsername.Text = username;
                    txtPassword.Text = pw;
                    txtInstallationPath.Text = installPath;
                }
            }
        }

        private void editInfo(string _username, string pw, string instPath)
        {
            string dbPath = Path.Combine(currentDir, currentDbName);
            string json = File.ReadAllText(dbPath);

            JObject dbObject = JObject.Parse(json);
            foreach (var item in (JArray)dbObject["Users"])
            {
                string username = item["Username"].ToString();
                if (username == _username)
                {
                    item["Password"] = pw;
                    item["Installation_Path"] = instPath;

                    var updatedData = JsonConvert.SerializeObject(dbObject, Formatting.Indented);

                    try
                    {
                        File.WriteAllText(dbPath, updatedData);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"ERROR: {ex.Message.ToString()}");
                        MessageBox.Show($"We encountered an error: {ex.Message.ToString()}", this.Text, MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            bool alreadyExists = false;

            foreach (string item in listUsers.Items)
            {
                if (txtUsername.Text.ToLower() == item.ToLower())
                {
                    alreadyExists = true;
                }
            }

            if (!alreadyExists)
            {
                string username = txtUsername.Text;
                string pw = txtPassword.Text;
                string installPath = txtInstallationPath.Text;

                bool installPathExists = Directory.Exists(installPath);
                if (!installPathExists)
                    Directory.CreateDirectory(installPath);

                string dbPath = Path.Combine(currentDir, currentDbName);
                string json = File.ReadAllText(dbPath);

                JObject dbObject = JObject.Parse(json);

                JArray usersArray = (JArray)dbObject["Users"];
                JObject newUser = new JObject
                {
                    { "Username", username },
                    { "Password", pw },
                    { "Installation_Path", installPath },
                    { "Installations", new JArray() }
                };
                usersArray.Add(newUser);
                string updatedData = dbObject.ToString();

                if (File.Exists(dbPath))
                    File.WriteAllText(dbPath, updatedData);

                listUsers.Items.Add(username);
                listUsers.SelectedItem = Properties.Settings.Default.currentUser;
            }
        }

        private void listUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.currentUser = listUsers.SelectedItem.ToString();
            Properties.Settings.Default.Save();

            frm.Tag = Properties.Settings.Default.currentUser;
            fetchInfo(listUsers.SelectedItem.ToString());
        }

        private void settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm.Text = $"Manager - {listUsers.SelectedItem.ToString()}";
        }

        private void btnEditCurrentUser_Click(object sender, EventArgs e)
        {
            if (listUsers.SelectedText != "" && txtUsername.Text != "")
            {
                editInfo(listUsers.SelectedText.ToString(), txtPassword.Text, txtInstallationPath.Text);
            }
        }
    }
}
