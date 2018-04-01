using System.Windows.Input;
using AutoClicker.Services;
using AutoClicker.Utilities;
using AutoClicker.Views;

namespace AutoClicker.ViewModels
{
    public class HomePageViewModel
    {
        #region Properties, Fields & Events

        #endregion
        public HomePageViewModel(INavigationService navigationService)
        {
            
        }
        #region Commands
        public ICommand NavigateAboutCommand { get; set; }
        #endregion

        #region Actions & Predicates

        private bool CanNavigateAbout(object obj)
        {
            return true;
        }

        private void NavigateAbout(object obj)
        {
            //this.ContentFrame.Navigate(typeof(TestPage));
        }
        #endregion

        #region Methods

        public void LoadCommands()
        {
            NavigateAboutCommand = new GenericCommand(NavigateAbout, CanNavigateAbout);
        }
        #endregion
    }
}