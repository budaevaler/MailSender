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
using System.Net;
using System.Net.Mail;

namespace WpfTestMailSender
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class WpfMailSender : Window
    {
        public WpfMailSender()
        {
            InitializeComponent();
        }

        private void btnSendEmail_Click(object sender, RoutedEventArgs e)
        {
            string strPassword = passwordBox.Password;
            string mailTitle = txbMessageTitle.Text;
            string mailBody = txbMessageBody.Text;
            try
            {
                EmailSendServiceClass send = new EmailSendServiceClass();
                send.Send(mailTitle, mailBody, strPassword);
            }
            catch (Exception ex)
            {
                ErrorWindow error = new ErrorWindow(ex.ToString());
                error.ShowDialog();
            }
            SendEndWindow sew = new SendEndWindow();
            sew.ShowDialog();
        }
    }
}
