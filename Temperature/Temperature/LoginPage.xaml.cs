using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Temperature
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            string adminUsername = "MyAdmin";
            string adminPassword = "MyStrongPassword!";

            if (username.Text == adminUsername && password.Text == adminPassword)
            {
                await Navigation.PushAsync(new MainPage());

            }

            else
            {
                await DisplayAlert("Cannot Log In", "Incorrect username or password.", "OK");
            }
        }
    }
}