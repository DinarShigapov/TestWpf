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
using WPFOne.Codes;

namespace WPFOne
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<User> users = new List<User>
        {
            new User(){Id = 1, LastName = "Шигапов", FirstName = "Динар", Age = 18, City = "Казань" },
            new User(){Id = 2, LastName = "Шигапов", FirstName = "Динар", Age = 18, City = "Казань" },
            new User(){Id = 3, LastName = "Шигапов", FirstName = "Динар", Age = 18, City = "Казань" }
        };
             
        public MainWindow()
        {
            InitializeComponent();
            LVUser.ItemsSource = users;
        }
    }
}
