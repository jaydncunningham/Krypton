using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Krypton
{
    public partial class AddAccountGUI : MaterialForm
    {
        KryptonGUI g;
        public AddAccountGUI(KryptonGUI g)
        {
            this.g = g;
            {
                MaterialSkinManager m = MaterialSkinManager.Instance;
                m.AddFormToManage(this);
                m.Theme = MaterialSkinManager.Themes.LIGHT;
                m.ColorScheme = new ColorScheme(Primary.LightBlue800, Primary.LightBlue900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            }
            InitializeComponent();
        }

        private void AddAccountGUI_Load(object sender, EventArgs e)
        {

        }

        public static string RandomString(int len)
        {
            char[] chars = new char[62];
            chars =
            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            byte[] data = new byte[1];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetNonZeroBytes(data);
                data = new byte[len];
                crypto.GetNonZeroBytes(data);
            }
            StringBuilder result = new StringBuilder(len);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }

        private void CheckBox_Random_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            TF_Name.Text = RandomString(16);
            TF_User.Text = TF_Name.Text;
            TF_Pass.Text = RandomString(16);
            TF_Email.Text = RandomString(6) + "@" + RandomString(10) + ".com";
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            g.AddAccount(TF_Name.Text, TF_User.Text, TF_Pass.Text, TF_Email.Text, TF_MM.Checked);
            this.Close();
        }
    }
}
