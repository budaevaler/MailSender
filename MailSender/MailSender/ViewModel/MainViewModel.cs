using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using MailSender.Services;
using GalaSoft.MvvmLight.Command;

namespace MailSender.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        ObservableCollection<Email> emails; //логика дл€ чтени€ данных о получател€х почты из таблицы Emails
        public ObservableCollection<Email> Emails
        {
            get { return emails; }
            set
            {
                emails = value;
                RaisePropertyChanged(nameof(Emails));
            }
        }

        IDataAccessService _serviceProxy;
        void GetEmails() // данные читаютс€ из Ѕƒ и помещаютс€ в наблюдаемую коллекцию Emails
        {
            Emails.Clear();
            foreach (var item in _serviceProxy.GetEmails())
            {
                Emails.Add(item);
            }
        }

        private Email _currentEmail = new Email();
        public Email CurrentEmail
        {
            get => _currentEmail;
            set => Set(ref _currentEmail, value);
        }

        public RelayCommand ReadAllMailsCommand { get; set; }
        public RelayCommand<Email> SaveMailCommand { get; set; }
        public RelayCommand<Email> DeleteMailCommand { get; set; }
        public RelayCommand<string> FilterCommand { get; set; }


        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IDataAccessService serviceProxy)
        {
            _serviceProxy = serviceProxy;
            Emails = new ObservableCollection<Email>();
            EmailInfo = new Email();
            ReadAllMailsCommand = new RelayCommand(GetEmails);
            SaveMailCommand = new RelayCommand<Email>(SaveEmail);
            DeleteMailCommand = new RelayCommand<Email>(DeleteEmail);
            FilterCommand = new RelayCommand<string>(Filter);
        }

        Email emailInfo;

        public Email EmailInfo
        {
            get { return emailInfo; }
            set
            {
                emailInfo = value;
                RaisePropertyChanged(nameof(EmailInfo));
            }
        }
         void SaveEmail (Email email)
         {
             email.Id = _serviceProxy.AddEmail(email);
             if (EmailInfo.Id != 0)
             {
                Emails.Add(email);
                RaisePropertyChanged(nameof(email));
             }
            GetEmails();
        }
        void DeleteEmail(Email email)
        {
            email.Id = _serviceProxy.DeleteEmail(email);
            if (EmailInfo.Id != 0)
            {
                Emails.Remove(email);
                RaisePropertyChanged(nameof(email));
            }
            GetEmails();
        }
        string filterName;
         public string FilterName
         {
             get { return filterName; }
            set
            {
                filterName = value;
                RaisePropertyChanged(nameof(FilterName));
            }
         }
        void Filter (string filterName)
        {
            GetEmails();
            for (int i=0; i<Emails.Count; i++)
            {
                if (!Emails[i].Name.Contains(filterName))
                {
                    Emails.Remove(Emails[i]);
                    i--;
                }
                    
            }
            RaisePropertyChanged(nameof(Emails));
        }

    }
}