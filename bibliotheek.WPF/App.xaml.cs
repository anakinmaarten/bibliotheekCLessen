using bibliotheek.WPF.Models;
using bibliotheek.WPF.Stores;
using bibliotheek.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace bibliotheek.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private readonly SelectedBookStore _selectedbook;

        public App()
        {
            _selectedbook = new SelectedBookStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new BeheerderViewModel(_SelectedBeheerderViewer)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
