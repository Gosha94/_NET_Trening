﻿using System.Windows;
using CustomMVVMLastChance.ViewModel;

namespace CustomMVVMLastChance
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new ApplicationViewModel();
        }
    }
}
