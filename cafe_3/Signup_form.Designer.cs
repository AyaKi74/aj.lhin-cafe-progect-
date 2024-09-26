
namespace cafe_3
{
    partial class Signup_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.signup_UC1 = new cafe_3.UC.signup_UC();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.signup_UC1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 720);
            this.panel1.TabIndex = 0;
            // 
            // signup_UC1
            // 
            this.signup_UC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signup_UC1.BackgroundImage")));
            this.signup_UC1.Location = new System.Drawing.Point(0, -3);
            this.signup_UC1.Name = "signup_UC1";
            this.signup_UC1.Size = new System.Drawing.Size(1280, 720);
            this.signup_UC1.TabIndex = 0;
            this.signup_UC1.Load += new System.EventHandler(this.signup_UC1_Load);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            // 
            // Signup_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 715);
            this.Controls.Add(this.panel1);
            this.Name = "Signup_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup_form";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private UC.signup_UC signup_UC1;
    }
}