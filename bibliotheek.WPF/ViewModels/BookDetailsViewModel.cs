using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotheek.WPF.ViewModels
{
    public class BookDetailsViewModel : ViewModelBase
    {
        public String Username { get; }
        public String AuthorName { get; }
        public String BookTitle { get; }
        public String BookDesciption { get; }
        public String BookType { get; }
        public String BookTags { get; }

        public BookDetailsViewModel()
        {
            Username = "GDMaarten";
            AuthorName = "Maarten";
            BookTitle = "The nights";
            BookDesciption = "Hello my name is the night of nights";
            BookType = "funny";
            BookTags = "Comady";
        }

    }
}
