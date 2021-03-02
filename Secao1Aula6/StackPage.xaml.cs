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
    public partial class StackPage : ContentPage
    {
        public StackPage()
        {
            InitializeComponent();

            //var layout = new StackLayout
            //{
            //    Spacing = 40,
            //    Padding = new Thickness(0, 10, 0, 0),
            //    Orientation = StackOrientation.Horizontal
            //};

            //layout.Children.Add(new Label { Text = "Label 1"});
            //layout.Children.Add(new Label { Text = "Label 2"});

            //Content = layout;
        }
    }
}