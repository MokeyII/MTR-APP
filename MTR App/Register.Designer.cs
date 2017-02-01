namespace MTR_App
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtUserName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblPasswordsDoNotMatch = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPasswordsMatch = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = null;
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 0;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = true;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = true;
            this.btnCancel.IconZoom = 90D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(15, 312);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnCancel.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(116, 48);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.BorderRadius = 0;
            this.btnLogin.ButtonText = "Register";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogin.Iconimage")));
            this.btnLogin.Iconimage_right = null;
            this.btnLogin.Iconimage_right_Selected = null;
            this.btnLogin.Iconimage_Selected = null;
            this.btnLogin.IconMarginLeft = 0;
            this.btnLogin.IconMarginRight = 0;
            this.btnLogin.IconRightVisible = true;
            this.btnLogin.IconRightZoom = 0D;
            this.btnLogin.IconVisible = true;
            this.btnLogin.IconZoom = 90D;
            this.btnLogin.IsTab = false;
            this.btnLogin.Location = new System.Drawing.Point(236, 312);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.btnLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogin.selected = false;
            this.btnLogin.Size = new System.Drawing.Size(116, 48);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Register";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Textcolor = System.Drawing.Color.White;
            this.btnLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColorFocused = System.Drawing.Color.RoyalBlue;
            this.txtPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.BorderColorMouseHover = System.Drawing.Color.LightSteelBlue;
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.isPassword = true;
            this.txtPassword.Location = new System.Drawing.Point(12, 162);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(340, 44);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderColorFocused = System.Drawing.Color.RoyalBlue;
            this.txtUserName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserName.BorderColorMouseHover = System.Drawing.Color.LightSteelBlue;
            this.txtUserName.BorderThickness = 2;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserName.isPassword = false;
            this.txtUserName.Location = new System.Drawing.Point(12, 97);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(340, 44);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Blue Mountain Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColorFocused = System.Drawing.Color.RoyalBlue;
            this.txtEmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.BorderColorMouseHover = System.Drawing.Color.LightSteelBlue;
            this.txtEmail.BorderThickness = 2;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.isPassword = false;
            this.txtEmail.Location = new System.Drawing.Point(12, 29);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(340, 44);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderColorFocused = System.Drawing.Color.RoyalBlue;
            this.txtConfirmPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmPassword.BorderColorMouseHover = System.Drawing.Color.LightSteelBlue;
            this.txtConfirmPassword.BorderThickness = 2;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmPassword.isPassword = true;
            this.txtConfirmPassword.Location = new System.Drawing.Point(12, 227);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(340, 44);
            this.txtConfirmPassword.TabIndex = 4;
            this.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblPasswordsDoNotMatch
            // 
            this.lblPasswordsDoNotMatch.AutoSize = true;
            this.lblPasswordsDoNotMatch.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPasswordsDoNotMatch.Location = new System.Drawing.Point(99, 275);
            this.lblPasswordsDoNotMatch.Name = "lblPasswordsDoNotMatch";
            this.lblPasswordsDoNotMatch.Size = new System.Drawing.Size(166, 13);
            this.lblPasswordsDoNotMatch.TabIndex = 15;
            this.lblPasswordsDoNotMatch.Text = "PASSWORDS DO NOT MATCH!";
            // 
            // lblPasswordsMatch
            // 
            this.lblPasswordsMatch.AutoSize = true;
            this.lblPasswordsMatch.ForeColor = System.Drawing.Color.Green;
            this.lblPasswordsMatch.Location = new System.Drawing.Point(122, 275);
            this.lblPasswordsMatch.Name = "lblPasswordsMatch";
            this.lblPasswordsMatch.Size = new System.Drawing.Size(121, 13);
            this.lblPasswordsMatch.TabIndex = 16;
            this.lblPasswordsMatch.Text = "PASSWORDS MATCH!";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 372);
            this.Controls.Add(this.lblPasswordsMatch);
            this.Controls.Add(this.lblPasswordsDoNotMatch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUserName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPasswordsMatch;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPasswordsDoNotMatch;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtConfirmPassword;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEmail;
    }
}