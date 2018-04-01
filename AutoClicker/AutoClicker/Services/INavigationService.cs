using System;

namespace AutoClicker.Services
{
    public interface INavigationService
    {
        void NavigateTo(Type type);
        void NavigateBack();
    }
}