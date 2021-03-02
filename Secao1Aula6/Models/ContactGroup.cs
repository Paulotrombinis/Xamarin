using System;
using System.Collections.Generic;
using System.Text;

namespace Secao1Aula6.Models
{
    class ContactGroup : List<Contact>
    {
        public string Title{ get; set; }
        public string SortTitle { get; set; }

        public ContactGroup(string title, string ShortTitle )
        {
            Title = title;
            ShortTitle = ShortTitle;
        }
    }
}
