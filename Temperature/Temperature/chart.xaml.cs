using Microcharts;
using Newtonsoft.Json;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Temperature
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class chart : ContentPage
    {
        //public async void Temp()
        //{

        //    var httpClient = new HttpClient();
        //    var response = await httpClient.GetStringAsync("https://webapprouting.herokuapp.com/");
        //    if (response == null || response == "")
        //    {
        //        await DisplayAlert("Error", "Data could not be retrieved.The sensor is either " +
        //             "malfunctioning or is offline." + "Try another time", "OK");
        //    }

        //    var obj = JsonConvert.DeserializeObject<List<Temp>>(response);

        //    // temps = obj.ToList();

        //    //List<Temp> temps = obj.ToList();

        //    //if (obj.Length ==0) {
        //    //}


        //    //List<float> temperatures = new List<float>();
        //    // List<float> humidities = new List<float>();

        //    float sumTemp = 0;

        //    float sumHumi = 0;

        //    int counter = 0;

        //    foreach (Temp item in obj)
        //    {
        //        float temp = float.Parse(item.Temperature);
        //        float humi = float.Parse(item.Humidity);

        //        sumTemp += temp;
        //        sumHumi += humi;

        //        counter += 1;
        //    }

        //    float avgTemp = sumTemp / counter;

        //    float avgHumi = sumHumi / counter;


        //}


        //private readonly ChartEntry[] entries = new[]
        //{

        //    new ChartEntry(avgTemp)
        //    {
        //        Label="Avg Temp",
        //        ValueLabel = avgTemp.ToString(),
        //        Color = SKColor.Parse("#dc143c")
        //    },

        //     new ChartEntry(avgHumi)
        //    {
        //        Label="Avg Humi",
        //        ValueLabel = avgHumi.ToString(),
        //        Color = SKColor.Parse("#4169e1")
        //    }
        //};

        //public chart()
        //{

        //    InitializeComponent();
        //    Temp();
        //    chartViewBar.Chart = new BarChart
        //    {
        //        Entries = entries,
        //        LabelOrientation = Orientation.Horizontal,
        //        LabelTextSize = 30,
        //        IsAnimated = true,
        //        AnimationProgress = 3,
        //        //LabelColor = SKColor.Parse("#FFFFFF"),
        //        ValueLabelOrientation = Orientation.Horizontal
        //    };
        //}


    }
}