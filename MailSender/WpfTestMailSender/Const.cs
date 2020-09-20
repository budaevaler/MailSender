using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestMailSender
{
    public static class Const
    {
        public static List<string> to = new List<string> { "valeria.budaeva@yandex.ru" };
        public static string from = "valeriiyb@yandex.ru";
        public static string smtp = "smtp.yandex.ru";
        public static int smtpPort = 587;
        public static string messageError = "Невозможно отправить письмо ";
        public static string messageEnd = "Работа завершена.";
    }
}
