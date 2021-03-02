using Secao1Aula6.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Secao1Aula6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        //Para mostrar a exclusão na tela, utilizar ObservableCollection
        //private List<Contact>  _contacts = new List<Contact>();

        private ObservableCollection<Contact> _contacts;

        public ListPage()
        {
            InitializeComponent();

            //var names = new List<string>
            //{
            //    "Paulo",
            //    "Mosh",
            //    "John",
            //    "Bob"
            //};

            //ListView.ItemsSource = names;

            //ListView.ItemsSource = new List<Contact> {
            //new Contact {Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/1"},
            //new Contact {Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status ="Hey let´s talk!"}
            //};

            _contacts = new ObservableCollection<Contact>   {
            new Contact {Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/1"},
            new Contact {Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status ="Hey let´s talk!"}
            };

            ListView.ItemsSource = _contacts;

            //ListView.ItemsSource = new List<ContactGroup> {
            //    new ContactGroup("M","M")
            //    {
            //        new Contact {Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/1"}
            //    },

            //new ContactGroup("J", "J")
            //    {
            //        new Contact {Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status ="Hey let´s talk!"},
            //        new Contact {Name = "Joseph", ImageUrl = "http://lorempixel.com/100/100/people/3", Status ="Hey look around!"}
            //    }
            //};
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //var contact = e.Item as Contact;

            //DisplayAlert("Tapped", contact.Name, "OK");
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //var contact = e.SelectedItem as Contact;


            //DisplayAlert("Selected",contact.Name,"OK");

            ListView.SelectedItem = null;
        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Contact", contact.Name, "OK");
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;

            _contacts.Remove(contact);

        }

        private void ListView_Refreshing(object sender, EventArgs e)
        {

        }

        private void PullToRefresh_Refreshing(object sender, EventArgs e)
        {
            ListView.ItemsSource = GetContacts();

            //ListView.IsRefreshing = false;
            ListView.EndRefresh();

        }

        IEnumerable<Contact> GetContacts(string searchText = null)
        {
            var contacts = new List<Contact>   {
            new Contact {Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/1"},
            new Contact {Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status ="Hey let´s talk!"}
            };

            if (String.IsNullOrWhiteSpace(searchText))
                return contacts;

            return contacts.Where(c => c.Name.ToLower().Contains(searchText.ToLower()));
            //return contacts.Where(c => c.Name.ToLower().StartsWith(searchText.ToLower()));
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListView.ItemsSource = GetContacts(e.NewTextValue);
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            ListView.ItemsSource = GetContacts();
        }
    }
}