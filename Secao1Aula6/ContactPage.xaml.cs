using Secao1Aula6.Models;
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
    //public partial class ContactPage : ContentPage
    public partial class ContactPage : MasterDetailPage
    {
        public ContactPage()
        {
            InitializeComponent();

            listView.ItemsSource = new List<Contact> {
            new Contact {Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/1"},
            new Contact {Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status ="Hey let´s talk!"}
            };
        }

        async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            if (e.SelectedItem == null) 
                return;

            var contact = e.SelectedItem as Contact;
            await Navigation.PushAsync(new ContactDetailsPage() { BindingContext = contact});
            //Navigation.PushAsync(new ContactDetailsPage() { Contact = contact});
            //Navigation.PushAsync(new ContactDetailsPage(contact));

            listView.SelectedItem = null;
        }
    }
}