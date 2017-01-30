namespace Krypton
{
    partial class SteamAccountGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SteamAccountGUI));
            this.Label_Name = new System.Windows.Forms.Label();
            this.Label_User = new System.Windows.Forms.Label();
            this.Label_Pass = new System.Windows.Forms.Label();
            this.Label_Email = new System.Windows.Forms.Label();
            this.TF_Name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TF_User = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TF_Pass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TF_Email = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Button_Remove = new MaterialSkin.Controls.MaterialFlatButton();
            this.Button_Save = new MaterialSkin.Controls.MaterialFlatButton();
            this.TF_MM = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Name.Location = new System.Drawing.Point(12, 75);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(52, 21);
            this.Label_Name.TabIndex = 0;
            this.Label_Name.Text = "Name";
            // 
            // Label_User
            // 
            this.Label_User.AutoSize = true;
            this.Label_User.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_User.Location = new System.Drawing.Point(12, 114);
            this.Label_User.Name = "Label_User";
            this.Label_User.Size = new System.Drawing.Size(42, 21);
            this.Label_User.TabIndex = 1;
            this.Label_User.Text = "User";
            // 
            // Label_Pass
            // 
            this.Label_Pass.AutoSize = true;
            this.Label_Pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Pass.Location = new System.Drawing.Point(12, 155);
            this.Label_Pass.Name = "Label_Pass";
            this.Label_Pass.Size = new System.Drawing.Size(41, 21);
            this.Label_Pass.TabIndex = 2;
            this.Label_Pass.Text = "Pass";
            // 
            // Label_Email
            // 
            this.Label_Email.AutoSize = true;
            this.Label_Email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Email.Location = new System.Drawing.Point(12, 194);
            this.Label_Email.Name = "Label_Email";
            this.Label_Email.Size = new System.Drawing.Size(48, 21);
            this.Label_Email.TabIndex = 3;
            this.Label_Email.Text = "Email";
            // 
            // TF_Name
            // 
            this.TF_Name.Depth = 0;
            this.TF_Name.Hint = "";
            this.TF_Name.Location = new System.Drawing.Point(71, 72);
            this.TF_Name.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_Name.Name = "TF_Name";
            this.TF_Name.PasswordChar = '\0';
            this.TF_Name.SelectedText = "";
            this.TF_Name.SelectionLength = 0;
            this.TF_Name.SelectionStart = 0;
            this.TF_Name.Size = new System.Drawing.Size(265, 23);
            this.TF_Name.TabIndex = 4;
            this.TF_Name.UseSystemPasswordChar = false;
            // 
            // TF_User
            // 
            this.TF_User.Depth = 0;
            this.TF_User.Hint = "";
            this.TF_User.Location = new System.Drawing.Point(71, 114);
            this.TF_User.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_User.Name = "TF_User";
            this.TF_User.PasswordChar = '\0';
            this.TF_User.SelectedText = "";
            this.TF_User.SelectionLength = 0;
            this.TF_User.SelectionStart = 0;
            this.TF_User.Size = new System.Drawing.Size(265, 23);
            this.TF_User.TabIndex = 5;
            this.TF_User.UseSystemPasswordChar = false;
            // 
            // TF_Pass
            // 
            this.TF_Pass.Depth = 0;
            this.TF_Pass.Hint = "";
            this.TF_Pass.Location = new System.Drawing.Point(71, 155);
            this.TF_Pass.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_Pass.Name = "TF_Pass";
            this.TF_Pass.PasswordChar = '\0';
            this.TF_Pass.SelectedText = "";
            this.TF_Pass.SelectionLength = 0;
            this.TF_Pass.SelectionStart = 0;
            this.TF_Pass.Size = new System.Drawing.Size(265, 23);
            this.TF_Pass.TabIndex = 6;
            this.TF_Pass.UseSystemPasswordChar = false;
            // 
            // TF_Email
            // 
            this.TF_Email.Depth = 0;
            this.TF_Email.Hint = "";
            this.TF_Email.Location = new System.Drawing.Point(71, 194);
            this.TF_Email.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_Email.Name = "TF_Email";
            this.TF_Email.PasswordChar = '\0';
            this.TF_Email.SelectedText = "";
            this.TF_Email.SelectionLength = 0;
            this.TF_Email.SelectionStart = 0;
            this.TF_Email.Size = new System.Drawing.Size(265, 23);
            this.TF_Email.TabIndex = 7;
            this.TF_Email.UseSystemPasswordChar = false;
            // 
            // Button_Remove
            // 
            this.Button_Remove.AutoSize = true;
            this.Button_Remove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_Remove.Depth = 0;
            this.Button_Remove.Location = new System.Drawing.Point(270, 262);
            this.Button_Remove.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Button_Remove.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_Remove.Name = "Button_Remove";
            this.Button_Remove.Primary = false;
            this.Button_Remove.Size = new System.Drawing.Size(66, 36);
            this.Button_Remove.TabIndex = 8;
            this.Button_Remove.Text = "Remove";
            this.Button_Remove.UseVisualStyleBackColor = true;
            this.Button_Remove.Click += new System.EventHandler(this.Button_Remove_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.AutoSize = true;
            this.Button_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_Save.Depth = 0;
            this.Button_Save.Location = new System.Drawing.Point(16, 262);
            this.Button_Save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Button_Save.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Primary = false;
            this.Button_Save.Size = new System.Drawing.Size(46, 36);
            this.Button_Save.TabIndex = 9;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // TF_MM
            // 
            this.TF_MM.AutoSize = true;
            this.TF_MM.Depth = 0;
            this.TF_MM.Font = new System.Drawing.Font("Roboto", 10F);
            this.TF_MM.Location = new System.Drawing.Point(9, 226);
            this.TF_MM.Margin = new System.Windows.Forms.Padding(0);
            this.TF_MM.MouseLocation = new System.Drawing.Point(-1, -1);
            this.TF_MM.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_MM.Name = "TF_MM";
            this.TF_MM.Ripple = true;
            this.TF_MM.Size = new System.Drawing.Size(176, 30);
            this.TF_MM.TabIndex = 10;
            this.TF_MM.Text = "Ready for Matchmaking";
            this.TF_MM.UseVisualStyleBackColor = true;
            // 
            // SteamAccountGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 313);
            this.Controls.Add(this.TF_MM);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.Button_Remove);
            this.Controls.Add(this.TF_Email);
            this.Controls.Add(this.TF_Pass);
            this.Controls.Add(this.TF_User);
            this.Controls.Add(this.TF_Name);
            this.Controls.Add(this.Label_Email);
            this.Controls.Add(this.Label_Pass);
            this.Controls.Add(this.Label_User);
            this.Controls.Add(this.Label_Name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SteamAccountGUI";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steam Account";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SteamAccountGUI_FormClosing);
            this.Load += new System.EventHandler(this.SteamAccountGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Label_User;
        private System.Windows.Forms.Label Label_Pass;
        private System.Windows.Forms.Label Label_Email;
        private MaterialSkin.Controls.MaterialSingleLineTextField TF_Name;
        private MaterialSkin.Controls.MaterialSingleLineTextField TF_User;
        private MaterialSkin.Controls.MaterialSingleLineTextField TF_Pass;
        private MaterialSkin.Controls.MaterialSingleLineTextField TF_Email;
        private MaterialSkin.Controls.MaterialFlatButton Button_Remove;
        private MaterialSkin.Controls.MaterialFlatButton Button_Save;
        private MaterialSkin.Controls.MaterialCheckBox TF_MM;
    }
}