using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace MailSender
{
   
    
    /// <summary>
    /// Класс-планировщик, который создает расписание, следит за его выполнением и напоминает о событиях
    /// Также помогает автоматизировать рассылку писем в соответствии с расписанием
    /// </summary>
    public class SchedulerClass
    {
        DispatcherTimer timer = new DispatcherTimer(); // таймер
        //DateTime dtSend;                           // дата и время отправки
        ObservableCollection<Email> emails;                  // коллекция email-ов адресатов
        private string strLogin;         // email, c которого будет рассылаться почта
        private string strPassword; // пароль к email, с которого будет рассылаться почта
        private string strSmtp; // smtp-server
        private int iSmtpPort;
        private string strSubject;// тема письма для отправки
        private string strTextMail;

        Dictionary<DateTime, string> dicDates = new Dictionary<DateTime, string>();
        public Dictionary<DateTime,string> DatesEmailTexts
        {
            get { return dicDates; }
            set
            {
                dicDates = value;
                dicDates = dicDates.OrderBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
            }
        }
        /// <summary>
        /// Метод, который превращает строку из текстбокса tbTimePicker в TimeSpan
        /// </summary>
        /// <param name="strSendTime"></param>
        /// <returns></returns>
        public TimeSpan GetSendTime(string strSendTime)
        {
                TimeSpan tsSendTime = new TimeSpan();
                try
                {
                    tsSendTime = TimeSpan.Parse(strSendTime);
                }
                catch { }
                return tsSendTime;
        }
        /// <summary>
        //// Непосредственно отправка писем
        /// </summary>
        /// <param name="dtSend"></param>
        /// <param name="emailSender"></param>
        /// <param name="emails"></param>
        public void SendEmails(/*DateTime dtSend,*/Dictionary<DateTime, string> datesWithText, string sLogin, string sPassword, string sSmtp, int intSmtpPort, /*string textMail, string sSubject,*/ ObservableCollection<Email> emails)
        {
            //this.strSubject = sSubject;
            strLogin = sLogin;
            strPassword = sPassword;
            strSmtp = sSmtp;
            iSmtpPort = intSmtpPort;
            dicDates = datesWithText;
            //strTextMail = textMail;
            //this.dtSend = dtSend;
            this.emails = emails;
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
            
        }
        //private void Timer_Tick(object sender, EventArgs e)
        //{
        //    if (dtSend.ToShortTimeString() == DateTime.Now.ToShortTimeString())
        //    {
        //        EmailSendServiceClass.SendMails(emails, strLogin, strPassword, strSmtp, iSmtpPort, strTextMail, strSubject);
        //        //emailSender.SendMails(emails);
        //        timer.Stop();
        //        MessageBox.Show("Письма отправлены.");
        //    }
        //}
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (dicDates.Count == 0)
            {
                timer.Stop();
                MessageBox.Show("Письма отправлены.");
            }
            else if (dicDates.Keys.First<DateTime>().ToShortTimeString() == DateTime.Now.ToShortTimeString())
            {
                strTextMail = dicDates[dicDates.Keys.First<DateTime>()];
                strSubject = $"Рассылка от {dicDates.Keys.First<DateTime>().ToShortTimeString()} ";
                EmailSendServiceClass.SendMails(emails, strLogin, strPassword, strSmtp, iSmtpPort, strTextMail, strSubject);
                dicDates.Remove(dicDates.Keys.First<DateTime>());
            }
        }

    }
}

