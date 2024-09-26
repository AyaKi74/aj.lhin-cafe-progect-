using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MimeKit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EASendMail;

namespace cafe_3.UC
{

    
    public partial class forget_password_uc : UserControl
    {
        String randomCode;
        public forget_password_uc()
        {
            InitializeComponent();
        }
        
        

        private void btnsend_Click(object sender, EventArgs e)
        {
            try
            {
                Random rand = new Random();
                randomCode = (rand.Next(999999).ToString());
                SmtpMail oMail = new SmtpMail("TryIt");

                // Your gmail email address
                oMail.From = "kamitsu03@gmail.com";

                // Set recipient email address
                oMail.To = txtemail.Text;

                // Set email subject
                oMail.Subject = "OTP For Reset Password";

                // Set email body
                oMail.TextBody = "Your OTP is "+ randomCode;

                // Gmail SMTP server address
                SmtpServer oServer = new SmtpServer("smtp.gmail.com");

                // Gmail user authentication
                // For example: your email is "gmailid@gmail.com", then the user should be the same
                oServer.User = "kamitsu03@gmail.com";

                // Create app password in Google account
                // https://support.google.com/accounts/answer/185833?hl=en
                oServer.Password = "dxko qrpd uwtu artu";

                // If you want to use direct SSL 465 port,
                // please add this line, otherwise TLS will be used.
                //oServer.Port = 465;

                // set 587 TLS port;
                oServer.Port = 587;

                // detect SSL/TLS automatically
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
            if(randomCode == (txtotp.Text).ToString())
            {
                
            }
        }
    }
    
}
