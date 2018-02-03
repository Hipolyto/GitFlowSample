using System;
using GitFlowSample.Views;
using Xamarin.Forms;

namespace GitFlowSample
{
    public partial class App : Application
    {
        public static bool UseMockDataStore = true;
        public static string BackendUrl = "https://localhost:5000";
        private string something = "32323";
        
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
