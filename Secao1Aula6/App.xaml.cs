using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Secao1Aula6
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new QuotesPage();
            //MainPage = new StackPage();
            //MainPage = new GridPage();
            //MainPage = new AbsolutePage();
            //MainPage = new RelativePage();
            //MainPage = new ImagePage();
            //MainPage = new ImageExercise();

            //MainPage = new ListPage();

            //MainPage = new NavigationPage(new MPage())
            //{
            //    BackgroundColor = Color.Gray,
            //    BarTextColor = Color.White
            //};

            MainPage = new NavigationPage(new ContactPage())
            {
                BackgroundColor = Color.Gray,
                BarTextColor = Color.Orange
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
