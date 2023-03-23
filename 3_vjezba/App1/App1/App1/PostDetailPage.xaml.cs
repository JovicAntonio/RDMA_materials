using App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostDetailPage : ContentPage
    {
        Post selectedPost;
        public PostDetailPage(Post selectedPost)
        {
            InitializeComponent();
            this.selectedPost = selectedPost;
            ExpEntry.Text = selectedPost.Exp;
        }

        private async void DeleteButton_Clicked(object sender, EventArgs e)
        {
            using(SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Post>();
                int rows = conn.Delete(selectedPost);

                if (rows > 0) { await DisplayAlert("Success!", "Successfully delete Exp.", "OK!"); }
                await Navigation.PopAsync();

            }
        }
    }
}