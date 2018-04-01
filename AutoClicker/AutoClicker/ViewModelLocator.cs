using AutoClicker.Services;
using AutoClicker.ViewModels;

namespace AutoClicker
{
    public class ViewModelLocator
    {
        public static readonly INavigationService NavigationService = new NavigationService();
        public static HomePageViewModel HomePageViewModel { get; } = new HomePageViewModel(NavigationService);
        public static TestPageViewModel TestPageViewModel { get; } = new TestPageViewModel();
    }
}