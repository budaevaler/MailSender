using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EncrypterDll;

namespace MailSender
{
    public static class Senders
    {
        public static Dictionary<string, string> SendersDictionary { get; } = new Dictionary<string, string>()
        { { "valeriiyb@yandex.ru", Encrypter.Deecrypt("fxpyrl98F7&q") } };
        public static Dictionary<string, int> SmtpDictionary { get; } = new Dictionary<string, int>()
        { { "smtp.yandex.ru", 587 } };

    }
}
