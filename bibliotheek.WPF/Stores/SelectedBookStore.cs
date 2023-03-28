using bibliotheek.WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotheek.WPF.Stores
{
    internal class SelectedBookStore
    {
      private BookViewer _selectedBook;
      public BookViewer SelectedBook
        {
            get
            {
                return _selectedBook;
            }

            set
            {
                _selectedBook = value;
                SelectedBookChanged?.Invoke();
            }
        }

        public event Action SelectedBookChanged;
    }
}
