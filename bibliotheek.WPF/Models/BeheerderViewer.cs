﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace bibliotheek.WPF.Models
{
    class BeheerderViewer
    {

        public string Username { get; }
        public string AuthorName { get; }
        public string BookTitle { get; }
        public string BookDesciption { get; }
        public string BookType { get; }
        public string BookTags { get; }

        public BeheerderViewer(string username, string authorName, string bookTitle, string bookDesciption, string bookType, string bookTags)
        {
            Username = username;
            AuthorName = authorName;
            BookTitle = bookTitle;
            BookDesciption = bookDesciption;
            BookType = bookType;
            BookTags = bookTags;
        }

        public BeheerderViewer(string v)
        {
        }
    }
}
