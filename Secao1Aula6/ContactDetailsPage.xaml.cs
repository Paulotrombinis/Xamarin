﻿using Secao1Aula6.Models;
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
    //public partial class ContactDetailsPage : ContentPage
    public partial class ContactDetailsPage : ContentPage
    {
        public ContactDetailsPage()
        {
            //BindingContext = contact;
            InitializeComponent();
        }
    }
}