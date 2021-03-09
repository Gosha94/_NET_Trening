using MaterialDesignWpf.DbContexts;
using MaterialDesignWpf.Models;
using MaterialDesignWpf.Pages;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace MaterialDesignWpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationContext db;

        public MainWindow()
        {
            InitializeComponent();

            db = new ApplicationContext();

            DoubleAnimation buttonAnimation = new DoubleAnimation();
            buttonAnimation.From = 0;
            buttonAnimation.To = 450;
            buttonAnimation.Duration = TimeSpan.FromSeconds(1.5);
            btn_Reg.BeginAnimation(Button.WidthProperty, buttonAnimation);
        }

        private void btn_Auth_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            this.Hide();
        }

        private void btn_Register_Click(object sender, RoutedEventArgs e)
        {
            var login = txtBx_Login.Text.Trim();
            var psw = pswBx_pasOrig.Password.Trim();
            var pswRepeat = pswBx_pasRepeat.Password.Trim();
            var email = txtBx_Email.Text.Trim().ToLower();

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
            else if (psw != pswRepeat)
            {
                pswBx_pasRepeat.ToolTip = "Поле заполнено некорректно!";
                pswBx_pasRepeat.Background = Brushes.DarkOrange;
            }
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                txtBx_Email.ToolTip = "Поле заполнено некорректно!";
                txtBx_Email.Background = Brushes.DarkOrange;
            }
            else
            {
                txtBx_Login.ToolTip = "";
                txtBx_Login.Background = Brushes.Transparent;
                pswBx_pasOrig.ToolTip = "";
                pswBx_pasOrig.Background = Brushes.Transparent;
                pswBx_pasRepeat.ToolTip = "";
                pswBx_pasRepeat.Background = Brushes.Transparent;
                txtBx_Email.ToolTip = "";
                txtBx_Email.Background = Brushes.Transparent;

                MessageBox.Show("Данные корректны!");

                User newUser = new User(login, psw, email);
                //Test var newUser = new User { Login = "Geor", Pass = "123456", Email = "Geor@.ru" };
                db.Users.Add(newUser);
                db.SaveChanges();

                AuthWindow authWindow = new AuthWindow();
                authWindow.Show();
                this.Hide();
            }
        }
    }
}
