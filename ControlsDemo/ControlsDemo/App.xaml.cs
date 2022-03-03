using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlsDemo
{
    public partial class App : Application
    {
        public App()
        {
            //TODO: Ver video sobre las propiedades en custom controls (BindableProperty)
            //https://www.youtube.com/watch?v=cbmoaD-PDtA
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new PresentationViewsDemo();
            //MainPage = new CommandsViewsDemo();
            MainPage = new InputViewsDemo();
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
