using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void loginButton_Clicked(object sender, EventArgs e)
        {
            bool isEmailEmpty = string.IsNullOrWhiteSpace(userEntry.Text);
            bool isPassEmpty = string.IsNullOrWhiteSpace(passEntry.Text);
            if(!isEmailEmpty && !isPassEmpty) { 
            await Navigation.PushAsync(new HomePage());
            }
            else {
                await DisplayAlert("Email and password required", "Please enter both your Email and your Password", "OK");
            }

        }
    }
}
