using MaterialDesignWpf.DbContexts;
using MaterialDesignWpf.Models;
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
using System.Windows.Shapes;

namespace MaterialDesignWpf.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserCabinetWindow.xaml
    /// </summary>
    public partial class UserCabinetWindow : Window
    {
        public UserCabinetWindow()
        {
            InitializeComponent();

            ApplicationContext db = new ApplicationContext();
            List<User> usersList = db.Users.ToList();
            
            lstVw_UsersList.ItemsSource = usersList;
        }
    }
}
