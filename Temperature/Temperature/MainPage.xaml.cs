using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Windows.Input;
using static Android.Graphics.ImageDecoder;

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
            //DayOfWeek today = DateTime.Today.DayOfWeek;
            //DayOfWeek lastweek = today - 14;
            //String stringWeek = lastweek.ToString("d");

            //String stringToday = today.ToString("d");

            //var myTempObj = new Temp();
            //var myTime = new Binding("Timestamp1").ToString();

            //var day = DateTime.Parse(myTime.Substring(myTime.Length - 11));
            //DayOfWeek day1 = day.DayOfWeek;

            //String dayString = day1.ToString("d");
           
                var httpClient = new HttpClient();
                var response = await httpClient.GetStringAsync("https://webapprouting.herokuapp.com/");
                if (response == null || response == "")
                {
                    await DisplayAlert("Error", "Data could not be retrieved.The sensor is either " +
                         "malfunctioning or is offline." + "Try another time", "OK");
                }


            //if (lastweek <= day1 && day1 <= today)
            //{
                var temp = JsonConvert.DeserializeObject<List<Temp>>(response);
                collectionView.ItemsSource = temp;
            //}
                
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Temp();
        }

        private async void ChartsBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new chart());
        }
    }
}
