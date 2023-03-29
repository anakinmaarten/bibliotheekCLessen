using bibliotheek.WPF.Models;
using bibliotheek.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotheek.WPF.ViewModels
{
    public class BookDetailsViewModel : ViewModelBase
    {
        private readonly BookViewer _selectedBook;

        private BookViewer SelectedBook => _selectedBook;

        /// Start Forum info... things you need to fill in for the data base/ things that you will be abele to see!
        public bool HasSelectedBook => SelectedBook != null;

        public string? Username => _selectedBook?.Username;
        public string? AuthorName => _selectedBook?.AuthorName;
        public string? BookTitle => _selectedBook?.BookTitle;
        public string? BookDesciption => _selectedBook?.BookDesciption;
        public string? BookType => _selectedBook?.BookType;
        public string? BookTags => _selectedBook?.BookTags;
        /// end Forum info... things you need to fill in for the data base/ things that you will be abele to see!
        /// Start Check "selected book" is selected/ add new book funtion
        public BookDetailsViewModel(BookViewer selectedBook)
        {
            _selectedBook = selectedBook;

            _selectedBook.SelectedBookChanged += SelectedBook_SelectedBookChanged;
        }
        /// end Check "selected book" is selected/ add new book funtion
        /// Start Delete funtion

        protected override void Dispose()
        {
            _selectedBook.SelectedBookChanged -= SelectedBook_SelectedBookChanged;
            base.Dispose();
        }

        /// end Delete funtion
        /// Start change/add funtion
        private void SelectedBook_SelectedBookChanged()
        {
            OnPropertyChanged(nameof(HasSelectedBook));
            OnPropertyChanged(nameof(Username));
            OnPropertyChanged(nameof(AuthorName));
            OnPropertyChanged(nameof(BookTitle));
            OnPropertyChanged(nameof(BookDesciption));
            OnPropertyChanged(nameof(BookType));
            OnPropertyChanged(nameof(BookTags));
        }
        /// end change/add funtion
    }
}
