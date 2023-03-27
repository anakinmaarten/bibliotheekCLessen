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

        public ListingBooksViewModel ListingBooksViewModel { get; }
        public BookDetailsViewModel BookDetailViewModel { get; }
        public ICommand AddBookCommand { get; }

        public BeheerderViewModel(SelectedBeheerderViewer _SelectedBeheerderViewer)
        {
            ListingBooksViewModel = new ListingBooksViewModel();
            BookDetailViewModel = new BookDetailsViewModel();
        }
    }
}
