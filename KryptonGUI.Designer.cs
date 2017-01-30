namespace Krypton
{
    partial class KryptonGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KryptonGUI));
            this.Panel_Accounts = new System.Windows.Forms.Panel();
            this.Button_AddAccount = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Button_Friends = new MaterialSkin.Controls.MaterialRaisedButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // Panel_Accounts
            // 
            this.Panel_Accounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Panel_Accounts.AutoScroll = true;
            this.Panel_Accounts.Location = new System.Drawing.Point(1, 68);
            this.Panel_Accounts.Name = "Panel_Accounts";
            this.Panel_Accounts.Size = new System.Drawing.Size(389, 429);
            this.Panel_Accounts.TabIndex = 0;
            // 
            // Button_AddAccount
            // 
            this.Button_AddAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_AddAccount.AutoSize = true;
            this.Button_AddAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_AddAccount.Depth = 0;
            this.Button_AddAccount.Location = new System.Drawing.Point(271, 506);
            this.Button_AddAccount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Button_AddAccount.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_AddAccount.Name = "Button_AddAccount";
            this.Button_AddAccount.Primary = false;
            this.Button_AddAccount.Size = new System.Drawing.Size(106, 36);
            this.Button_AddAccount.TabIndex = 1;
            this.Button_AddAccount.Text = "Add Account";
            this.Button_AddAccount.UseVisualStyleBackColor = true;
            this.Button_AddAccount.Click += new System.EventHandler(this.Button_AddAccount_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(19, 514);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(10);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(111, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "0 users loaded.";
            // 
            // Button_Friends
            // 
            this.Button_Friends.Depth = 0;
            this.Button_Friends.Location = new System.Drawing.Point(309, 32);
            this.Button_Friends.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_Friends.Name = "Button_Friends";
            this.Button_Friends.Primary = true;
            this.Button_Friends.Size = new System.Drawing.Size(73, 23);
            this.Button_Friends.TabIndex = 3;
            this.Button_Friends.Text = "Systray";
            this.Button_Friends.UseVisualStyleBackColor = true;
            this.Button_Friends.Click += new System.EventHandler(this.materialRaisedButton1_Click_1);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // KryptonGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 550);
            this.Controls.Add(this.Button_Friends);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.Button_AddAccount);
            this.Controls.Add(this.Panel_Accounts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(390, 1080);
            this.MinimumSize = new System.Drawing.Size(390, 550);
            this.Name = "KryptonGUI";
            this.Text = "Krypton";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KryptonGUI_FormClosing);
            this.Load += new System.EventHandler(this.KryptonGUI_Load);
            this.Resize += new System.EventHandler(this.KryptonGUI_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Accounts;
        private MaterialSkin.Controls.MaterialFlatButton Button_AddAccount;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton Button_Friends;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

