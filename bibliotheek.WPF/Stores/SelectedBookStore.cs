using bibliotheek.WPF.Models;
using bibliotheek.WPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace bibliotheek.WPF.Stores
{
    class SelectedBookStore
    {
        private BeheerderViewer _SelectedBeheerderViewer;
        public BeheerderViewer BeheerderViewer
        {
            get
            {
                return _SelectedBeheerderViewer;
            }
            set
            {
                _SelectedBeheerderViewer = value;
                SelectedBeheerderViewerChanged?.Invoke();
            }
        }

        public event Action SelectedBeheerderViewerChanged;

    }
}
