using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_3.UC_stock
{
    public partial class Edit : UserControl
    {
        function fn = new function();
        String query;
        protected int n = 0;
        public Edit()
        {
            InitializeComponent();
            
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            query = "select id,name,quantity,price,pic from items where name like '%"+txtsearch.Text+"%' ";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        int id;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // Check if a valid row is clicked
                {
                    id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    string name = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    

                    // Check if quantity is a valid integer
                    int quantity;
                    if (int.TryParse(guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), out quantity))
                    {
                        // Quantity is a valid integer, proceed
                        decimal price;
                        if (decimal.TryParse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(), out price))
                        {
                            // Price is a valid decimal, proceed
                            string img = guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                            
                            txtname.Text = name;
                            txtprice.Text = price.ToString();
                            updownquan.Value = quantity;
                            pictureBox1.Image = Image.FromFile(img);
                        }
                        else
                        {
                            MessageBox.Show("Price is not in correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Quantity is not in correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void LoadData()
        {
            query = "select * from items";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            query = "update items set name = '" + txtname.Text + "',  price = '" + txtprice.Text + "',quantity = '" + updownquan.Value + "' where id = '"+id+"'";
            fn.GetData(query);
            LoadData();
            MessageBox.Show("แก้ไขสำเร็จ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            guna2DataGridView1.Refresh();
        }

        private void btnchoose_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    filename.Text = open.FileName;
                }
                String image = filename.Text;
                //Bitmap bmp = new Bitmap(image);
                //FileStream fs = new FileStream(image, FileMode.Open, FileAccess.Read);
                //byte[] bimage = new byte[fs.Length];
                //fs.Read(bimage, 0, Convert.ToInt32(fs.Length));
                //fs.Close();
                query = "update items set pic = '"+image+"' where id = '"+id+"'";
                fn.GetData(query);
                pictureBox1.Image = Image.FromFile(image);
                LoadData();
            }


            catch
            {

            }
        }
    }
}
