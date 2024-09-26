using EASendMail;
using System;
using cafe_3.UC;
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
    
    public partial class forgetpassword : Form
    {
        
        public string email { get; set; }
        function fn = new function();
        String randomCode;
        private DateTime codeGenerationTime;
        private const int OTP_VALIDITY_DURATION_MINUTES = 12;

        public forgetpassword()
        {
            InitializeComponent();
        }

        private void forgetpassword_Load(object sender, EventArgs e)
        {
            
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            try
            {
                Random rand = new Random();
                randomCode = rand.Next(999999).ToString("D6");
                codeGenerationTime = DateTime.Now; // Store the generation time

                SmtpMail oMail = new SmtpMail("TryIt");

                // Your gmail email address
                oMail.From = "kamitsu03@gmail.com";

                // Set recipient email address
                oMail.To = txtemail.Text;

                // Set email subject
                oMail.Subject = "OTP For Reset Password";

                // Set email body
                oMail.TextBody = "Your OTP is " + randomCode + "please use in 12 minutes.";

                // Gmail SMTP server address
                SmtpServer oServer = new SmtpServer("smtp.gmail.com");

                // Gmail user authentication
                oServer.User = "kamitsu03@gmail.com";
                oServer.Password = "dxko qrpd uwtu artu";
                oServer.Port = 587; // set 587 TLS port;
                oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;

                Console.WriteLine("start to send email over SSL ...");

                SmtpClient oSmtp = new SmtpClient();
                oSmtp.SendMail(oServer, oMail);

                Console.WriteLine("email was sent successfully!");
            }
            catch (Exception ep)
            {
                Console.WriteLine("failed to send email with the following error:");
                Console.WriteLine(ep.Message);
            }
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - codeGenerationTime;
            if (elapsed.TotalMinutes > OTP_VALIDITY_DURATION_MINUTES)
            {
                MessageBox.Show("OTP has expired. Please request a new one.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (randomCode == txtotp.Text)
            {
                Reset_password Rp = new Reset_password();
                Rp.email = txtemail.Text;
                Rp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong OTP. Try Again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
