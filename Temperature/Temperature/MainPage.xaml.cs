using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;



namespace Temperature
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Temp();
        }

        public async void Temp()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://webapprouting.herokuapp.com/");
            if (response == null || response == "")
            {
                await DisplayAlert("Error","Data could not be retrieved.The sensor is either " +
                     "malfunctioning or is offline." + "Try another time","OK");
            }
            var temp = JsonConvert.DeserializeObject<List<Temp>>(response);
            ListTemp.ItemsSource = temp;

        }
    }
}
