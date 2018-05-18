using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TriviaExperiment.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TriviaExperiment
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

			MainPage = new LevelView();
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
