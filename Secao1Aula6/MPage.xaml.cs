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
    public partial class MPage : ContentPage
    {
        public MPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new IntroductonPage());
            await Navigation.PushModalAsync(new IntroductonPage());
        }
    }
}