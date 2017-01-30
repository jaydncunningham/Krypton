using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Newtonsoft.Json;

namespace Krypton
{
    public class SteamAccount
    {
        [JsonIgnore]
        public bool hasInfoWindowOpen;

        string name;
        string username;
        string password;
        string email;
        bool matchmaking = false;

        public SteamAccount(string name, string username, string password, string email, bool ranked)
        {
            this.hasInfoWindowOpen = false;
            this.name = name;
            this.username = username;
            this.password = password;
            this.email = email;
            this.matchmaking = ranked;
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public string Username
        {
            get { return username; }
            set { this.username = value; }
        }

        public string Password
        {
            get { return password; }
            set { this.password = value; }
        }

        public string Email
        {
            get { return email; }
            set { this.email = value; }
        }

        public bool Matchmaking
        {
            get { return matchmaking; }
            set { this.matchmaking = value; }
        }

        public string getStartParameters()
        {
            return "-login " + this.username + " " + this.password;
        }

        public MaterialRaisedButton GetMaterialRaisedButton(int i)
        {
            MaterialRaisedButton b = new MaterialRaisedButton();
            b.Location = new System.Drawing.Point(3, (i * 30));
            b.Depth = 0;
            b.MouseState = MaterialSkin.MouseState.HOVER;
            b.Size = new System.Drawing.Size(310, 28);
            b.TabIndex = 0;
            b.Text = this.Matchmaking ? "[MM] " + Name : Name;
            b.UseVisualStyleBackColor = true;
            b.Click += new System.EventHandler(this.PlayerMatRaisedButtonClick);
            return b;
        }

        public MaterialRaisedButton GetMaterialRaisedButtonInfo(int i)
        {
            MaterialRaisedButton b = new MaterialRaisedButton();
            b.Location = new System.Drawing.Point(315, (i * 30));
            b.Depth = 0;
            b.MouseState = MaterialSkin.MouseState.HOVER;
            b.Name = "info" + i;
            b.Size = new System.Drawing.Size(50, 28);
            b.TabIndex = 0;
            b.Text = "Info";
            b.UseVisualStyleBackColor = true;
            b.Click += new System.EventHandler(this.InfoMatRaisedButtonClick);
            return b;
        }

        private void PlayerMatRaisedButtonClick(object o, EventArgs a)
        {
            new Thread(() =>
            {
                SteamController.StartSteamAccount(this);
            }).Start();
        }

        private void InfoMatRaisedButtonClick(object o, EventArgs a)
        {
            if (!hasInfoWindowOpen)
            {
                SteamAccountGUI s = new SteamAccountGUI(this);
                s.Show();
                this.hasInfoWindowOpen = true;
            }
        }
    }
}
