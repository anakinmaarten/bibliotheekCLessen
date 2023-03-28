using bibliotheek.WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace bibliotheek.WPF.ViewModels
{
    public class ListingBooksItemsViewModel : ViewModelBase
    {
        private readonly BeheerderViewer _beheerderViewer;

        public string Username => _beheerderViewer.Username;
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }


        public ListingBooksItemsViewModel(BeheerderViewer beheerderViewer)
        {
            _beheerderViewer = beheerderViewer;
        }
    }
}
