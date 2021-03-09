using MaterialDesignWpf.DbContexts;
using MaterialDesignWpf.Models;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace MaterialDesignWpf.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {

        ApplicationContext db;

        public AuthWindow()
        {
            InitializeComponent();

            db = new ApplicationContext();
        }

        private void btn_Reg_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void btn_Auth_Click(object sender, RoutedEventArgs e)
        {
            var login = txtBx_Login.Text.Trim();
            var psw = pswBx_pasOrig.Password.Trim();

            if (login.Length < 5)
            {
                txtBx_Login.ToolTip = "Поле заполнено некорректно!";
                txtBx_Login.Background = Brushes.DarkOrange;
            }
            else if (psw.Length < 5)
            {
                pswBx_pasOrig.ToolTip = "Поле заполнено некорректно!";
                pswBx_pasOrig.Background = Brushes.DarkOrange;
            }            
            else
            {
                txtBx_Login.ToolTip = "";
                txtBx_Login.Background = Brushes.Transparent;
                pswBx_pasOrig.ToolTip = "";
                pswBx_pasOrig.Background = Brushes.Transparent;

                User authUser = null;
                using (ApplicationContext authContext = new ApplicationContext())
                {
                    authUser = db.Users
                            .Where(x=> x.Login == login)
                                .FirstOrDefault();
                }

                if (authUser != null)
                {
                    MessageBox.Show("Данные корректны!");
                    UserCabinetWindow userCabWindow = new UserCabinetWindow();
                    userCabWindow.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Пользователя с такими данными не существует!");
                }                                
            }
        }
    }
}
