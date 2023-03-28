using bibliotheek.WPF.Models;
using bibliotheek.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace bibliotheek.WPF.ViewModels
{
    class BeheerderViewModel : ViewModelBase
    {
        private BookViewer _selectedBook;

        public ListingBooksViewModel ListingBooksViewModel { get; }
        public BookDetailsViewModel BookDetailViewModel { get; }
        public ICommand AddBookCommand { get; }

        public BeheerderViewModel(SelectedBookStore _selectedBookStore, BookViewer _selectedBook)
        {

            ListingBooksViewModel = new ListingBooksViewModel(_selectedBookStore);
            BookDetailViewModel = new BookDetailsViewModel(_selectedBook);
        }
    }
}
