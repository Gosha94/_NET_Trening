using GalaSoft.MvvmLight.Views;

namespace WPF_MultiPages.Navigation
{
    public interface IFrameNavigation : INavigationService
    {
        object Parameter { get; }
    }
}