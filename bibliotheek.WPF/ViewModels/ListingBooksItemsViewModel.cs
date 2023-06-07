using bibliotheek.WPF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace bibliotheek.WPF.ViewModels
{
    public class ListingBooksItemsViewModel : ViewModelBase
    {
        public BookViewer SelectedBook { get;  }

        public string Username => SelectedBook.Username;
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }


        public ListingBooksItemsViewModel(BookViewer bookViewer)
        {
            SelectedBook = bookViewer;
        }

        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(field, newValue))
            {
                field = newValue;
                PropertyChanged += ListingBooksItemsViewModel_PropertyChanged;
                Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }

            return false;
        }

        private void Invoke(ListingBooksItemsViewModel listingBooksItemsViewModel, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            throw new NotImplementedException();
        }

        private void ListingBooksItemsViewModel_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private object listingBooksViewModel;

        public object ListingBooksViewModel { get => listingBooksViewModel; set => SetProperty(ref listingBooksViewModel, value); }
    }
}
