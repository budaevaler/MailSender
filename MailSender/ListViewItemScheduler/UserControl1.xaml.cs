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

namespace ListViewItemScheduler
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class ListViewItemSchedulerControl : UserControl
    {

        public ListViewItemSchedulerControl()
        {
            InitializeComponent();
        }
        public event RoutedEventHandler btnEditMailClick;
        public event RoutedEventHandler btnDeleteItemClick;

        private void EditMale_Click(object sender, RoutedEventArgs e)
        {
            btnEditMailClick?.Invoke(sender, e);
        }

        private void DeleteItem_Click(object sender, RoutedEventArgs e)
        {
            //this.Parent.Controls.Remove(this);
            //this.Parent.
            btnDeleteItemClick?.Invoke(this, e);

            
        }

        //public static readonly DependencyProperty DynamicTextProperty =
       //DependencyProperty.Register(
       //   "TbDateText",
       //   typeof(string),
       //   typeof(ListViewItemSchedulerControl),
       //   new FrameworkPropertyMetadata(null));

       // public string TbDateText
       // {
       //     get { return (string)GetValue(DynamicTextProperty); }
       //     set { SetValue(DynamicTextProperty, value); }
       // }
        string tbDateText;
        public string TbDateText
        {
            get { return tbDate.Text; }
            set { tbDateText = tbDate.Text; }
        }

        private void TextBox_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
            {
                ((Control)sender).ToolTip = e.Error.ErrorContent.ToString();
            }
            else
            {
                ((Control)sender).ToolTip = "";
            }
        }

    }
}
