
namespace cafe_3
{
    partial class Reset_password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reset_password));
            this.txtpassword1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtpassword2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnsubmit = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txtpassword1
            // 
            this.txtpassword1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword1.DefaultText = "";
            this.txtpassword1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpassword1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpassword1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword1.Location = new System.Drawing.Point(632, 246);
            this.txtpassword1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtpassword1.Name = "txtpassword1";
            this.txtpassword1.PasswordChar = '*';
            this.txtpassword1.PlaceholderText = "";
            this.txtpassword1.SelectedText = "";
            this.txtpassword1.Size = new System.Drawing.Size(274, 42);
            this.txtpassword1.TabIndex = 2;
            // 
            // txtpassword2
            // 
            this.txtpassword2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword2.DefaultText = "";
            this.txtpassword2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpassword2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpassword2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword2.Location = new System.Drawing.Point(632, 426);
            this.txtpassword2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtpassword2.Name = "txtpassword2";
            this.txtpassword2.PasswordChar = '\0';
            this.txtpassword2.PlaceholderText = "";
            this.txtpassword2.SelectedText = "";
            this.txtpassword2.Size = new System.Drawing.Size(274, 42);
            this.txtpassword2.TabIndex = 3;
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
            this.btnsubmit.Location = new System.Drawing.Point(730, 503);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(176, 61);
            this.btnsubmit.TabIndex = 6;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // Reset_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txtpassword2);
            this.Controls.Add(this.txtpassword1);
            this.DoubleBuffered = true;
            this.Name = "Reset_password";
            this.Text = "Reset_password";
            this.Load += new System.EventHandler(this.Reset_password_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtpassword1;
        private Guna.UI2.WinForms.Guna2TextBox txtpassword2;
        private Guna.UI2.WinForms.Guna2Button btnsubmit;
    }
}