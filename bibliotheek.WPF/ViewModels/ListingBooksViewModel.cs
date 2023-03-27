using bibliotheek.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotheek.WPF.ViewModels
{
    public class ListingBooksViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ListingBooksItemsViewModel> _ListingBooksItemsViewModel;

        public IEnumerable<ListingBooksItemsViewModel> ListingBooksItemsViewModel => _ListingBooksItemsViewModel;

        public ListingBooksViewModel(SelectedBookStore _SelectedBeheerderViewer)
        {
            _ListingBooksItemsViewModel = new ObservableCollection<ListingBooksItemsViewModel>();

            _ListingBooksItemsViewModel.Add(new ListingBooksItemsViewModel("Hungergames 1"));
            _ListingBooksItemsViewModel.Add(new ListingBooksItemsViewModel("Hungergames 2"));
            _ListingBooksItemsViewModel.Add(new ListingBooksItemsViewModel("Hungergames 3"));
            _ListingBooksItemsViewModel.Add(new ListingBooksItemsViewModel("Hungergames 4"));
            _ListingBooksItemsViewModel.Add(new ListingBooksItemsViewModel("Hungergames 5"));
            _ListingBooksItemsViewModel.Add(new ListingBooksItemsViewModel("Hungergames 6"));
        }
    }
}
