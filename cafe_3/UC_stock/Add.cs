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

namespace cafe_3.UC
{
    public partial class Add : UserControl
    {
        public int id { get; set; }
        function fn = new function();
        String query;
        
        public Add()
        {
            InitializeComponent();
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
                query = "insert into items (pic) values('"+image+"')";

                pictureshow.Image = Image.FromFile(image);
            }


            catch
            {

            }
            


        }
        
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            query = "SELECT MAX(id) FROM items";
            DataSet checkIdDataSet = fn.GetData(query);

            // Check if there are any records returned and extract the maximum id
            int maxId = 0;
            if (checkIdDataSet.Tables.Count > 0 && checkIdDataSet.Tables[0].Rows.Count > 0)
            {
                maxId = Convert.ToInt32(checkIdDataSet.Tables[0].Rows[0][0]);
            }

            // Increment the id
            int newId = maxId + 1;

            // Insert the new record
            query = "INSERT INTO items (id, name,  quantity, price, pic) VALUES ('" + newId + "', '" + txtname.Text + "','" + updownquan.Value + "', '" + txtprice.Text + "', '" + filename.Text + "')";
            fn.SetData(query);

            // Clear form fields
            ClearAll();

            // Output the new id
            Console.WriteLine(newId);

        }

        public void ClearAll()
        {
            
            txtname.Clear();
            txtprice.Clear();
            updownquan.ResetText();
            filename.ResetText();
            
        }

        private void combocategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
