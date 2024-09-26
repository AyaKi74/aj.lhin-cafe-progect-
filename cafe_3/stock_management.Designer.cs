
namespace cafe_3
{
    partial class stock_management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stock_management));
            this.sidebar_stock = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnShop = new Guna.UI2.WinForms.Guna2Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnHelp = new Guna.UI2.WinForms.Guna2Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAbout = new Guna.UI2.WinForms.Guna2Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Log_out = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.history1 = new cafe_3.UC_stock.History();
            this.delete1 = new cafe_3.UC_stock.Delete();
            this.edit1 = new cafe_3.UC_stock.Edit();
            this.add1 = new cafe_3.UC.Add();
            this.welcome_to_stock1 = new cafe_3.UC_stock.welcome_to_stock();
            this.ADD_UC = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.welcome = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timersidebar = new System.Windows.Forms.Timer(this.components);
            this.edit_uc = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.delete_uc = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.His_UC = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.sidebar_stock.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar_stock
            // 
            this.sidebar_stock.BackColor = System.Drawing.Color.Maroon;
            this.sidebar_stock.Controls.Add(this.panel2);
            this.sidebar_stock.Controls.Add(this.panel3);
            this.sidebar_stock.Controls.Add(this.panel4);
            this.sidebar_stock.Controls.Add(this.panel5);
            this.sidebar_stock.Controls.Add(this.panel6);
            this.sidebar_stock.Controls.Add(this.panel7);
            this.sidebar_stock.Controls.Add(this.panel8);
            this.sidebar_stock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sidebar_stock.Location = new System.Drawing.Point(2, 2);
            this.sidebar_stock.MaximumSize = new System.Drawing.Size(236, 720);
            this.sidebar_stock.MinimumSize = new System.Drawing.Size(75, 720);
            this.sidebar_stock.Name = "sidebar_stock";
            this.sidebar_stock.Size = new System.Drawing.Size(75, 720);
            this.sidebar_stock.TabIndex = 2;
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
            this.panel3.Size = new System.Drawing.Size(228, 95);
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
            this.btnHome.Location = new System.Drawing.Point(22, 22);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(186, 45);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnShop);
            this.panel4.Location = new System.Drawing.Point(3, 205);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(228, 95);
            this.panel4.TabIndex = 2;
            // 
            // btnShop
            // 
            this.btnShop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShop.FillColor = System.Drawing.Color.Transparent;
            this.btnShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnShop.ForeColor = System.Drawing.Color.White;
            this.btnShop.Image = ((System.Drawing.Image)(resources.GetObject("btnShop.Image")));
            this.btnShop.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnShop.ImageSize = new System.Drawing.Size(30, 30);
            this.btnShop.Location = new System.Drawing.Point(22, 22);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(186, 45);
            this.btnShop.TabIndex = 0;
            this.btnShop.Text = "Add";
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnHelp);
            this.panel5.Location = new System.Drawing.Point(3, 306);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(228, 95);
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
            this.btnHelp.Location = new System.Drawing.Point(22, 22);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(186, 45);
            this.btnHelp.TabIndex = 0;
            this.btnHelp.Text = "Edit";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnAbout);
            this.panel6.Location = new System.Drawing.Point(3, 407);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(228, 95);
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
            this.btnAbout.Location = new System.Drawing.Point(22, 22);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(186, 45);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "Delete";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.guna2Button1);
            this.panel7.Location = new System.Drawing.Point(3, 508);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(228, 95);
            this.panel7.TabIndex = 4;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(22, 22);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(186, 45);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "income";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.Log_out);
            this.panel8.Location = new System.Drawing.Point(3, 609);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(233, 111);
            this.panel8.TabIndex = 4;
            // 
            // Log_out
            // 
            this.Log_out.AutoSize = true;
            this.Log_out.Font = new System.Drawing.Font("DB Helvethaica X 55 Regular", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_out.LinkColor = System.Drawing.Color.White;
            this.Log_out.Location = new System.Drawing.Point(78, 24);
            this.Log_out.Name = "Log_out";
            this.Log_out.Size = new System.Drawing.Size(150, 58);
            this.Log_out.TabIndex = 0;
            this.Log_out.TabStop = true;
            this.Log_out.Text = "Log out ";
            this.Log_out.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Log_out_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.history1);
            this.panel1.Controls.Add(this.delete1);
            this.panel1.Controls.Add(this.edit1);
            this.panel1.Controls.Add(this.add1);
            this.panel1.Controls.Add(this.welcome_to_stock1);
            this.panel1.Location = new System.Drawing.Point(239, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 720);
            this.panel1.TabIndex = 3;
            // 
            // history1
            // 
            this.history1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(216)))), ((int)(((byte)(198)))));
            this.history1.Location = new System.Drawing.Point(0, -3);
            this.history1.Name = "history1";
            this.history1.Size = new System.Drawing.Size(1280, 720);
            this.history1.TabIndex = 4;
            // 
            // delete1
            // 
            this.delete1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(216)))), ((int)(((byte)(198)))));
            this.delete1.id = 0;
            this.delete1.Location = new System.Drawing.Point(0, 0);
            this.delete1.Name = "delete1";
            this.delete1.Size = new System.Drawing.Size(1280, 720);
            this.delete1.TabIndex = 3;
            // 
            // edit1
            // 
            this.edit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(216)))), ((int)(((byte)(198)))));
            this.edit1.Location = new System.Drawing.Point(3, 3);
            this.edit1.Name = "edit1";
            this.edit1.Size = new System.Drawing.Size(1280, 720);
            this.edit1.TabIndex = 2;
            // 
            // add1
            // 
            this.add1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(216)))), ((int)(((byte)(198)))));
            this.add1.id = 0;
            this.add1.Location = new System.Drawing.Point(3, 3);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(1280, 720);
            this.add1.TabIndex = 1;
            // 
            // welcome_to_stock1
            // 
            this.welcome_to_stock1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("welcome_to_stock1.BackgroundImage")));
            this.welcome_to_stock1.Location = new System.Drawing.Point(0, 0);
            this.welcome_to_stock1.Name = "welcome_to_stock1";
            this.welcome_to_stock1.Size = new System.Drawing.Size(1280, 720);
            this.welcome_to_stock1.TabIndex = 0;
            // 
            // ADD_UC
            // 
            this.ADD_UC.TargetControl = this.panel1;
            // 
            // welcome
            // 
            this.welcome.TargetControl = this.panel1;
            // 
            // timersidebar
            // 
            this.timersidebar.Interval = 10;
            this.timersidebar.Tick += new System.EventHandler(this.timersidebar_Tick);
            // 
            // edit_uc
            // 
            this.edit_uc.TargetControl = this.panel1;
            // 
            // delete_uc
            // 
            this.delete_uc.TargetControl = this.panel1;
            // 
            // stock_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(216)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(1521, 724);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidebar_stock);
            this.Name = "stock_management";
            this.Text = "stock_management";
            this.Load += new System.EventHandler(this.stock_management_Load);
            this.sidebar_stock.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar_stock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btnShop;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2Button btnHelp;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2Button btnAbout;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.LinkLabel Log_out;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse ADD_UC;
        private Guna.UI2.WinForms.Guna2Elipse welcome;
        private System.Windows.Forms.Timer timersidebar;
        private UC_stock.welcome_to_stock welcome_to_stock1;
        private UC.Add add1;
        private System.Windows.Forms.Panel panel7;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Elipse edit_uc;
        private UC_stock.Edit edit1;
        private Guna.UI2.WinForms.Guna2Elipse delete_uc;
        private UC_stock.Delete delete1;
        private Guna.UI2.WinForms.Guna2Elipse His_UC;
        private UC_stock.History history1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}