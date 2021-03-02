using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Secao1Aula6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            slider.Value = 0.5;
            
            //if (Device.RuntimePlatform == Device.iOS)
            //    Padding == new Thickness(0, 20, 0, 0);

            //Padding = new Thickness(5, (Device.RuntimePlatform == Device.iOS ? 20 : 5), 5, 5);

            //Device.RuntimePlatform(Device.iOS: () => { });


            //Content = new Label
            //{
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center,
            //    Text = "Hello world"

            //};

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Title", "Hello world", "Ok");
        }

        //private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    label.Text = String.Format("Value is {0:F2}", e.NewValue);
        //}
    }
}
