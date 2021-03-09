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
    /// ƒл€ прив€зки UI к классам ViewModel используетс€ компонент MVVM Light Toolkit - ViewModelLocator
    ///  ласс ViewModelLocator €вл€етс€ посредником между вашим UI и ViewModels, 
    /// который св€зывает ViewModels с UI.
    /// ≈сли вы хотите использовать ViewModel в качестве источника прив€зки дл€ пользовательского 
    /// интерфейса, вы должны предоставить эту ViewModel как свойство в классе ViewModelLocator. 


    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            // ”станавливаем контейнер IOC дл€ приложени€. 
            // MVVM Light Toolkit предоставл€ет контейнер IOC по умолчанию.             
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            //  онтейнер IOC используетс€ дл€ регистрации и разрешени€ экземпл€ров.
            // –егистрируем MainViewModel в контейнере IOC
            SimpleIoc.Default.Register<MainViewModel>();
            //  –егистрируем NotifyUserMethod в классе Messenger. “аким образом, когда мы отправл€ем текстовое сообщение с классом Messenger с помощью NotificationMessage, оно автоматически выполн€ет NotifyUserMethod.
            Messenger.Default.Register<NotificationMessage>(this, NotifyUserMethod);
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        // ѕример прив€зки второй формы
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