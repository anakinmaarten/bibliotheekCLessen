using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace bibliotheek.WPF.ViewModels
{
    public class ListingBooksItemsViewModel : ViewModelBase
    {
        public string Username { get; }
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public ListingBooksItemsViewModel(string username)
        {
            Username = username;

        }
    }
}
