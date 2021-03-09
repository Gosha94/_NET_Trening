/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:WPF_MultiPages"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using System;
using WPF_MultiPages.Navigation;
using WPF_MultiPages.ViewModels;

namespace WPF_MultiPages.Locator
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<Page1ViewModel>();
            SimpleIoc.Default.Register<HomeViewModel>();
            //SimpleIoc.Default.Register<>();
            SetupNavigation();
            
            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}

            SimpleIoc.Default.Register<MainViewModel>();            
        }

        private static void SetupNavigation()
        {
            var navigationService = new FrameNavigation();
            navigationService.Configure("Home", new Uri("../Pages/Home.xaml", UriKind.Relative));
            navigationService.Configure("Page1", new Uri("../Pages/Page1.xaml", UriKind.Relative));
            //navigationService.Configure("Page2", new Uri("../Pages/Page2.xaml", UriKind.Relative));
            SimpleIoc.Default.Register<IFrameNavigation>(() => navigationService);
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public HomeViewModel HomeViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<HomeViewModel>();
            }
        }

        public Page1ViewModel Page1ViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<Page1ViewModel>();
            }
        }

        //public Page2ViewModel Page2ViewModel
        //{
        //    get
        //    {
        //        return ServiceLocator.Current.GetInstance<Page2ViewModel>();
        //    }
        //}       

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
} 
