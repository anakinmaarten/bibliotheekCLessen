using bibliotheek.WPF.Models;
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
        private readonly BookViewer _selectedBookStore;

        public string Username => _bookViewer.Username;
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }


        public ListingBooksItemsViewModel(BookViewer _bookViewer)
        {
            _selectedBookStore = _bookViewer;
        }
    }
}
