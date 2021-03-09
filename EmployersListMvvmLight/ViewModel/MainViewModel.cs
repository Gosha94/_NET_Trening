using EmployersListMvvmLight.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace EmployersListMvvmLight.ViewModel
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
    /// ViewModel каждой формы должна наследоваться от ViewModelBase
    public class MainViewModel : ViewModelBase
    {

        /// <summary>
        /// Модель представления для формы содержит два открытых свойства
        /// Список работников EmployeeList и Выбранный работник SelectedEmployee
        /// EmployeeList прибинден к свойству ListBox.ItemsSource, 
        /// а SelectedEmployee прибинден к свойству того же ListBox.SelectedItem
        /// </summary>

        private ObservableCollection<Employee> _employees; 
        private Employee _selectedEmployee;

        // Ниже мы объявляем два поля Комманд, для подвязки к кнопкам на форме
        public ICommand LoadEmployeesCommand { get; private set; }
        public ICommand SaveEmployeesCommand { get; private set; }
        
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        /// При создании экземпляра представления поля смогут получать команды с кнопок на форме
        /// и при помощи делегатов вызывать методы из представления
        public MainViewModel()
        {
            LoadEmployeesCommand = new RelayCommand(LoadEmployeesMethod);
            SaveEmployeesCommand = new RelayCommand(SaveEmployeesMethod);            
        }

        public ObservableCollection<Employee> EmployeeList
        {
            get
            {
                return _employees;
            }
        }
        public Employee SelectedEmployee
        {
            get
            {
                return _selectedEmployee;
            }
            set
            {
                _selectedEmployee = value;
                RaisePropertyChanged("SelectedEmployee");
            }
        }

         public void SaveEmployeesMethod()
        {
            Messenger.Default.Send(new NotificationMessage("Employees Saved."));
        }
        private void LoadEmployeesMethod()
        {
            _employees = Employee.GetSampleEmployees();
            this.RaisePropertyChanged(() => this.EmployeeList);
            Messenger.Default.Send(new NotificationMessage("Employees Loaded."));
        }

    } 
 }
