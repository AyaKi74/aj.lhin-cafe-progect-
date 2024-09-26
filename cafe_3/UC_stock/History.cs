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
    public partial class History : UserControl
    {
        String query;
        function fn = new function();
        public History()
        {
            InitializeComponent();
        }


        private void History_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Refresh();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            query = "select * from order_history where email like '%" + guna2TextBox1.Text + "%'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

            if (guna2DataGridView1.Rows.Count > 0)
            {
                decimal totalPrice = 0;

                // วนลูปผ่านแต่ละแถวใน DataGridView
                foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                {
                    // ตรวจสอบว่าเซลล์ไม่ใช่เซลล์ที่เป็นแถวใหม่
                    if (!row.IsNewRow)
                    {
                        // ดึงค่าจากคอลัมน์ที่ 5 (คอลัมน์ที่ 4 ตามดัชนี 0-based) และบวกเข้ากับ totalPrice
                        decimal price;
                        if (decimal.TryParse(row.Cells[4].Value?.ToString(), out price))
                        {
                            totalPrice += price;
                        }
                    }
                }

                // แสดงผลรวมราคาทั้งหมด
                guna2TextBox2.Text = totalPrice.ToString();
            }
            else
            {
                MessageBox.Show("No data to calculate.");
            }

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                string selectedDate = guna2DateTimePicker1.Value.ToString("yyyy-MM-dd");
                string selectedMonth = guna2DateTimePicker1.Value.ToString("yyyy-MM");

                // สร้างคำสั่ง SQL เพื่อค้นหาทุกอย่างในตาราง order_his ที่มีวันที่ตรงกับที่ผู้ใช้เลือก
                string query = $"SELECT * FROM order_history WHERE CONVERT(date, order_date) = '{selectedDate}'";

                // ดึงข้อมูลจากฐานข้อมูล
                DataSet ds = fn.GetData(query);

                // ตรวจสอบว่ามีข้อมูลหรือไม่
                if (ds.Tables[0].Rows.Count > 0)
                {
                    guna2DataGridView1.DataSource = ds.Tables[0];
                    

                    decimal totalPrice = 0;

                    // วนลูปผ่านแต่ละแถวใน DataGridView
                    foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                    {
                        // ตรวจสอบว่าเซลล์ไม่ใช่เซลล์ที่เป็นแถวใหม่
                        if (!row.IsNewRow)
                        {
                            // ดึงค่าจากคอลัมน์ที่ 5 (คอลัมน์ที่ 4 ตามดัชนี 0-based) และบวกเข้ากับ totalPrice
                            decimal price;
                            if (decimal.TryParse(row.Cells[4].Value?.ToString(), out price))
                            {
                                totalPrice += price;
                            }
                        }
                    }

                    double vat = 0.07;
                    double price_with_vat;
                    // แสดงผลรวมราคาทั้งหมด
                    guna2TextBox2.Text = totalPrice.ToString();
                    price_with_vat = Convert.ToDouble(totalPrice);
                    guna2TextBox3.Text = (price_with_vat * vat).ToString();
                }
                else
                {
                    MessageBox.Show("No data found for the selected date.");
                }

                // คำนวณยอดรวมสำหรับเดือนที่เลือก
                string monthQuery = $"SELECT * FROM order_history WHERE CONVERT(date, order_date) LIKE '{selectedMonth}%'";
                DataSet monthDs = fn.GetData(monthQuery);

                if (monthDs.Tables[0].Rows.Count > 0)
                {
                    decimal monthTotalPrice = 0;

                    foreach (DataRow row in monthDs.Tables[0].Rows)
                    {
                        decimal price;
                        if (decimal.TryParse(row["price"].ToString(), out price)) // เปลี่ยน "price_column_name" เป็นชื่อคอลัมน์ราคาของคุณ
                        {
                            monthTotalPrice += price;
                        }
                    }

                    guna2TextBox4.Text = monthTotalPrice.ToString();
                }
                else
                {
                    guna2TextBox4.Text = "0";
                   
                }
            }
            catch (Exception ex)
            {
                
            }



        }
            private void guna2TextBox2_TextChanged(object sender, EventArgs e)
            {

            }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    } 
}
    

