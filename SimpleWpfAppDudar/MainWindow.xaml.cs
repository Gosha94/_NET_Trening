using System.Windows;
using System.Windows.Controls;
using System.Data;

namespace SimpleWpfAppDudar
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            BindingButtonClickCommand();
        }

        private void BindingButtonClickCommand()
        {
            foreach (UIElement elem in grd_MainRoot.Children)
            {
                if (elem is Button button)
                {
                    button.Click += Calculate_ClickCommand;
                }
            }
        }       

        private void Calculate_ClickCommand(object sender, RoutedEventArgs e)
        {
            var inputUserString = ((Button)sender).Content.ToString();

            switch (inputUserString)
            {
                case "Clear":
                    txtBlck_Result.Text = string.Empty;
                    break;
                case "=":
                    var resultOfCalculate = new DataTable().Compute(txtBlck_Result.Text, null).ToString();
                    txtBlck_Result.Text = resultOfCalculate;
                    break;
                default:
                    txtBlck_Result.Text += inputUserString;
                    break;
            }
        }
    }
}
