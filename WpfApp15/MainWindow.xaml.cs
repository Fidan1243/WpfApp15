using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace WpfApp15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        Store store = new Store(new List<Customer>());

        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Customer> customers = new ObservableCollection<Customer>();

        public ObservableCollection<Customer> Customers
        {
            get { return customers; }
            set { customers = value; OnPropertyChanged(); }
        }

        private string mailBox;

        public string MailBox
        {
            get { return mailBox; }
            set { mailBox = value; OnPropertyChanged(); }
        }

        private string nameBox;

        public string NameBox
        {
            get { return nameBox; }
            set { nameBox = value; OnPropertyChanged(); }
        }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        private void NotifyButton_Click(object sender, RoutedEventArgs e)
        {
            store.SendAllNotifications();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (MailBox.EndsWith("@gmail.com") || MailBox.EndsWith("@mail.ru"))
            {
                store.Customers.Add(new CustomerWithMail { ProductName = NameBox, Mail = MailBox });
                Customers.Add(new CustomerWithMail { ProductName = NameBox, Mail = MailBox });
            }
            else
            {
                store.Customers.Add(new CustomerWithName { ProductName = NameBox, Name = MailBox });
                Customers.Add(new CustomerWithName { ProductName = NameBox, Name = MailBox });
            }
        }
    }
}
