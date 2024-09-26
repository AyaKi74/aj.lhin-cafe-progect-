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
    public partial class Coffee_order : Form
    {
        function fn = new function();
        string query;
        public decimal total { get; set; }
        public DataTable listitem { get; set; }

        public string email { get; set; }

        public string name_user { get; set; }



        public Coffee_order()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select name,price,pic from items where name like '%" + txtSearch.Text + "%' and category = 'coffee'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        public void LoadData()
        {
            query = "select name,price,pic from items ";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // สร้าง DataTable เพื่อเก็บข้อมูลจาก guna2DataGridView2
                DataTable dataTable = new DataTable();

                // เพิ่มคอลัมน์ให้กับ DataTable โดยใช้ชื่อเดียวกับคอลัมน์ใน guna2DataGridView2
                foreach (DataGridViewColumn column in guna2DataGridView2.Columns)
                {
                    dataTable.Columns.Add(column.HeaderText, typeof(string));
                }

                // เพิ่มข้อมูลจาก guna2DataGridView2 เข้าไปใน DataTable
                foreach (DataGridViewRow row in guna2DataGridView2.Rows)
                {
                    DataRow dataRow = dataTable.NewRow();
                    for (int i = 0; i < guna2DataGridView2.Columns.Count; i++)
                    {
                        if (row.Cells[i].Value != null)  // ตรวจสอบว่าค่าในเซลล์ไม่เป็น null ก่อนที่จะใช้งาน
                        {
                            dataRow[i] = row.Cells[i].Value.ToString();
                        }
                    }
                    dataTable.Rows.Add(dataRow);
                }

                
               
                DateTime order_DateTime = DateTime.Now;
                // ส่ง DataTable ไปยัง paymentForm.listitem
                payment paymentForm = new payment();
                paymentForm.total = total;
                paymentForm.listitem = dataTable;
                

                Console.WriteLine(total);
                Console.WriteLine(listitem);

            
                

                paymentForm.Show();
            }
            catch (Exception ex)
            {
                // จัดการข้อผิดพลาด
                Console.WriteLine("เกิดข้อผิดพลาด: " + ex.Message);
            }

            

        }

        decimal amount;
        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                amount = decimal.Parse(guna2DataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString());


            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log it or display an error message)
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                string name = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string cellValue = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string pathimg = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                decimal price;

                if (decimal.TryParse(cellValue, out price))
                {
                    txtprice.Text = price.ToString();
                }
                else
                {
                    // Parsing failed, handle the error or provide feedback to the user
                    MessageBox.Show("The value in the cell is not a valid decimal number.");
                }

                txtname.Text = name;

                pictureBox1.Image = Image.FromFile(pathimg);
            }
            catch
            {

            }
        }

        private void txtamount_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(txtamount.Value.ToString());
            decimal price = decimal.Parse(txtprice.Text);
            pricelabel.Text = (quan * price).ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            decimal totalAmount;
            try
            {
                guna2DataGridView2.Rows.RemoveAt(this.guna2DataGridView2.SelectedRows[0].Index);

            }
            catch
            {


            }

            if (total > 0)
            {
                total = total - amount;
                pricelabel.Text = total + "บาท";
            }
            else
            {
                MessageBox.Show("เพิ่มสินค้าลงในตะกร้า");
            }

            
        }




            private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected row index
                int selectedRowIndex = guna2DataGridView2.SelectedRows[0].Index;

                // Get item details from the selected row
                string itemName = guna2DataGridView2.Rows[selectedRowIndex].Cells[0].Value.ToString();
                decimal itemPrice = Convert.ToDecimal(guna2DataGridView2.Rows[selectedRowIndex].Cells[1].Value);
                decimal itemQuantity = Convert.ToDecimal(guna2DataGridView2.Rows[selectedRowIndex].Cells[2].Value);
                decimal itemTotalAmount = Convert.ToDecimal(guna2DataGridView2.Rows[selectedRowIndex].Cells[3].Value);

                // Remove the selected row
                guna2DataGridView2.Rows.RemoveAt(selectedRowIndex);

                // Update total amount
                this.total -= itemTotalAmount;
                pricelabel.Text = this.total > 0 ? this.total + " บาท" : "0 บาท";

                // Update the quantity back to the database
                int itemId = GetItemIdByName(itemName); // Get the item ID using item name
                int currentQuantity = GetCurrentQuantity(itemId);
                int updatedQuantity = currentQuantity + (int)itemQuantity;

                // Update quantity in database
                UpdateQuantity(itemId, updatedQuantity);

                // Verify update (optional debugging)
                int newQuantity = GetCurrentQuantity(itemId);
                txtamount.ResetText();
                Console.WriteLine("Updated quantity for item ID " + itemId + ": " + newQuantity);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while removing the item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Exception occurred while removing item: " + ex.Message);
            }
        }

        private int GetItemIdByName(string itemName)
        {
            query = "select id from items where name ='" + itemName + "'";
            DataSet ds = fn.GetData(query);
            return (int)ds.Tables[0].Rows[0][0];
        }

        //private int GetItemIdByName(string itemName)
        //{
        //    string query = "select id from items where name ='" + itemName + "'";
        //    DataSet ds = fn.GetData(query);
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        return (int)ds.Tables[0].Rows[0][0];
        //    }
        //    else
        //    {
        //        throw new Exception("Item not found in database.");
        //    }
        //}

        private int GetCurrentQuantity(int itemId)
        {
            string query = "select quantity from items where id = " + itemId;
            DataSet ds = fn.GetData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return (int)ds.Tables[0].Rows[0][0];
            }
            else
            {
                throw new Exception("Item not found in database.");
            }
        }

        private void UpdateQuantity(int itemId, int updatedQuantity)
        {
            string query = "update items set quantity = " + updatedQuantity + " where id = " + itemId;
            fn.SetData(query); // Assuming SetData is used for executing update queries
        }

        private int GetItemId()
        {
            query = "select id from items where name ='" + txtname.Text + "'";
            DataSet ds = fn.GetData(query);
            return (int)ds.Tables[0].Rows[0][0];
        }


        //private int GetCurrentQuantity(int itemId)
        //{
        //    string query = "select quantity from items where id = " + itemId;
        //    DataSet ds = fn.GetData(query);
        //    return (int)ds.Tables[0].Rows[0][0];
        //}

        //private void UpdateQuantity(int itemId, int updatedQuantity)
        //{
        //    string query = "update items set quantity = " + updatedQuantity + " where id = " + itemId;
        //    fn.GetData(query);
        //}

    }
}
