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
        private readonly SelectedBookStore _selectedBeheerderViewer;

        private static BeheerderViewer SelectedBeheerderViewer => _selectedBeheerderViewer.SelectedBeheerderViewer;

        public string? Username => SelectedBeheerderViewer?.Username;
        public string? AuthorName => SelectedBeheerderViewer?.AuthorName;
        public string? BookTitle => SelectedBeheerderViewer?.BookTitle;
        public string? BookDesciption => SelectedBeheerderViewer?.BookDesciption;
        public string? BookType => SelectedBeheerderViewer?.BookType;
        public string? BookTags => SelectedBeheerderViewer?.BookTags;

        public BookDetailsViewModel(SelectedBookStore SelectedBeheerderViewer)
        {
            _selectedBeheerderViewer = SelectedBeheerderViewer;
        }

    }
}
