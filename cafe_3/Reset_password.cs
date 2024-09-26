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
    public partial class Reset_password : Form
    {
        public string email { get; set; }
        String query;
        function fn = new function();
        public Reset_password()
        {
            InitializeComponent();
        }

        private void Reset_password_Load(object sender, EventArgs e)
        {
            
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if((txtpassword1.Text) == (txtpassword2.Text))
            {
                query = "update users set password = '" + txtpassword1.Text + "' where email = '" + email +"'";
                fn.GetData(query);
                MessageBox.Show("แก้ไขสำเร็จ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("กรุณาใส่รหัสให้ตรงกัน", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
