using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using WPF_MultiPages.Navigation;

namespace WPF_MultiPages.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private IFrameNavigation _navigationService;
        private string _myProperty = "HomeViewText";
        public string MainPageText
        {
            get
            {
                return _myProperty;
            }

            set
            {
                if (_myProperty == value)
                {
                    return;
                }

                _myProperty = value;
                RaisePropertyChanged();
            }
        }
        private RelayCommand _page1Command;
        public RelayCommand Page1Command
        {
            get
            {
                return _page1Command
                    ?? (_page1Command = new RelayCommand(
                    () =>
                    {
                        _navigationService.NavigateTo("Page1");
                    }));
            }
        }
        private RelayCommand _page2Command;

        public RelayCommand Page2Command
        {
            get
            {
                return _page2Command
                       ?? (_page2Command = new RelayCommand(
                           () =>
                           {
                               _navigationService.NavigateTo("Page2");
                           }));
            }
        }

        public HomeViewModel(IFrameNavigation navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
