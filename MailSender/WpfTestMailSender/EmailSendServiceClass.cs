using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace WpfTestMailSender
{
    class EmailSendServiceClass
    {
        public void Send(String mailTitle, string mailBody, string strPassword)
        {
            foreach (string mail in Const.to)
            {
                using (MailMessage mm = new MailMessage(Const.from, mail))
                {
                    // Формируем письмо
                    mm.Subject = mailTitle; 
                    mm.Body = mailBody;       
                    mm.IsBodyHtml = false; 
                    using (SmtpClient sc = new SmtpClient(Const.smtp, Const.smtpPort))
                    {
                        sc.EnableSsl = true;
                        sc.Credentials = new NetworkCredential(Const.from, strPassword);
                        try
                        {
                            sc.Send(mm);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(Const.messageError + ex.ToString());
                        }
                    }
                } 
            }
        }
    }
}
