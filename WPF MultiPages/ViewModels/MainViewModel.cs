using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using WPF_MultiPages.Navigation;

namespace WPF_MultiPages.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private IFrameNavigation _navigationService;
        
        private RelayCommand _loadedCommand;
        public RelayCommand LoadedCommand
        {
            get
            {
                return _loadedCommand
                    ?? (_loadedCommand = new RelayCommand(
                    () =>
                    {
                        _navigationService.NavigateTo("Home");                        
                    }));
            }
        }

        private RelayCommand _welcomePageOpenCommand;
        public RelayCommand WelcomePageOpenCommand
        {
            get
            {
                return _welcomePageOpenCommand
                    ?? (_welcomePageOpenCommand = new RelayCommand(
                    () =>
                    {
                        _navigationService.NavigateTo("Page1");
                    }));
            }
        }

        private RelayCommand _testPageOpenCommand;
        public RelayCommand TestPageOpenCommand
        {
            get
            {
                return _testPageOpenCommand
                    ?? (_testPageOpenCommand = new RelayCommand(
                    () =>
                    {
                        _navigationService.NavigateTo("Page1");
                    }));
            }
        }

        public MainViewModel(IFrameNavigation navigationService)
        {
            _navigationService = navigationService;
        }
    }
}