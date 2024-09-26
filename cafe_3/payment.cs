using cafe_3.UC;
using QRCoder;
using Saladpuk.PromptPay.Contracts;
using Saladpuk.PromptPay.Facades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using DGVPrinterHelper;
using System.Drawing.Printing;
using System.IO;

namespace cafe_3
{
    public partial class payment : Form
    {
        function fn = new function();

        public DataTable listitem { get; set; }

        
        public decimal total { get; set; }
        public string email { get; set; }
        public string name_user { get; set; }

        String query;

        double total_with_discount;

        double total_dis;

        double discount = 0.1;
        double vat = 0.07;
        double total_with_vat; 



        public payment()
        {
            InitializeComponent();




        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void payment_Load(object sender, EventArgs e)
        {
            name_of_user.Text = "คุณ" + " " + name_user;
           
            guna2DataGridView1.DataSource = listitem;
            Console.WriteLine(total);
            Console.WriteLine(listitem);
            Console.WriteLine(name_user);
            Console.WriteLine(email);
            guna2DataGridView1.Columns[0].DefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Regular);
            guna2DataGridView1.Columns[1].DefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Regular);
            guna2DataGridView1.Columns[2].DefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Regular);
            guna2DataGridView1.Columns[3].DefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Regular);


            if (email != "UnKnown")
            {
                
                total_dis = Convert.ToDouble(total);
                total_with_vat = total_dis * vat;
                total_with_discount = total_dis * discount;
                total_dis = total_dis - total_with_discount;
                
                double qr_price = total_dis;
                IPromptPayBuilder builder = PPay.DynamicQR;

                string qr = PPay.DynamicQR.MobileNumber("0834477387").Amount(qr_price).CreateCreditTransferQrCode();
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(qr, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(10);

                // แสดงรูปภาพใน PictureBox
                pictureBox1.Image = qrCodeImage;

                totalprice.Text = total_dis.ToString();
                label_discount.Text = total_with_discount.ToString();
            }
            else
            {
                total_dis = Convert.ToDouble(total);
                double qr_price = total_dis;
                total_with_vat = total_dis * vat;
                IPromptPayBuilder builder = PPay.DynamicQR;

                string qr = PPay.DynamicQR.MobileNumber("0834477387").Amount(qr_price).CreateCreditTransferQrCode();
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(qr, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(10);

                // แสดงรูปภาพใน PictureBox
                pictureBox1.Image = qrCodeImage;

                totalprice.Text = total_dis.ToString();
                label_discount.Text = total_with_discount.ToString();
            }

            

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save PDF File";
                saveFileDialog.FileName = "receipt.pdf"; // ชื่อไฟล์เริ่มต้น

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string generatedFilePath = saveFileDialog.FileName;

                    // เรียกใช้ฟังก์ชันสร้าง PDF ขึ้นอยู่กับผู้ใช้
                    if (name_user != "UnKnown")
                    {
                        GeneratePDFReceipt_with_user(generatedFilePath);
                    }
                    else
                    {
                        GeneratePDFReceipt_no_user(generatedFilePath);
                    }

                    // เปิดไฟล์ PDF ที่สร้างขึ้น
                    if (!string.IsNullOrEmpty(generatedFilePath))
                    {
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                        {
                            FileName = generatedFilePath,
                            UseShellExecute = true
                        });
                    }

                    // บันทึกข้อมูลลงฐานข้อมูล
                    List<string> Allitem = new List<string>();
                    List<int> Allquantity = new List<int>();
                    List<decimal> Allprice = new List<decimal>();

                    if (guna2DataGridView1.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                        {
                            if (row.Cells[0].Value != null && !string.IsNullOrEmpty(row.Cells[0].Value.ToString()))
                            {
                                Allitem.Add(row.Cells[0].Value.ToString());
                            }

                            if (row.Cells.Count > 1 && row.Cells[2].Value != null && !string.IsNullOrEmpty(row.Cells[2].Value.ToString()))
                            {
                                int quantity;
                                if (int.TryParse(row.Cells[2].Value.ToString(), out quantity))
                                {
                                    Allquantity.Add(quantity);
                                }
                            }

                            if (row.Cells.Count > 2 && row.Cells[3].Value != null && !string.IsNullOrEmpty(row.Cells[3].Value.ToString()))
                            {
                                decimal price;
                                if (decimal.TryParse(row.Cells[3].Value.ToString(), out price))
                                {
                                    Allprice.Add(price);
                                }
                            }
                        }
                    }

                    DateTime currenttime = DateTime.Now;

                    string connectionString = "data source = (localdb)\\ProjectModels; database = cafe_final; integrated security = True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string itemsJson = JsonConvert.SerializeObject(Allitem);
                        string quantitiesJson = JsonConvert.SerializeObject(Allquantity);

                        double totalPrice = Allprice.Sum(price => Convert.ToDouble(price));
                        double totalPriceWithDiscount = totalPrice - total_with_discount;
                        decimal finalPrice = Convert.ToDecimal(totalPriceWithDiscount);

                        string query = "INSERT INTO order_history (email, name_user, name_item, quantity, price, order_date) VALUES (@Email, @NameUser, @Items, @Quantities, @Price, @OrderDate)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@NameUser", name_user);
                            command.Parameters.AddWithValue("@Items", itemsJson);
                            command.Parameters.AddWithValue("@Quantities", quantitiesJson);
                            command.Parameters.AddWithValue("@Price", finalPrice);
                            command.Parameters.AddWithValue("@OrderDate", currenttime);

                            command.ExecuteNonQuery();
                        }
                    }

                    this.Close();
                    Console.WriteLine("Data inserted successfully.");
                }
                else
                {
                    // ผู้ใช้ยกเลิกการเลือกไฟล์
                    MessageBox.Show("Save operation was cancelled.");
                }
            }
        }

        private void GeneratePDFReceipt_with_user(string filePath)
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "Lalate Coffee สาขาหลังมอ (1234)";
            string nowDateTime = DateTime.Now.ToString("วันที่: dd/MM/yyyy HH:mm:ss");

            printer.SubTitle = "สั่งโดย : " + name_user + "\n" + nowDateTime + "\n" + new string('-', 40);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.SubTitleFont = new Font("Arial", 20, FontStyle.Regular);

            printer.PageNumbers = false;
            printer.PageNumbersInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;

            printer.Footer = new string('-', 40) + "\n" +
                             "รวม = " + total + "\n" +
                             "VAT 7% = " + total_with_vat + "\n" +
                             "ส่วนลด = " + total_with_discount + "\n" +
                             "รวมทั้งสิ้น : " + totalprice.Text + "\n" +
                             new string('-', 40) + "\n" +
                             "ออกใบเสร็จโดย Admin: Phiraphob";
            printer.FooterSpacing = -15;
            printer.FooterAlignment = StringAlignment.Near;
            printer.FooterFont = new Font("Arial", 18, FontStyle.Regular);

            printer.PrintDataGridView(guna2DataGridView1);
            SavePDF(filePath);
        }

        private void GeneratePDFReceipt_no_user(string filePath)
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "Lalate Coffee ";
            string nowDateTime = DateTime.Now.ToString("วันที่: dd/MM/yyyy HH:mm:ss");

            printer.SubTitle = "สั่งโดย : " + name_user + "\n" + nowDateTime + "\n" + new string('-', 40) + "\n" +
                               "หลังมอ ต.ศิลา อ.เมือง จ.ขอนแก่น Tell: 0834477387" + "\n" + "Tax ID : 12-345678" + "\n";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.SubTitleFont = new Font("Arial", 20, FontStyle.Regular);

            printer.PageNumbers = false;
            printer.PageNumbersInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;

            printer.Footer = new string('-', 40) + "\n" +
                             "รวม = " + total + "\n" +
                             "VAT 7% = " + total_with_vat + "\n" +
                             "ส่วนลด = " + total_with_discount + "\n" +
                             "รวมทั้งสิ้น : " + totalprice.Text + "\n" +
                             new string('-', 40) + "\n" +
                             "ออกใบเสร็จโดย Admin: Phiraphob";
            printer.FooterSpacing = 15;
            printer.FooterAlignment = StringAlignment.Near;
            printer.FooterFont = new Font("Arial", 18, FontStyle.Regular);

            printer.PrintDataGridView(guna2DataGridView1);
            SavePDF(filePath);
        }

        private void SavePDF(string filePath)
        {
            // ใช้ PdfSharp หรือไลบรารีอื่น ๆ เพื่อบันทึก PDF ตามเส้นทางที่กำหนด
            // เพิ่มการดำเนินการเพื่อบันทึกไฟล์ PDF ที่นี่
        }




        private void totalprice_Click(object sender, EventArgs e)
        {

        }


        //private void GeneratePDFReceipt_with_user()
        //{
        //    try
        //    {
        //        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        //        string fileName = "Receipt.pdf";
        //        string filePath = Path.Combine(desktopPath, fileName);

        //        // Check if the file already exists
        //        int count = 1;
        //        while (File.Exists(filePath))
        //        {
        //            fileName = $"Receipt_{count}.pdf";
        //            filePath = Path.Combine(desktopPath, fileName);
        //            count++;
        //        }

        //        // Create PrintDocument
        //        PrintDocument pd = new PrintDocument();
        //        pd.PrintPage += new PrintPageEventHandler(GeneratePDFContent_with_user);

        //        // Set printer settings
        //        pd.PrinterSettings.PrintToFile = true;
        //        pd.PrinterSettings.PrintFileName = filePath;

        //        // Print document
        //        pd.Print();

        //        MessageBox.Show($"Receipt has been generated and saved to Desktop as {fileName}", "PDF Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error generating PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void GeneratePDFContent_with_user(object sender, PrintPageEventArgs e)
        //{
        //    using (Font font = new Font("Arial", 12))
        //    {
        //        int startX = 10;
        //        int startY = 10;
        //        int offsetY = 20;

        //        // Drawing title
        //        e.Graphics.DrawString("Lalate Coffee สาขาหลังมอ (1234)", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, startX, startY);
        //        startY += offsetY;

        //        // Drawing subtitle
        //        string nowDateTime = DateTime.Now.ToString("วันที่: dd/MM/yyyy HH:mm:ss");
        //        e.Graphics.DrawString("สั่งโดย : " + name_user + "\n" + nowDateTime, font, Brushes.Black, startX, startY);
        //        startY += 2 * offsetY;

        //        // Drawing header
        //        e.Graphics.DrawString("Address : หลังมอ ต.ศิลา อ.เมือง จ.ขอนแก่น Tell: 0834477387", font, Brushes.Black, startX, startY);
        //        startY += offsetY;
        //        e.Graphics.DrawString("Tax ID : 12-345678", font, Brushes.Black, startX, startY);
        //        startY += offsetY;

        //        // Drawing date and user name
        //        e.Graphics.DrawString("Date: " + DateTime.Now.ToString("dd/MM/yyyy"), font, Brushes.Black, startX, startY);
        //        startY += offsetY;
        //        e.Graphics.DrawString("User Name: " + name_user, font, Brushes.Black, startX, startY);
        //        startY += 2 * offsetY;

        //        // Drawing column headers
        //        e.Graphics.DrawString("Name", font, Brushes.Black, startX, startY);
        //        e.Graphics.DrawString("Amount", font, Brushes.Black, startX + 200, startY);
        //        e.Graphics.DrawString("Price", font, Brushes.Black, startX + 400, startY);
        //        startY += offsetY;

        //        // Drawing data from DataGridView
        //        int tableX = startX;
        //        int tableY = startY;
        //        int cellWidth = 200;
        //        int cellHeight = 20;

        //        for (int i = 0; i < guna2DataGridView1.Rows.Count; i++)
        //        {
        //            for (int j = 0; j < guna2DataGridView1.Columns.Count; j++)
        //            {
        //                var cellValue = guna2DataGridView1.Rows[i].Cells[j].Value;
        //                string cellText = cellValue != null ? cellValue.ToString() : string.Empty;
        //                e.Graphics.DrawString(cellText, font, Brushes.Black, tableX + j * cellWidth, tableY + i * cellHeight);
        //            }
        //        }

        //        tableY += guna2DataGridView1.Rows.Count * cellHeight;

        //        // Drawing discount
        //        e.Graphics.DrawString("รวมทั้งสิ้น : " + totalprice.Text, font, Brushes.Black, startX, tableY + offsetY);
        //        e.Graphics.DrawString("รวมส่วนลด 10% : " + total_with_discount, font, Brushes.Black, startX, tableY + 2 * offsetY);
        //        e.Graphics.DrawString("VAT 7% : " + total_with_vat, font, Brushes.Black, startX, tableY + 3 * offsetY);
        //        e.Graphics.DrawString("ออกใบเสร็จโดย Admin: Phiraphob", font, Brushes.Black, startX, tableY + 4 * offsetY);
        //    }
        //}

        //private void GeneratePDFReceipt_no_user()
        //{
        //    try
        //    {
        //        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        //        string fileName = "Receipt.pdf";
        //        string filePath = Path.Combine(desktopPath, fileName);

        //        // Check if the file already exists
        //        int count = 1;
        //        while (File.Exists(filePath))
        //        {
        //            fileName = $"Receipt_{count}.pdf";
        //            filePath = Path.Combine(desktopPath, fileName);
        //            count++;
        //        }

        //        // Create PrintDocument
        //        PrintDocument pd = new PrintDocument();
        //        pd.PrintPage += new PrintPageEventHandler(GeneratePDFContent_no_user);

        //        // Set printer settings
        //        pd.PrinterSettings.PrintToFile = true;
        //        pd.PrinterSettings.PrintFileName = filePath;

        //        // Print document
        //        pd.Print();

        //        MessageBox.Show($"Receipt has been generated and saved to Desktop as {fileName}", "PDF Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error generating PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void GeneratePDFContent_no_user(object sender, PrintPageEventArgs e)
        //{
        //    using (Font font = new Font("Arial", 12))
        //    {
        //        int startX = 10;
        //        int startY = 10;
        //        int offsetY = 20;

        //        // Drawing title
        //        e.Graphics.DrawString("Lalate Coffee สาขาหลังมอ (1234)", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, startX, startY);
        //        startY += offsetY;

        //        // Drawing subtitle
        //        string nowDateTime = DateTime.Now.ToString("วันที่: dd/MM/yyyy HH:mm:ss");
        //        e.Graphics.DrawString("สั่งโดย : " + name_user + "\n" + nowDateTime, font, Brushes.Black, startX, startY);
        //        startY += 2 * offsetY;

        //        // Drawing header
        //        e.Graphics.DrawString("Address : หลังมอ ต.ศิลา อ.เมือง จ.ขอนแก่น Tell: 0834477387", font, Brushes.Black, startX, startY);
        //        startY += offsetY;
        //        e.Graphics.DrawString("Tax ID : 12-345678", font, Brushes.Black, startX, startY);
        //        startY += offsetY;

        //        // Drawing date and user name
        //        e.Graphics.DrawString("Date: " + DateTime.Now.ToString("dd/MM/yyyy"), font, Brushes.Black, startX, startY);
        //        startY += offsetY;
        //        e.Graphics.DrawString("User Name: " + name_user, font, Brushes.Black, startX, startY);
        //        startY += 2 * offsetY;

        //        // Drawing column headers
        //        e.Graphics.DrawString("Name", font, Brushes.Black, startX, startY);
        //        e.Graphics.DrawString("Amount", font, Brushes.Black, startX + 200, startY);
        //        e.Graphics.DrawString("Price", font, Brushes.Black, startX + 400, startY);
        //        startY += offsetY;

        //        // Drawing data from DataGridView
        //        int tableX = startX;
        //        int tableY = startY;
        //        int cellWidth = 200;
        //        int cellHeight = 20;

        //        for (int i = 0; i < guna2DataGridView1.Rows.Count; i++)
        //        {
        //            for (int j = 0; j < guna2DataGridView1.Columns.Count; j++)
        //            {
        //                e.Graphics.DrawString(guna2DataGridView1.Rows[i].Cells[j].Value.ToString(), font, Brushes.Black, tableX + j * cellWidth, tableY + i * cellHeight);
        //            }
        //        }

        //        tableY += guna2DataGridView1.Rows.Count * cellHeight;

        //        // Drawing discount
        //        e.Graphics.DrawString("รวมทั้งสิ้น : " + totalprice.Text, font, Brushes.Black, startX, tableY + offsetY);
        //        //e.Graphics.DrawString("รวมส่วนลด 10% : " + total_with_discount, font, Brushes.Black, startX, tableY + 2 * offsetY);
        //        e.Graphics.DrawString("VAT 7% : " + total_with_vat, font, Brushes.Black, startX, tableY + 2 * offsetY);
        //        e.Graphics.DrawString("ออกใบเสร็จโดย Admin: Phiraphob", font, Brushes.Black, startX, tableY + 3 * offsetY);
        //    }
        //}
    }
}
