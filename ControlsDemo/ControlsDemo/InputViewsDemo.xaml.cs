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
    public partial class InputViewsDemo : ContentPage
    {
        public InputViewsDemo()
        {
            InitializeComponent();
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            Console.WriteLine($"Checked: {e.Value}");
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            stepper.Value = slider.Value;
            lblSlider.Text = slider.Value.ToString();
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            slider.Value = stepper.Value;
            lblSlider.Text = stepper.Value.ToString();
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            Console.WriteLine($"Toggled: {e.Value}");
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            Console.WriteLine($"DatePicker_DateSelected: OldDate {e.OldDate}");
            Console.WriteLine($"DatePicker_DateSelected: NewDate {e.NewDate}");
        }

        private void TimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var picker = (TimePicker)sender;

            if (e.PropertyName == "Time")
            {
                Console.WriteLine($"TimeChanged: {picker.Time}");

            }
        }
    }
}