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
        }

        public async void Temp()
        {

            var httpClient = new HttpClient();
                var response = await httpClient.GetStringAsync("https://webapprouting.herokuapp.com/");
                if (response == null || response == "")
                {
                    await DisplayAlert("Error", "Data could not be retrieved.The sensor is either " +
                         "malfunctioning or is offline." + "Try another time", "OK");
                }

                var temp = JsonConvert.DeserializeObject<List<Temp>>(response);

                collectionView.ItemsSource = temp;         
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Temp();
        }

        private async void Humidity_Clicked(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://webapprouting.herokuapp.com/");
            if (response == null || response == "")
            {
                await DisplayAlert("Error", "Data could not be retrieved.The sensor is either " +
                     "malfunctioning or is offline." + "Try another time", "OK");
            }

            var obj = JsonConvert.DeserializeObject<List<Temp>>(response);

            float sumHumi = 0;

            int counter = 0;

            foreach (Temp item in obj)
            {
                float humi = float.Parse(item.Humidity);

                sumHumi += humi;

                counter += 1;
            }

            float avgHumi = sumHumi / counter;

            await DisplayAlert("Humidity", "The average Humidity is: " + avgHumi.ToString() + "\n Number of Readings: " + counter.ToString(), "OK");
        }

        private async void Temperature_Clicked(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://webapprouting.herokuapp.com/");
            if (response == null || response == "")
            {
                await DisplayAlert("Error", "Data could not be retrieved.The sensor is either " +
                     "malfunctioning or is offline." + "Try another time", "OK");
            }

            var obj = JsonConvert.DeserializeObject<List<Temp>>(response);


            float sumTemp = 0;

            int counter = 0;

            foreach (Temp item in obj)
            {
                float temp = float.Parse(item.Temperature);

                sumTemp += temp;

                counter += 1;
            }

            float avgTemp = sumTemp / counter;

            await DisplayAlert("Temperature", "The average temperature is: " + avgTemp.ToString() + "\n Number of Readings: "+counter.ToString(), "OK");
        }
    }
}
