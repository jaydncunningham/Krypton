using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Krypton
{
    public partial class SteamAccountGUI : MaterialForm
    {
        private SteamAccount s;

        public SteamAccountGUI(SteamAccount s)
        {
            this.s = s;
            {
                MaterialSkinManager m = MaterialSkinManager.Instance;
                m.AddFormToManage(this);
                m.Theme = MaterialSkinManager.Themes.LIGHT;
                m.ColorScheme = new ColorScheme(Primary.LightBlue800, Primary.LightBlue900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            }
            InitializeComponent();
        }

        private void SteamAccountGUI_Load(object sender, EventArgs e)
        {
            this.Text = s.Name;
            this.TF_Name.Text = s.Name;
            this.TF_User.Text = s.Username;
            this.TF_Pass.Text = s.Password;
            this.TF_Email.Text = s.Email;
            this.TF_MM.Checked = s.Matchmaking;
        }

        private void SteamAccountGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            s.hasInfoWindowOpen = false;
        }

        private void Button_Remove_Click(object sender, EventArgs e)
        {
            Program.g.accounts.Remove(s);
            Program.g.RefreshGUI();
            Program.g.WriteOutAccounts();
            this.Close();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            Program.g.accounts.Remove(s);
            Program.g.AddAccount(TF_Name.Text, TF_User.Text, TF_Pass.Text, TF_Email.Text, TF_MM.Checked);
            this.Close();
            Program.g.RefreshGUI();
            Program.g.WriteOutAccounts();
        }
    }
}
