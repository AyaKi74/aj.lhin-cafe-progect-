﻿
namespace cafe_3.UC
{
    partial class forget_password_uc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forget_password_uc));
            this.txtemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtotp = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnsend = new Guna.UI2.WinForms.Guna2Button();
            this.btnsubmit = new Guna.UI2.WinForms.Guna2Button();
            this.forgetpassword = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // txtemail
            // 
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.DefaultText = "";
            this.txtemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Location = new System.Drawing.Point(428, 263);
            this.txtemail.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.PlaceholderText = "";
            this.txtemail.SelectedText = "";
            this.txtemail.Size = new System.Drawing.Size(274, 42);
            this.txtemail.TabIndex = 0;
            // 
            // txtotp
            // 
            this.txtotp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtotp.DefaultText = "";
            this.txtotp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtotp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtotp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtotp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtotp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtotp.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtotp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtotp.Location = new System.Drawing.Point(428, 470);
            this.txtotp.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtotp.Name = "txtotp";
            this.txtotp.PasswordChar = '\0';
            this.txtotp.PlaceholderText = "";
            this.txtotp.SelectedText = "";
            this.txtotp.Size = new System.Drawing.Size(274, 42);
            this.txtotp.TabIndex = 1;
            // 
            // btnsend
            // 
            this.btnsend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsend.FillColor = System.Drawing.Color.Green;
            this.btnsend.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsend.ForeColor = System.Drawing.Color.White;
            this.btnsend.Location = new System.Drawing.Point(910, 333);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(171, 53);
            this.btnsend.TabIndex = 3;
            this.btnsend.Text = "Send";
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsubmit.FillColor = System.Drawing.Color.Green;
            this.btnsubmit.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.ForeColor = System.Drawing.Color.White;
            this.btnsubmit.Location = new System.Drawing.Point(910, 537);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(171, 53);
            this.btnsubmit.TabIndex = 4;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // forgetpassword
            // 
            this.forgetpassword.TargetControl = this;
            // 
            // forget_password_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.txtotp);
            this.Controls.Add(this.txtemail);
            this.Name = "forget_password_uc";
            this.Size = new System.Drawing.Size(1280, 720);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtemail;
        private Guna.UI2.WinForms.Guna2TextBox txtotp;
        private Guna.UI2.WinForms.Guna2Button btnsend;
        private Guna.UI2.WinForms.Guna2Button btnsubmit;
        private Guna.UI2.WinForms.Guna2Elipse forgetpassword;
    }
}