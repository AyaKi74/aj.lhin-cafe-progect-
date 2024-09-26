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
    
    public partial class stock_management : Form
    {
        bool sidebarexpan;
        public stock_management()
        {
            InitializeComponent();
        }

        private void stock_management_Load(object sender, EventArgs e)
        {
            
            add1.Visible = false;
            edit1.Visible = false;
            delete1.Visible = false;
            history1.Visible = false;
        }

        private void timersidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarexpan)
            {
                sidebar_stock.Width -= 10;
                if (sidebar_stock.Width == sidebar_stock.MinimumSize.Width)
                {
                    sidebarexpan = false;
                    timersidebar.Stop();

                }
            }
            else
            {
                sidebar_stock.Width += 10;
                if (sidebar_stock.Width == sidebar_stock.MaximumSize.Width)
                {
                    sidebarexpan = true;
                    timersidebar.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timersidebar.Start();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            add1.Refresh();
            add1.Visible = true;
            welcome_to_stock1.Visible = false;
            edit1.Visible = false;
            delete1.Visible = false;
            history1.Visible = false;
            stock_management sm = new stock_management();
            sm.Refresh();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            add1.Refresh();
            edit1.Refresh();
            delete1.Refresh();
            history1.Refresh();
            add1.Visible = false;
            welcome_to_stock1.Visible = true;
            edit1.Visible = false;
            delete1.Visible = false;
            history1.Visible = false;
            stock_management sm = new stock_management();
            sm.Refresh();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            edit1.Refresh();
            add1.Visible = false;
            welcome_to_stock1.Visible = false;
            edit1.Visible = true;
            delete1.Visible = false;
            history1.Visible = false;
            edit1.LoadData();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            delete1.Refresh();
            add1.Visible = false;
            welcome_to_stock1.Visible = false;
            edit1.Visible = false;
            delete1.Visible = true;
            history1.Visible = false;
            delete1.LoadData();
        }

        private void Log_out_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            history1.Refresh();
            add1.Visible = false;
            welcome_to_stock1.Visible = false;
            edit1.Visible = false;
            delete1.Visible = false;
            history1.Visible = true;
        }
    }
}
