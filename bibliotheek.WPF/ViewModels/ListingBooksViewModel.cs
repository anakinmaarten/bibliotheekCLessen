using bibliotheek.WPF.Models;
using bibliotheek.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace bibliotheek.WPF.ViewModels
{
    public class ListingBooksViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ListingBooksItemsViewModel> _ListingBooksItemsViewModel;
        private readonly SelectedBookStore _selectedBook;

        public IEnumerable<ListingBooksItemsViewModel> ListingBooksItemsViewModel => _ListingBooksItemsViewModel;


        private ListingBooksItemsViewModel _selectedBookListingItemViewModel;
        public ListingBooksItemsViewModel SelectedBookListingItemViewModel
        {
            get
            {
                return _selectedBookListingItemViewModel;
            }
             set
             {
                _selectedBookListingItemViewModel = value;
                OnPropertyChanged(nameof(SelectedBookListingItemViewModel));

                _selectedBook.SelectedBook = _selectedBook.SelectedBook.SelectedBook;
             }
             }

        public ListingBooksViewModel(SelectedBookStore selectedBook)
        {

            _selectedBook = selectedBook;

            _ListingBooksItemsViewModel = new ObservableCollection<ListingBooksItemsViewModel>();

            _ListingBooksItemsViewModel.Add(new ListingBooksItemsViewModel(new BookViewer("Hungergames 1")));
            _ListingBooksItemsViewModel.Add(new ListingBooksItemsViewModel(new BookViewer("Hungergames 2")));
            _ListingBooksItemsViewModel.Add(new ListingBooksItemsViewModel(new BookViewer("Hungergames 4")));
            _ListingBooksItemsViewModel.Add(new ListingBooksItemsViewModel(new BookViewer("Hungergames 5")));
            _ListingBooksItemsViewModel.Add(new ListingBooksItemsViewModel(new BookViewer("Hungergames 6")));
            _ListingBooksItemsViewModel.Add(new ListingBooksItemsViewModel(new BookViewer("Hungergames 7")));
            
        }
    }
}
