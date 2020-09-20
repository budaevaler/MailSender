using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data.Entity;



//namespace MailSender.Services
//{
//    public interface IDataAccessService // определяет доступ к данным в БД
//    {
//        ObservableCollection<Email> GetEmails();
//        int CreateEmail(Email email);
//    }
//    public class DataAccessService : IDataAccessService
//    {
//        EmailsDataContext context;
//        public DataAccessService()
//        {
//            context = new EmailsDataContext();
//        }
//        public ObservableCollection<Email> GetEmails()
//        {
//            ObservableCollection<Email> Emails = new ObservableCollection<Email>();
//            foreach (var item in context.Email)
//            {
//                Emails.Add(item);
//            }
//            return Emails;
//        }
//        public int CreateEmail(Email email) // сохраняет изменения в базе данных
//        {
//            context.Email.InsertOnSubmit(email);
//            context.SubmitChanges();
//            return email.Id;
//        }

//    }
//}
namespace MailSender.Services
{
    public interface IDataAccessService
    {
        ObservableCollection<Email> GetEmails();

        int AddEmail(Email email);

        int UpdateEmail(Email email);

        int DeleteEmail(Email email);
    }

    public class DataAccessService : IDataAccessService
    {

        CommonContainer context;
        public DataAccessService()
        {
            context = new CommonContainer();
        }
        public ObservableCollection<Email> GetEmails()
        {
            ObservableCollection<Email> Emails = new ObservableCollection<Email>();
            foreach (var item in context.Emails)
            {
                Emails.Add(item);
            }
            return Emails;
        }

        public int AddEmail(Email email)
        {
            context.Emails.Add(email);
            context.SaveChanges();
            return email.Id;
        }

        public int UpdateEmail(Email email)
        {
            context.Emails.Attach(email);
            context.Entry(email).State = EntityState.Modified;
            context.SaveChanges();
            return email.Id;
        }
        public int DeleteEmail(Email email)
        {
            if (context.Entry(email).State == EntityState.Detached)
            {
                context.Emails.Attach(email);
            }
            context.Emails.Remove(email);

            context.SaveChanges();
            return email.Id;
        }
    }
}
