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
        private readonly SelectedBeheerderStore _selectedBeheerderStore;;

        private static BeheerderViewer SelectedBeheerderStore => _selectedBeheerderStore.SelectedBeheerderStore;


        public bool SelectedBeheerderStore => SelectedBeheerderStore != null;
        public string? Username => SelectedBeheerderStore?.Username;
        public string? AuthorName => SelectedBeheerderStore?.AuthorName;
        public string? BookTitle => SelectedBeheerderStore?.BookTitle;
        public string? BookDesciption => SelectedBeheerderStore?.BookDesciption;
        public string? BookType => SelectedBeheerderStore?.BookType;
        public string? BookTags => SelectedBeheerderStore?.BookTags;

        public BookDetailsViewModel(SelectedBeheerderStore selectedBeheerderStore)
        {
            _selectedBeheerderStore = selectedBeheerderStore;
        }
    }
}
