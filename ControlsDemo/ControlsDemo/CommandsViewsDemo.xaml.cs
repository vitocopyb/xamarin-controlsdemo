using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlsDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CommandsViewsDemo : ContentPage
    {
        public CommandsViewsDemo()
        {
            InitializeComponent();
        }

        private void BtnTest_Clicked(object sender, EventArgs e)
        {
            _ = DisplayAlert("My Alert", "Some Alert", "Ok");
        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton obj = (RadioButton)sender;
            _ = DisplayAlert("RadioButton", $"Changed: {obj.Content} - {e.Value}", "Ok");
        }

        private void SearchControl_SearchButtonPressed(object sender, EventArgs e)
        {
            _ = DisplayAlert("Searching", $"Searching: {searchControl.Text}", "Ok");
        }

        private void SwipeItem_Invoked(object sender, EventArgs e)
        {
            SwipeItem obj = (SwipeItem)sender;
            _ = DisplayAlert("SwipeView", $"Element Tapped: {obj.Text}", "Ok");
        }
    }
}