
namespace cafe_3
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btncoffee = new Guna.UI2.WinForms.Guna2Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnHelp = new Guna.UI2.WinForms.Guna2Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAbout = new Guna.UI2.WinForms.Guna2Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Log_out = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.user = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.welcome = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.about_me = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.help = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.coffee = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cake = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cart = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.shoptimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Gray;
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel10);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sidebar.Location = new System.Drawing.Point(3, 3);
            this.sidebar.MaximumSize = new System.Drawing.Size(236, 720);
            this.sidebar.MinimumSize = new System.Drawing.Size(75, 720);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(236, 720);
            this.sidebar.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 95);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DB Helvethaica X 55 Regular", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnHome);
            this.panel3.Location = new System.Drawing.Point(3, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 72);
            this.panel3.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHome.Location = new System.Drawing.Point(22, 14);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(186, 45);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btncoffee);
            this.panel10.Location = new System.Drawing.Point(3, 182);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(228, 66);
            this.panel10.TabIndex = 3;
            // 
            // btncoffee
            // 
            this.btncoffee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncoffee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncoffee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncoffee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncoffee.FillColor = System.Drawing.Color.Transparent;
            this.btncoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btncoffee.ForeColor = System.Drawing.Color.White;
            this.btncoffee.Image = ((System.Drawing.Image)(resources.GetObject("btncoffee.Image")));
            this.btncoffee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btncoffee.ImageSize = new System.Drawing.Size(30, 30);
            this.btncoffee.Location = new System.Drawing.Point(23, 12);
            this.btncoffee.Name = "btncoffee";
            this.btncoffee.Size = new System.Drawing.Size(186, 42);
            this.btncoffee.TabIndex = 0;
            this.btncoffee.Text = "Coffee";
            this.btncoffee.Click += new System.EventHandler(this.btncoffee_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnHelp);
            this.panel5.Location = new System.Drawing.Point(3, 254);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(228, 72);
            this.panel5.TabIndex = 3;
            // 
            // btnHelp
            // 
            this.btnHelp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHelp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHelp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHelp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHelp.FillColor = System.Drawing.Color.Transparent;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHelp.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHelp.Location = new System.Drawing.Point(23, 13);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(186, 45);
            this.btnHelp.TabIndex = 0;
            this.btnHelp.Text = "Help";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnAbout);
            this.panel6.Location = new System.Drawing.Point(3, 332);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(228, 72);
            this.panel6.TabIndex = 3;
            // 
            // btnAbout
            // 
            this.btnAbout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAbout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAbout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAbout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAbout.FillColor = System.Drawing.Color.Transparent;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAbout.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAbout.Location = new System.Drawing.Point(23, 13);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(186, 45);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.Log_out);
            this.panel8.Location = new System.Drawing.Point(3, 410);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(233, 96);
            this.panel8.TabIndex = 4;
            // 
            // Log_out
            // 
            this.Log_out.AutoSize = true;
            this.Log_out.Font = new System.Drawing.Font("DB Helvethaica X 55 Regular", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_out.LinkColor = System.Drawing.Color.White;
            this.Log_out.Location = new System.Drawing.Point(40, 24);
            this.Log_out.Name = "Log_out";
            this.Log_out.Size = new System.Drawing.Size(150, 58);
            this.Log_out.TabIndex = 0;
            this.Log_out.TabStop = true;
            this.Log_out.Text = "Log out ";
            this.Log_out.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Log_out_LinkClicked);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.user);
            this.panel4.Location = new System.Drawing.Point(3, 512);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 100);
            this.panel4.TabIndex = 6;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(18, 40);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(79, 29);
            this.user.TabIndex = 5;
            this.user.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(240, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 720);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // shoptimer
            // 
            this.shoptimer.Interval = 10;
            this.shoptimer.Tick += new System.EventHandler(this.shoptimer_Tick);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(192)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1527, 732);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2Button btnHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2Button btnAbout;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.LinkLabel Log_out;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Elipse welcome;
        private Guna.UI2.WinForms.Guna2Elipse about_me;
        private Guna.UI2.WinForms.Guna2Elipse help;
        private Guna.UI2.WinForms.Guna2Elipse coffee;
        private Guna.UI2.WinForms.Guna2Elipse cake;
        private Guna.UI2.WinForms.Guna2Elipse cart;
        private System.Windows.Forms.Timer shoptimer;
        private System.Windows.Forms.Panel panel10;
        private Guna.UI2.WinForms.Guna2Button btncoffee;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Panel panel4;
    }
}