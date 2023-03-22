using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GreetMeButton_Clicked(object sender, EventArgs e)
        {
            string greeting = "Hello " + NameEntry.Text;
            GreetingLabel.Text = greeting;
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            SliderValueLabel.Text = ((Slider)sender).Value.ToString("F2");
        }

        private async void navigateToGridButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Clicked", "Kliknuli ste gumb za prijelaz na drugu\r\nstranicu!", "OK!");
            Navigation.PushAsync(new GridDemoPage());
        }

        private void navigateToBindingDemoButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DataBindingPage());
        }
    }
}
