using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using AutoClicker.Views;

namespace AutoClicker.Services
{
    public class NavigationService : INavigationService
    {
        public void NavigateTo(Type viewType)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(viewType);
        }

        public void NavigateBack()
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.GoBack();
        }
    }
}