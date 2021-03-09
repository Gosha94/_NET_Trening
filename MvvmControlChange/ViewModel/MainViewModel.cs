using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace MvvmControlChange.ViewModel
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
    public class MainViewModel : ViewModelBase
    {

        private string _textVal = "Change me";
        public string TextVal
        {
            get { return _textVal; }
            set { Set(() => TextVal, ref _textVal, value); }
        }

        public MainViewModel()
        {
            OnTextChangeButtonClickedCommand = new RelayCommand(OnTextChangeButtonClickedHandler);
        }
        public RelayCommand OnTextChangeButtonClickedCommand { get; private set; }

        private void OnTextChangeButtonClickedHandler()
        {
            TextVal = "Hello MVVM light.";
        }
    }
}