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
    public partial class login : Form
    {
        
        public string email { get; set; }
        public string name_user { get; set; }
        String find_username;
        String find_password;
        String find_email;
        String find_name;
        function fn = new function();
        public login()
        {
            InitializeComponent();
        }

        private void signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup_form sf = new Signup_form();
            sf.Show();
        }


        private void btn_login_Click(object sender, EventArgs e)
        {

            find_username = "select username from users where username = '" + txt_username.Text + "'";
            DataSet username = fn.GetData(find_username);
            find_password = "select password from users where password = '" + txt_password.Text + "'";
            DataSet password = fn.GetData(find_password);
            find_email = "select email from users where username = '" + txt_username.Text + "'";
            DataSet user_email = fn.GetData(find_email) ;
            find_name = "select name from users where username = '" + txt_username.Text + "'";
            DataSet user_name = fn.GetData(find_name);
            if ((username.Tables[0].Rows.Count == 1) && (password.Tables[0].Rows.Count == 1 ))
            {
                name_user = user_name.Tables[0].Rows[0]["name"].ToString();
                email = user_email.Tables[0].Rows[0]["email"].ToString();

                dashboard ds = new dashboard();
                
                ds.name_user = name_user;
                ds.email = email;
                
                ds.Show();
                this.Hide();

                
                

                coffee_order_uc co = new coffee_order_uc();
                co.email = email;
                co.name_user = name_user;
                


                
                
                
                

                











            }
            
            else if (txt_username.Text == "" && txt_password.Text == "")
            {
                dashboard ds = new dashboard();
                ds.name_user = "UnKnown";
                ds.email = "UnKnown";
                ds.Show();
                this.Hide();

                coffee_order_uc co = new coffee_order_uc();
                co.email = "UnKnown";
                co.name_user = "Unknown";
            }

            else if (password.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("รหัสผ่านผิด", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgetpassword fp = new forgetpassword();
            fp.Show();

        }

        private void btnadmin_DoubleClick(object sender, EventArgs e)
        {
            admin_login al = new admin_login();
            al.Show();
            
            
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
