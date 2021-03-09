using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using WPF_MultiPages.Navigation;

namespace WPF_MultiPages.ViewModels
{
    public class Page1ViewModel : ViewModelBase
    {
        private IFrameNavigation _navigationService;
        private string _page1Text = "Page 1";
        public string Page1Text
        {
            get
            {
                return _page1Text;
            }

            set
            {
                if (_page1Text == value)
                {
                    return;
                }

                _page1Text = value;
                RaisePropertyChanged();
            }
        }
        private RelayCommand _homeCommand;
        public RelayCommand HomeCommand
        {
            get
            {
                return _homeCommand
                    ?? (_homeCommand = new RelayCommand(
                    () =>
                    {
                        _navigationService.NavigateTo("Home");
                    }));
            }
        }

        public Page1ViewModel(IFrameNavigation navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
        
  