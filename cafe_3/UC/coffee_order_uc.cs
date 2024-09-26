using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_3.UC
{
    public partial class coffee_order_uc : UserControl
    {
        
        function fn = new function();
        string query;
        public decimal total { get; set; }
        public DataTable listitem { get; set; }

        decimal payback; 

        public string email { get; set; }

        public string name_user { get; set; }

        decimal amount;

        String name_product;


        public coffee_order_uc()
        {
            InitializeComponent();
            Console.WriteLine(email);
            Console.WriteLine(name_user);
            LoadData();
            
        }

        public void LoadData()
        {
            query = "select name,price,pic from items ";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            guna2DataGridView1.Columns["pic"].Visible = false;
            guna2DataGridView1.Columns["name"].DefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Regular);
            guna2DataGridView1.Columns["price"].DefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Regular);




        }


        private void order_uc_Load(object sender, EventArgs e)
        {
            
            Console.WriteLine(email);
            Console.WriteLine(name_user);
            



        }

        private void Timerslide_Tick(object sender, EventArgs e)
        {


        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

            

            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
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

                // ส่ง DataTable ไปยัง paymentForm.listitem
                payment paymentForm = new payment();
                paymentForm.total = total;
                paymentForm.listitem = dataTable;
                paymentForm.email = email;
                paymentForm.name_user = name_user;
                Console.WriteLine(total);
                Console.WriteLine(listitem);
                Console.WriteLine(email);
                
                paymentForm.Show();
            }
            catch (Exception ex)
            {
                // Log any exceptions that may occur during the process
                Console.WriteLine("An error occurred while preparing data for payment form: " + ex.Message);
                MessageBox.Show("An error occurred while preparing data for payment form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        
        
       

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try {
                
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
            try
            {
                Int64 quan = Int64.Parse(txtamount.Value.ToString());
                decimal price = decimal.Parse(txtprice.Text);
                pricelabel.Text = (quan * price).ToString() ;
            }
            catch
            {

            }
            

        }


        decimal edit_amount;

        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string cellValue_amount = guna2DataGridView2.Rows[e.RowIndex].Cells[3].Value?.ToString();
                string cellValue_payback = guna2DataGridView2.Rows[e.RowIndex].Cells[2].Value?.ToString();
                string cellValue_name = guna2DataGridView2.Rows[e.RowIndex].Cells[0].Value?.ToString();

                if (string.IsNullOrEmpty(cellValue_amount))
                {
                    amount = 0;
                }
                else
                {
                    amount = decimal.Parse(cellValue_amount);
                }

                if (string.IsNullOrEmpty(cellValue_payback))
                {
                    payback = 0;
                }
                else
                {
                    payback = decimal.Parse(cellValue_payback);
                }

                if (string.IsNullOrEmpty(cellValue_name))
                {
                    name_product = "";
                }
                else
                {
                    name_product = cellValue_name;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string myconn = "data source=AYAKI;database=cafe_final;integrated security=True";
            try
            {
                if (guna2DataGridView2.SelectedRows.Count > 0)
                {
                    // Retrieve the amount to remove from NumericUpDown
                    decimal amountToRemove = txtamount.Value; // Use Value property of NumericUpDown
                    if (amountToRemove <= 0)
                    {
                        MessageBox.Show("กรุณาระบุจำนวนที่ต้องการลบที่มากกว่า 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Get the current amount and price from the selected row
                    decimal currentAmount = decimal.Parse(guna2DataGridView2.SelectedRows[0].Cells[2].Value.ToString());
                    decimal currentPrice = decimal.Parse(guna2DataGridView2.SelectedRows[0].Cells[3].Value.ToString());

                    if (amountToRemove > currentAmount)
                    {
                        MessageBox.Show("จำนวนที่ต้องการลบมากกว่าจำนวนในตะกร้า", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Calculate new quantity and price
                    decimal newAmount = currentAmount - amountToRemove;
                    decimal newPrice = currentPrice - (currentPrice / currentAmount) * amountToRemove;

                    // Update the quantity in the database
                    query = "UPDATE items SET quantity = quantity + @payback WHERE name = @name_product";

                    using (SqlConnection conn = new SqlConnection(myconn))
                    {
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@payback", amountToRemove);
                            cmd.Parameters.AddWithValue("@name_product", name_product);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Update total amount and display
                    total -= (currentPrice / currentAmount) * amountToRemove;
                    pricelabel.Text = total.ToString();

                    // If new amount is 0, remove the row
                    if (newAmount == 0)
                    {
                        guna2DataGridView2.Rows.RemoveAt(guna2DataGridView2.SelectedRows[0].Index);
                    }
                    else
                    {
                        // Update the quantity and price in the DataGridView
                        guna2DataGridView2.SelectedRows[0].Cells[2].Value = newAmount;
                        guna2DataGridView2.SelectedRows[0].Cells[3].Value = newPrice;
                    }

                    guna2DataGridView2.ClearSelection();
                }
                else
                {
                    MessageBox.Show("กรุณาเลือกสินค้าที่ต้องการลบจากตะกร้า", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show("An error occurred while removing the item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            try
            {
                decimal totalAmount;
                if (decimal.TryParse(pricelabel.Text, out totalAmount))
                {
                    int itemId = GetItemId();
                    int currentQuantity = GetCurrentQuantity(itemId);

                    // Ensure sufficient quantity is available
                    if (txtamount.Value <= (decimal)currentQuantity)
                    {
                        int updatedQuantity = currentQuantity - (int)txtamount.Value;

                        // Update quantity in database
                        UpdateQuantity(itemId, updatedQuantity);

                        bool itemExists = false;
                        foreach (DataGridViewRow row in guna2DataGridView2.Rows)
                        {
                            // Check if the cell is not null and then compare the value
                            if (row.Cells[0]?.Value?.ToString() == txtname.Text.ToString())
                            {
                                // Item already exists, update the quantity and total amount
                                decimal existingQuantity;
                                decimal existingTotal;

                                // Check if the values are not null before parsing
                                if (decimal.TryParse(row.Cells[2]?.Value?.ToString(), out existingQuantity) &&
                                    decimal.TryParse(row.Cells[3]?.Value?.ToString(), out existingTotal))
                                {
                                    decimal newQuantity = existingQuantity + txtamount.Value;
                                    row.Cells[2].Value = newQuantity.ToString();

                                    decimal newTotal = existingTotal + totalAmount;
                                    row.Cells[3].Value = newTotal.ToString();

                                    // Update total amount and display
                                    this.total += totalAmount;
                                    pricelabel.Text = this.total.ToString();

                                    itemExists = true;
                                    break;
                                }
                                else
                                {
                                    MessageBox.Show("Error parsing existing item quantities or total amounts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return; // or handle this error case appropriately
                                }
                            }
                            guna2DataGridView2.ClearSelection();
                            txtamount.ResetText();
                            
                        }

                        if (!itemExists)
                        {
                            // Add item to cart grid view if it doesn't exist
                            int rowIndex = guna2DataGridView2.Rows.Add();
                            guna2DataGridView2.Rows[rowIndex].Cells[0].Value = txtname.Text.ToString();
                            guna2DataGridView2.Rows[rowIndex].Cells[1].Value = txtprice.Text.ToString();
                            guna2DataGridView2.Rows[rowIndex].Cells[2].Value = txtamount.Value.ToString();
                            guna2DataGridView2.Rows[rowIndex].Cells[3].Value = totalAmount.ToString();

                            // Update total amount and display
                            this.total += totalAmount;
                            pricelabel.Text = this.total.ToString();

                            guna2DataGridView2.Columns[0].DefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Regular);
                            guna2DataGridView2.Columns[1].DefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Regular);
                            guna2DataGridView2.Columns[2].DefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Regular);
                            guna2DataGridView2.Columns[3].DefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Regular);
                        }
                        guna2DataGridView2.ClearSelection();
                        txtamount.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("สินค้าหมด กำลังเติมสินค้า.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // Log the invalid string for debugging purposes
                    Console.WriteLine("Invalid price label text: " + pricelabel.Text);
                    MessageBox.Show("Price is not in a valid format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // or handle this error case appropriately
                }
            }
            catch (Exception ex)
            {
                // Log any other exceptions that may occur during parsing
                Console.WriteLine("Exception occurred while processing item addition: " + ex.Message);
                MessageBox.Show("An error occurred while processing the item addition.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // or handle this error case appropriately
            }
        }

        private int GetItemId()
        {
            query = "select id from items where name ='" + txtname.Text + "'";
            DataSet ds = fn.GetData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            }
            else
            {
                throw new Exception("Item ID not found.");
            }
        }

        private int GetCurrentQuantity(int itemId)
        {
            string query = "select quantity from items where id = " + itemId;
            DataSet ds = fn.GetData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            }
            else
            {
                throw new Exception("Quantity not found for item ID: " + itemId);
            }
        }

        private void UpdateQuantity(int itemId, int updatedQuantity)
        {
            string query = "update items set quantity = " + updatedQuantity + " where id = " + itemId;
            fn.SetData(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select name,price,pic from items where name like '%" + txtSearch.Text + "%' ";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void user_Click(object sender, EventArgs e)
        {

        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            string myconn = "data source=AYAKI;database=cafe_final;integrated security=True";
            try
            {
                using (SqlConnection conn = new SqlConnection(myconn))
                {
                    conn.Open();

                    foreach (DataGridViewRow row in guna2DataGridView2.Rows)
                    {
                        if (row.IsNewRow) continue; // Skip the new row placeholder

                        string name_product = row.Cells[0].Value?.ToString();
                        int payback = Convert.ToInt32(row.Cells[2].Value);

                        // Update the quantity in the database
                        string query = "UPDATE items SET quantity = quantity + @payback WHERE name = @name_product";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@payback", payback);
                            cmd.Parameters.AddWithValue("@name_product", name_product);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                // Clear all rows in the DataGridView
                guna2DataGridView2.Rows.Clear();
                total = 0;
                pricelabel.Text = total.ToString();
                

            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log it or display an error message)
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
