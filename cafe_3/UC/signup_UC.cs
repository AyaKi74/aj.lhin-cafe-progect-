using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_3.UC
{
    
    public partial class signup_UC : UserControl
    {
        function fn = new function();
        String query;
        public signup_UC()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            String name = txtname.Text;
            String username = txtusername.Text;
            String password = txtpassword.Text;
            String email = txtemail.Text;
            String telephone = txttel.Text;

           
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password)
      || String.IsNullOrEmpty(telephone))
            {
                MessageBox.Show("กรุณากรอกให้ครบทุกช่อง ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Parameterized query example (assuming fn_1 provides parameterized query functionality)
                query = "select username,email,telephone from users where username = '" + username + "' or email = '"+email+"' or telephone = '"+telephone+"'";
                DataSet check = fn.GetData(query);
                if (check.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("พบผู้ใช้ Username นี้แล้ว กรุณาติดต่อพนักงาน", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Insert using parameterized query (similar to username check)
                    query = "insert into users (username, password, name, email, telephone) values ('" + username + "','" + password + "' ,'" + name + "','" + email + "','"+telephone+"')";
                    fn.SetData(query);
                }
            }

            
            
        }
    }
}
