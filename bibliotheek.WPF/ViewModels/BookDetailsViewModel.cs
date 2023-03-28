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
        private readonly SelectedBookStore _selectedBook;

        private static BookViewer SelectedBook => _selectedBook.SelectedBook;


        public bool HasSelectedBook => SelectedBook != null;

        public string? Username => _selectedBook?.Username;
        public string? AuthorName => _selectedBook?.AuthorName;
        public string? BookTitle => _selectedBook?.BookTitle;
        public string? BookDesciption => _selectedBook?.BookDesciption;
        public string? BookType => _selectedBook?.BookType;
        public string? BookTags => _selectedBook?.BookTags;

        public BookDetailsViewModel(SelectedBookStore selectedBook)
        {
            _selectedBook = selectedBook;
        }
    }
}
