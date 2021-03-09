using System.Windows;
using FrontendLearning.DockStackPanels;

namespace FrontendLearning
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            
            new DockStackPanels.DockStackPanels().Show();
        }
    }
}
