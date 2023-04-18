using GARBAGE.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GARBAGE.Context;
using GARBAGE.Models;

namespace GARBAGE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UserModel user = new UserModel();
            user.Role = 1;
            user.FirstName = "henk";
            user.LastName = "de Potvis";
            user.Phonenumber = 0641258339;

            user.AddUser(user);
        }
    }
}
