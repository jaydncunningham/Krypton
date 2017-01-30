using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;

namespace Krypton
{
    public partial class KryptonGUI : MaterialForm
    {

        public List<SteamAccount> accounts;

        public void RefreshAccounts()
        {
            if (File.Exists(@"accounts.db"))
            {
                accounts = JsonConvert.DeserializeObject<List<SteamAccount>>(File.ReadAllText(@"accounts.db"));
            }
            else
            {
                accounts = new List<SteamAccount>();
            }
        }

        public void RefreshGUI()
        {
            this.Panel_Accounts.Controls.Clear();
            for (int i = 0; i < accounts.Count; i++)
            {
                {
                    this.Panel_Accounts.Controls.Add(accounts[i].GetMaterialRaisedButton(i));
                    this.Panel_Accounts.Controls.Add(accounts[i].GetMaterialRaisedButtonInfo(i));
                }
            }
            this.materialLabel1.Text = accounts.Count() + " accounts loaded.";
        }

        public void WriteOutAccounts()
        {
            File.WriteAllText(@"accounts.db", JsonConvert.SerializeObject(accounts));
        }

        public KryptonGUI()
        {
            {
                MaterialSkinManager m = MaterialSkinManager.Instance;
                m.AddFormToManage(this);
                m.Theme = MaterialSkinManager.Themes.LIGHT;
                m.ColorScheme = new ColorScheme(Primary.LightBlue800, Primary.LightBlue900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            }
            InitializeComponent();
            notifyIcon1.Icon = SystemIcons.Application;
        }

        private void KryptonGUI_Load(object sender, EventArgs e)
        {
            RefreshAccounts();
            RefreshGUI();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.GetType().ToString());
        }

        private void Button_AddAccount_Click(object sender, EventArgs e)
        {
            new AddAccountGUI(this).Show();
        }

        internal void AddAccount(string name, string user, string pass, string email, bool ranked)
        {
            accounts.Add(new SteamAccount(name, user, pass, email, ranked));
            RefreshGUI();
            WriteOutAccounts();
        }

        private void KryptonGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText("accounts.db", JsonConvert.SerializeObject(accounts));
        }

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void KryptonGUI_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                this.Hide(); 
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }
    }
}
