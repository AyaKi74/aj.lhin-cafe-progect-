﻿using System;
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
    public partial class admin_login : Form
    {
        public admin_login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtusername.Text == "admin" && txtpassword.Text == "admin")
            {
                stock_management sm = new stock_management();
                sm.Show();
                this.Hide();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
