using bibliotheek.WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotheek.WPF.Stores
{
    internal class SelectedBeheerderStore
    {
      private BeheerderViewer _selectedBeheerderStore;
      public BeheerderViewer SelectedBeheerderStore
        {
            get
            {
                return _selectedBeheerderStore;
            }

            set
            {
                _selectedBeheerderStore = value;
                SelectedBeheerderStoreChanged?.Invoke();
            }
        }

        public event Action SelectedBeheerderStoreChanged;
    }
}
