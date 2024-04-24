using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Net;
using System.Net.Mail;

namespace DataBaseMySQL
{
    public partial class Form2 : Form
    {
       public string senderEmail;
       public string senderPassword;
       public string recipientEmail;
       


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            propertyGrid1 = new PropertyGrid();
            propertyGrid1.SelectedObject = textMailcontent;
            



        }

        public void SendEmail(string to, string subject, string content)
        {

            var smtpClient = new SmtpClient();
            smtpClient.Host = "smtp-relay.brevo.com";
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential(senderEmail,senderPassword);
            smtpClient.EnableSsl = false;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;


           



            MailMessage msg = new MailMessage();
            msg.To.Add(new MailAddress(to));
            msg.Subject = subject;
            msg.Body = content;
            msg.From = new MailAddress(senderEmail);


            if (smtpClient.Credentials == null)
            {
                Form3 form3 = new Form3(this);
                form3.Show();
              

            }
            else
            {
                if(textRecipient.Text == null)
                {
                    MessageBox.Show("Please enter recipient Email" + MessageBoxButtons.OK);

                }
                else
                {
                    smtpClient.Send(msg);
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {


            SendEmail(textRecipient.Text, textMailobject.Text, textMailcontent.Text);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
        }
    }
}
