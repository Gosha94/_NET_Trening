/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:EmployersListMvvmLight"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using System.Windows;

namespace EmployersListMvvmLight.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// ��� �������� UI � ������� ViewModel ������������ ��������� MVVM Light Toolkit - ViewModelLocator
    /// ����� ViewModelLocator �������� ����������� ����� ����� UI � ViewModels, 
    /// ������� ��������� ViewModels � UI.
    /// ���� �� ������ ������������ ViewModel � �������� ��������� �������� ��� ����������������� 
    /// ����������, �� ������ ������������ ��� ViewModel ��� �������� � ������ ViewModelLocator. 


    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            // ������������� ��������� IOC ��� ����������. 
            // MVVM Light Toolkit ������������� ��������� IOC �� ���������.             
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            // ��������� IOC ������������ ��� ����������� � ���������� �����������.
            // ������������ MainViewModel � ���������� IOC
            SimpleIoc.Default.Register<MainViewModel>();
            //  ������������ NotifyUserMethod � ������ Messenger. ����� �������, ����� �� ���������� ��������� ��������� � ������� Messenger � ������� NotificationMessage, ��� ������������� ��������� NotifyUserMethod.
            Messenger.Default.Register<NotificationMessage>(this, NotifyUserMethod);
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        // ������ �������� ������ �����
        //public SecondViewModel SecondVM
        //{
        //    get
        //    {
        //        return ServiceLocator.Current.GetInstance<SecondViewModel>();
        //    }
        //}

        private void NotifyUserMethod(NotificationMessage message)
        {
            MessageBox.Show(message.Notification);
        }

    }
}