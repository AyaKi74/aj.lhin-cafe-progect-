
namespace cafe_3
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.txt_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.signup = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_login = new Guna.UI2.WinForms.Guna2Button();
            this.btnadmin = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(109)))), ((int)(((byte)(85)))));
            this.txt_username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(109)))), ((int)(((byte)(85)))));
            this.txt_username.BorderThickness = 0;
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.DefaultText = "";
            this.txt_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(109)))), ((int)(((byte)(85)))));
            this.txt_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.txt_username.ForeColor = System.Drawing.Color.White;
            this.txt_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.Location = new System.Drawing.Point(420, 217);
            this.txt_username.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.PlaceholderText = "Enter Username";
            this.txt_username.SelectedText = "";
            this.txt_username.Size = new System.Drawing.Size(410, 66);
            this.txt_username.TabIndex = 0;
            // 
            // txt_password
            // 
            this.txt_password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(109)))), ((int)(((byte)(85)))));
            this.txt_password.BorderThickness = 0;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.DefaultText = "";
            this.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(109)))), ((int)(((byte)(85)))));
            this.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.txt_password.ForeColor = System.Drawing.Color.White;
            this.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.Location = new System.Drawing.Point(420, 362);
            this.txt_password.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '#';
            this.txt_password.PlaceholderText = "Enter Password";
            this.txt_password.SelectedText = "";
            this.txt_password.Size = new System.Drawing.Size(410, 66);
            this.txt_password.TabIndex = 1;
            // 
            // signup
            // 
            this.signup.AutoSize = true;
            this.signup.BackColor = System.Drawing.Color.Transparent;
            this.signup.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.signup.Font = new System.Drawing.Font("DB Helvethaica X 55 Regular", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signup.Location = new System.Drawing.Point(392, 648);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(148, 58);
            this.signup.TabIndex = 2;
            this.signup.TabStop = true;
            this.signup.Text = "Sign Up";
            this.signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signup_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("DB Helvethaica X 55 Regular", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(642, 648);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(286, 58);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forget Password";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_login
            // 
            this.btn_login.AutoRoundedCorners = true;
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.BorderRadius = 40;
            this.btn_login.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btn_login.BorderThickness = 5;
            this.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_login.FillColor = System.Drawing.Color.Tan;
            this.btn_login.Font = new System.Drawing.Font("DB Helvethaica X 55 Regular", 48F, System.Drawing.FontStyle.Bold);
            this.btn_login.ForeColor = System.Drawing.Color.Black;
            this.btn_login.Location = new System.Drawing.Point(505, 477);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(217, 82);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Log in ";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btnadmin
            // 
            this.btnadmin.BackColor = System.Drawing.Color.Transparent;
            this.btnadmin.BorderColor = System.Drawing.Color.Transparent;
            this.btnadmin.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnadmin.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnadmin.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnadmin.CheckedState.ForeColor = System.Drawing.Color.Transparent;
            this.btnadmin.CustomBorderColor = System.Drawing.Color.Black;
            this.btnadmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnadmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnadmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnadmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnadmin.FillColor = System.Drawing.Color.Transparent;
            this.btnadmin.Font = new System.Drawing.Font("DB Helvethaica X 55 Regular", 27.75F, System.Drawing.FontStyle.Bold);
            this.btnadmin.ForeColor = System.Drawing.Color.White;
            this.btnadmin.Location = new System.Drawing.Point(12, 12);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(102, 90);
            this.btnadmin.TabIndex = 5;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            this.btnadmin.DoubleClick += new System.EventHandler(this.btnadmin_DoubleClick);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 715);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.DoubleBuffered = true;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txt_username;
        private Guna.UI2.WinForms.Guna2TextBox txt_password;
        private System.Windows.Forms.LinkLabel signup;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2Button btn_login;
        private Guna.UI2.WinForms.Guna2Button btnadmin;
    }
}

