using App1.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class newTravelPage : ContentPage
    {
        public newTravelPage()
        {
            InitializeComponent();
        }
        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Post post = new Post()
            {
                Exp = ExpEntry.Text
            };
            SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
            conn.CreateTable<Post>();
            var rows = conn.Insert(post);
            conn.Close();
            if (rows > 0)
            {
                await DisplayAlert("Success.", "Exp successfully inserted!", "OK!");

            }
            await Navigation.PopAsync();

        }
    }
}