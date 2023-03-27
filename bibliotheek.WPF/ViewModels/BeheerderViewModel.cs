﻿using bibliotheek.WPF.Stores;
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
        private SelectedBookStore selectedBeheerderViewer;

        public ListingBooksViewModel ListingBooksViewModel { get; }
        public BookDetailsViewModel BookDetailViewModel { get; }
        public ICommand AddBookCommand { get; }

        public BeheerderViewModel(SelectedBookStore _SelectedBeheerderViewer)
        {

            ListingBooksViewModel = new ListingBooksViewModel(_SelectedBeheerderViewer);
            BookDetailViewModel = new BookDetailsViewModel(_SelectedBeheerderViewer);
        }
    }
}
