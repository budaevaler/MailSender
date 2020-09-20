using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EmailSendServiceClassDLL;
using MailSender.ViewModel;
using ListViewItemScheduler;

namespace MailSender
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class WpfMailSender : Window
    {
        public WpfMailSender()
        {
            InitializeComponent();
            //DBClass db = new DBClass();
            //dgEmails.ItemsSource = db.Emails;
        }
        private string strSubject = "Привет";


        private void MiClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnClock_Click(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedItem = tabPlanner;
        }

        private void BtnSendAtOnce_Click(object sender, RoutedEventArgs e)
        {
           
            string strLogin = cbSenderSelect.Text;
            string strPassword = cbSenderSelect.SelectedValue.ToString();
            string strSmtp = cbSmtpSelect.Text; // smtp-server
            int iSmtpPort = (int)cbSmtpSelect.SelectedValue;   
            if (string.IsNullOrEmpty(strLogin))
            {
                MessageBox.Show("Выберите отправителя");
                return;
            }
            if (string.IsNullOrEmpty(strPassword))
            {
                MessageBox.Show("Укажите пароль отправителя");
                return;
            }
            string textMail = new TextRange(rtbTextMail.Document.ContentStart, rtbTextMail.Document.ContentEnd).Text;
            if (textMail == "\r\n")
            {
                MessageBox.Show("Письмо не заполнено");
                tabControl.SelectedIndex = 2;
                return;
            }
            //EmailSendServiceClass emailSender = new EmailSendServiceClass(strLogin, strPassword, strSmtp, iSmtpPort, textMail);
            //EmailSendServiceClass.SendMails((IQueryable<Email>)dgEmails.ItemsSource, strLogin, strPassword, strSmtp, iSmtpPort, textMail, strSubject);
            var locator = (ViewModelLocator)FindResource("Locator");
            EmailSendServiceClass.SendMails(locator.Main.Emails, strLogin, strPassword, strSmtp, iSmtpPort, textMail, strSubject);


        }

        private void BtnSend_Click(object sender, RoutedEventArgs e)
        {
            string textMail = new TextRange(rtbTextMail.Document.ContentStart, rtbTextMail.Document.ContentEnd).Text;
            if (textMail == "\r\n")
            {
                MessageBox.Show("Письмо не заполнено");
                tabControl.SelectedIndex = 2;
                return;
            }
            Dictionary<DateTime, string> dates = new Dictionary<DateTime, string>();
            for (int i = 0; i < lvDates.Items.Count; i++)
            {
                string a = (lvDates.Items.GetItemAt(i) as ListViewItemSchedulerControl).TbDateText;
                if (a != "")
                {
                    DateTime date;
                    if (DateTime.TryParse(a, out date))
                    {
                        if (!dates.ContainsKey(date))
                            dates.Add(date, textMail);
                    }
                    else
                    MessageBox.Show("Введитевремя отправки согласно формату дд.мм.гггг чч:мм:сс");
                    
                    //DateTime date = DateTime.TryParse(a);

                }
            }
            if (dates.Count!=0)
            {
                string strLogin = cbSenderSelect.Text;
                string strPassword = cbSenderSelect.SelectedValue.ToString();
                int iSmtpPort = (int)cbSmtpSelect.SelectedValue;
                string strSmtp = cbSmtpSelect.Text; // smtp-server

                SchedulerClass sc = new SchedulerClass();
                sc.DatesEmailTexts = dates;
                var locator = (ViewModelLocator)FindResource("Locator");
                sc.SendEmails(/*dtSendDateTime,*/sc.DatesEmailTexts, strLogin, strPassword, strSmtp, iSmtpPort, /*textMail, strSubject,*/ locator.Main.Emails);
            }
            
            //TimeSpan tsSendTime = sc.GetSendTime(tbTimePicker.Text);
            //if (tsSendTime == new TimeSpan())
            //{
            //    MessageBox.Show("Некорректный формат даты");
            //    return;
            //}
            //DateTime dtSendDateTime = (cldSchedulDateTimes.SelectedDate ?? DateTime.Today).Add(tsSendTime);
            //if (dtSendDateTime < DateTime.Now)
            //{
            //    MessageBox.Show("Дата и время отправки писем не могут быть раньше, чем настоящее время");
            //    return;
            //}

            //sc.SendEmails(dtSendDateTime, strLogin, strPassword, strSmtp, iSmtpPort, textMail, strSubject, (IQueryable<Email>)dgEmails.ItemsSource);
           

        }

       

        private void AddEMail_Click(object sender, RoutedEventArgs e)
        {
            var Date = new ListViewItemSchedulerControl();
            lvDates.Items.Add(Date);
            Date.btnEditMailClick += ListViewItemSchedulerControl_btnEditMailClick;
            Date.btnDeleteItemClick += ListViewItemSchedulerControl_btnDeleteItemClick;
            Binding bind = new Binding();
            
        }

        private void ListViewItemSchedulerControl_btnEditMailClick(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void ListViewItemSchedulerControl_btnDeleteItemClick(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < lvDates.Items.Count; i++)
            {
                var obj = lvDates.Items.GetItemAt(i);
                var h = (lvDates.Items.GetItemAt(i) as ListViewItemSchedulerControl);
                
                if (obj.Equals(sender))
                {
                    lvDates.Items.Remove(lvDates.Items[i]);
                    i--;
                }
                
            }
        }
    }
}

