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
        private readonly BookViewer _selectedBook;

        public string Username => _selectedBook.Username;
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }


        public ListingBooksItemsViewModel(BookViewer bookViewer)
        {
            _selectedBook = bookViewer;
        }
    }
}
