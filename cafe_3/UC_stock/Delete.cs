using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace cafe_3.UC_stock
{
    public partial class Delete : UserControl
    {
        public int id { get; set; }
        function fn = new function();
        String query;
        public Delete()
        {
            InitializeComponent();
            LoadData();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

            query = "SELECT * FROM items WHERE name LIKE '%" + txtsearch.Text + "%'";
            DataSet ds = fn.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            

            
        }

        
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                {

                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                string name = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                
                txtname.Text = name;
                
            }
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (id > 0) // ตรวจสอบว่ามี ID ที่ระบุหรือไม่
            {
                query = "delete from items where id = " + id;
                fn.GetData(query);

                LoadData(); // โหลดข้อมูลใหม่หลังจากทำการลบ

                // อัปเดต ID ใหม่
                for (int i = id; i < guna2DataGridView1.Rows.Count; i++)
                {
                    query = "update items set id = " + i + " where id = " + (i + 1);
                    fn.GetData(query);
                }

                MessageBox.Show("ลบสำเร็จ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                guna2DataGridView1.Refresh(); // รีเฟรช DataGridView เพื่อให้ข้อมูลใหม่ถูกแสดงผล
            }
            else
            {
                MessageBox.Show("กรุณาเลือกข้อมูลที่ต้องการลบ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadData()
        {
            query = "select * from items";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            guna2DataGridView1.Refresh(); // รีเฟรช DataGridView เพื่อให้ข้อมูลใหม่ถูกแสดงผล
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
