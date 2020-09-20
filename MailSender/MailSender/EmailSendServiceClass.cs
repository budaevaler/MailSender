using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using EmailSendServiceClassDLL;
using System.Collections.ObjectModel;

namespace MailSender
{
    class EmailSendServiceClass
    {
        //#region vars
        //private string strLogin;         // email, c которого будет рассылаться почта
        //private string strPassword; // пароль к email, с которого будет рассылаться почта
        //private string strSmtp; // smtp-server
        //private int iSmtpPort;
        //private string strBody;                    // текст письма для отправки
        //private string strSubject;// тема письма для отправки
        //private string strTextMail;
        //#endregion
        //public EmailSendServiceClass(string sLogin, string sPassword, string sSmtp, int intSmtpPort, string textMail)
        //{
        //    strLogin = sLogin;
        //    strPassword = sPassword;
        //    strSmtp = sSmtp;
        //    iSmtpPort = intSmtpPort;
        //    strTextMail = textMail;
        //}
        //private void SendMail(string mail, string name) // Отправка email конкретному адресату
        //{
        //    using (MailMessage mm = new MailMessage(strLogin, mail))
        //    {
        //        mm.Subject = strSubject;
        //        mm.Body = strTextMail;
        //        mm.IsBodyHtml = false;
        //        SmtpClient sc = new SmtpClient(strSmtp, iSmtpPort);
        //        sc.EnableSsl = true;
        //        sc.DeliveryMethod = SmtpDeliveryMethod.Network;
        //        sc.UseDefaultCredentials = false;
        //        sc.Credentials = new NetworkCredential(strLogin, strPassword);
        //        try
        //        {
        //            sc.Send(mm);
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Невозможно отправить письмо " + ex.ToString());
        //        }
        //    }
        //}//private void SendMail(string mail, string name)

        public static void SendMails(ObservableCollection<Email> emails, string strLogin, string strPassword, string strSmtp, int iSmtpPort, string strTextMail, string strSubject)
        {
            foreach (Email email in emails)
            {
                Task.Factory.StartNew(() => EmailSendServiceClassDLL.Class1.SendMail(email.Value, email.Name, strLogin, strPassword, strSmtp, iSmtpPort, strTextMail, strSubject));
            }
        }
    }  //private void SendMail(string mail, string name)
}
