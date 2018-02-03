using System;
using GitFlowSample.Models;
using GitFlowSample.Services;
using GitFlowSample.Views;
using Xamarin.Forms;

namespace GitFlowSample.ViewModels
{

    /// <summary>
    /// Login view model.
    /// </summary>
    public class LoginViewModel : BaseViewModel
    {
        private string _Email;
        private string _Password;
        private Command _loginCommand;
        
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                if (_Email != value)
                {
                    _Email = value;
                    OnPropertyChanged(Email);
                    OnLoginCommand.ChangeCanExecute();
                }
            }
        }
        
        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                if (_Password != value)
                {
                    _Password = value;
                    OnPropertyChanged(Password);
                    OnLoginCommand.ChangeCanExecute();
                }
            }
        }
        
        public Command OnLoginCommand
        {
            get
            {
                return _loginCommand ?? (_loginCommand = new Command(ExecuteLoginCommand, CanLogin));
            }

        }

        /// <summary>
        /// Cans the login.
        /// </summary>
        /// <returns><c>true</c>, if login was caned, <c>false</c> otherwise.</returns>
        private bool CanLogin()
        {
            if (string.IsNullOrEmpty(Email))
            {
                 return false;
            }
            else if (string.IsNullOrEmpty(Password))
            {
                 return false;
            }
        
            return true;
        }

        /// <summary>
        /// Executes the login command.
        /// </summary>
        /// <param name="obj">Object.</param>
        private void ExecuteLoginCommand()
        {
            var userRequest = new UserItem();
            userRequest.Email = Email;
            userRequest.Password = Password;
            
            var isLogin = UserManager.Login(userRequest);
            
            if (isLogin)
            {
                Application.Current.MainPage.Navigation.PushAsync(new MainPage());
            }
        }
    }
}
