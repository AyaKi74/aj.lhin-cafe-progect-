using cafe_3.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_3
{
    public partial class dashboard : Form
    {
        bool sidebarexpan;
        public string email { get; set; }
        public string name_user { get; set; }
        


        payment pay = new payment();
        public dashboard()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(sidebarexpan)
            {
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarexpan = false; 
                    timer1.Stop();

                }
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarexpan = true;
                    timer1.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            welcome_uc welcome = new welcome_uc();
            panel1.Controls.Add(welcome);
            user.Text = "คุณ" + " " + name_user;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            welcome_uc welcome = new welcome_uc();
            panel1.Controls.Add(welcome);
            welcome.BringToFront();
            
            
        }

        

        private void btnHelp_Click(object sender, EventArgs e)
        {
            help_uc help = new help_uc();
            panel1.Controls.Add(help);
            help.BringToFront();
            
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            about_me_uc about = new about_me_uc();
            panel1.Controls.Add(about);
            about.BringToFront();
            
            
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void Log_out_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login fm = new login();
            fm.Show();
            this.Hide();
        }

        private void shoptimer_Tick(object sender, EventArgs e)
        {
           
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
           

        }

        private void btncoffee_Click(object sender, EventArgs e)
        {
            coffee_order_uc co = new coffee_order_uc();
            co.email = email;
            co.name_user = name_user;
            panel1.Controls.Add(co);
            co.BringToFront();
            payment Payment = new payment();
            Payment.email = email;
            Payment.name_user = name_user;
            
        }

        private void btncake_Click(object sender, EventArgs e)
        {
           
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
