using System;
using System.Collections.Generic;
using GitFlowSample.ViewModels;
using Xamarin.Forms;

namespace GitFlowSample.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            
            BindingContext = new LoginViewModel();
        }
    }
}
