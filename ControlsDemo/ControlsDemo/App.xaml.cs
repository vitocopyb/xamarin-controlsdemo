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
            //https://docs.microsoft.com/en-us/answers/questions/232062/binding-to-custom-control-button-command.html (ejemplo)
            //https://docs.microsoft.com/en-us/answers/questions/216766/bindableproperty-command-and-it-parameter-are-alwa.html

            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new ActivityIndicatorsDemo();
            MainPage = new CollectionsDemo();
            //MainPage = new CommandsViewsDemo();
            //MainPage = new InputViewsDemo();
            //MainPage = new PresentationViewsDemo();
            //MainPage = new TextViewsDemo();
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
