using CISampleApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XamarinUniversity.Services;

namespace CISampleApp
{
    public partial class App : Application
    {
        static App()
        {
            // Register dependencies:
            DependencyService.Register<MainViewModel>();
            // Register standard XamU services:
            XamUInfrastructure.Init();
        }

        public App()
        {
            InitializeComponent();

            MainPage = new CISampleApp.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
