using System;
using System.Collections.Generic;
using GitFlowSample.Models;
using GitFlowSample.Services;

using Xamarin.Forms;

namespace GitFlowSample.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            var userRequest = new UserItem();             userRequest.Email = txtEmail.Text;             userRequest.Password = txtPass.Text;                          var isLogin = UserManager.Login(userRequest);                          if (isLogin)             {                  await Navigation.PushAsync(new MainPage());             }
            
           
        }
    }
}
