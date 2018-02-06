using System;
using GitFlowSample.Views;
using Xamarin.Forms;

namespace GitFlowSample
{
    public partial class App : Application
    {
        public static bool UseMockDataStore = true;
        public static string BackendUrl = "https://localhost:5000";
        //ultimo
        private string Something = "Luis";
        
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage())
    {
        BarBackgroundColor = Color.Green,
        BarTextColor = Color.White,
    };
        }
    }
}
