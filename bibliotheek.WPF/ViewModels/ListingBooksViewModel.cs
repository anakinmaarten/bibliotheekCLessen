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
        private readonly SelectedBookStore SelectedBook;

        public IEnumerable<ListingBooksItemsViewModel> ListingBooksItemsViewModel => _ListingBooksItemsViewModel;


        private ListingBooksItemsViewModel _SelectedBeheerderListingItemViewModel;
        public ListingBooksItemsViewModel SelectedBeheerderListingItemViewModel
        {
            get
            {
                return _SelectedBeheerderListingItemViewModel;
            }
             set
             {
                _SelectedBeheerderListingItemViewModel = value;
                OnPropertyChanged(nameof(SelectedBeheerderListingItemViewModel));

                _selectedBook.SelectedBookViewer = new BookViewer();
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
