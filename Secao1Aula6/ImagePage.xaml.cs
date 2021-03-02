using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Secao1Aula6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();

            //image.Source
            //var imageSource = ImageSource.FromUri(new Uri("http://"));

            //var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/7") };

            //imageSource.CachingEnabled = false;
            //imageSource.CacheValidity = TimeSpan.FromHours(1);

            //image.Source = imageSource;

            //image.Source = ImageSource.FromResource("Secao1Aula6.Images.background.jpg");

            //implicite convert to imageSource
            //image.Source = "http://...";

            //btn.ImageSource = (FileImageSource)ImageSource.FromFile(Device.OnPlatform(
            //    iOS: "clock.png",
            //    Android: "clock.png",
            //    WinPhone: "Images/clock.pgn"
            //    ));

        }
    }
}