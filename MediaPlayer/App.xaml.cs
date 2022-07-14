using MediaManager;
using MediaPlayer.view;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MediaPlayer
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            CrossMediaManager.Current.Init();
            MainPage = new NavigationPage(new LandingPage());
        }

        protected override void OnStart()
        { 
    }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
