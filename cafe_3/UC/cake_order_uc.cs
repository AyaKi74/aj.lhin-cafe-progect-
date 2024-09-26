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
    public partial class cake_order_uc : UserControl
    {
        function fn = new function();
        string query;
        
        public decimal total { get; set; }

        public cake_order_uc()
        {

            InitializeComponent();
            LoadData();
        }


        public void LoadData()
        {
            query = "select name,price,pic from items where category = 'cake'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            payment payment = new payment();
            payment.Show();
        }




        private void btnMenu_Click(object sender, EventArgs e)
        {

        }


        private void cake_order_uc_Load(object sender, EventArgs e)
        {



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        decimal amount;

        int n;
        int id;

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
                    txtpricecake.Text = price.ToString();
                }
                else
                {
                    // Parsing failed, handle the error or provide feedback to the user
                    MessageBox.Show("The value in the cell is not a valid decimal number.");
                }

                txtnamecake.Text = name;

                pictureBox1_cake.Image = Image.FromFile(pathimg);
            }
            catch
            {

            }





        }
        private void txtamount_ValueChanged(object sender, EventArgs e)
        {


        }

        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (guna2DataGridView2.Rows[e.RowIndex] != null && guna2DataGridView2.Rows[e.RowIndex].Cells[3] != null)
                {
                    amount = decimal.Parse(guna2DataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString());
                }
                else
                {
                    MessageBox.Show("กรุณาเลือกสินค้า", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log it or display an error message)
            }

        }



        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            try
            {
                decimal totalAmount;
                if (decimal.TryParse(pricelabel_cake.Text, out totalAmount))
                {
                    int itemId = GetItemId();
                    int currentQuantity = GetCurrentQuantity(itemId);

                    // Ensure sufficient quantity is available
                    if (txtamount_cake.Value <= (decimal)currentQuantity)
                    {
                        decimal updatedQuantity = currentQuantity - txtamount_cake.Value;

                        // Update quantity in database
                        UpdateQuantity(itemId, (int)updatedQuantity);

                        // Add item to cart grid view
                        int rowIndex = guna2DataGridView2.Rows.Add();
                        guna2DataGridView2.Rows[rowIndex].Cells[0].Value = txtnamecake.Text.ToString();
                        guna2DataGridView2.Rows[rowIndex].Cells[1].Value = txtpricecake.Text.ToString();
                        guna2DataGridView2.Rows[rowIndex].Cells[2].Value = txtamount_cake.Value.ToString();
                        guna2DataGridView2.Rows[rowIndex].Cells[3].Value = totalAmount.ToString();

                        // Update total amount and display
                        this.total += totalAmount;
                        pricelabel_cake.Text = this.total.ToString();
                    }
                    else
                    {
                        MessageBox.Show("สินค้าหมด กำลังเติมสินค้า.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // Log the invalid string for debugging purposes
                    Console.WriteLine("Invalid price label text: " + pricelabel_cake.Text);
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
            query = "select id from items where name ='" + txtnamecake.Text + "'";
            DataSet ds = fn.GetData(query);
            return (int)ds.Tables[0].Rows[0][0];
        }


        private int GetCurrentQuantity(int itemId)
        {
            string query = "select quantity from items where id = " + itemId;
            DataSet ds = fn.GetData(query);
            return (int)ds.Tables[0].Rows[0][0];
        }

        private void UpdateQuantity(int itemId, int updatedQuantity)
        {
            string query = "update items set quantity = " + updatedQuantity + " where id = " + itemId;
            fn.GetData(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select name,price,pic from items where name like '%" + txtSearch.Text + "%' and category = 'cake'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnRemove_cake_Click(object sender, EventArgs e)
        {

        }

        private void txtnamecake_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                string name = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string cellValue = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string pathimg = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                decimal price;

                if (decimal.TryParse(cellValue, out price))
                {
                    txtpricecake.Text = price.ToString();
                }
                else
                {
                    // Parsing failed, handle the error or provide feedback to the user
                    MessageBox.Show("The value in the cell is not a valid decimal number.");
                }

                txtnamecake.Text = name;

                pictureBox1_cake.Image = Image.FromFile(pathimg);
            }
            catch
            {

            }
        }

        private void guna2DataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
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

        private void btnAddtoCart_Click_1(object sender, EventArgs e)
        {
            try
            {
                decimal totalAmount;
                if (decimal.TryParse(pricelabel_cake.Text, out totalAmount))
                {
                    int itemId = GetItemId();
                    int currentQuantity = GetCurrentQuantity(itemId);

                    // Ensure sufficient quantity is available
                    if (txtamount_cake.Value <= (decimal)currentQuantity)
                    {
                        decimal updatedQuantity = currentQuantity - txtamount_cake.Value;

                        // Update quantity in database
                        UpdateQuantity(itemId, (int)updatedQuantity);

                        // Add item to cart grid view
                        int rowIndex = guna2DataGridView2.Rows.Add();
                        guna2DataGridView2.Rows[rowIndex].Cells[0].Value = txtnamecake.Text.ToString();
                        guna2DataGridView2.Rows[rowIndex].Cells[1].Value = txtpricecake.Text.ToString();
                        guna2DataGridView2.Rows[rowIndex].Cells[2].Value = txtamount_cake.Value.ToString();
                        guna2DataGridView2.Rows[rowIndex].Cells[3].Value = totalAmount.ToString();

                        // Update total amount and display
                        this.total += totalAmount;
                        pricelabel_cake.Text = this.total.ToString();
                    }
                    else
                    {
                        MessageBox.Show("สินค้าหมด กำลังเติมสินค้า.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // Log the invalid string for debugging purposes
                    Console.WriteLine("Invalid price label text: " + pricelabel_cake.Text);
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

        private void txtamount_cake_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(txtamount_cake.Value.ToString());
            decimal price = decimal.Parse(txtpricecake.Text);
            pricelabel_cake.Text = (quan * price).ToString();
        }

        private void btnRemove_cake_Click_1(object sender, EventArgs e)
        {
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
                pricelabel_cake.Text = total + "บาท";
            }
            else
            {
                MessageBox.Show("เพิ่มสินค้าลงในตะกร้า");
            }
        }


    }
}
