using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_tutorial.Classes
{
    public class Book : Thing
    {
        public Book(string name, string itemId, string title, string author, int numberOfPages)
        {
            Name = name;
            ItemId = "B-" + itemId;
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
            Value = numberOfPages * 1.25;
        }

        private string _title;
        private string _author;
        private int _numberOfPages;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }

        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
            }
        }

        public int NumberOfPages
        {
            get
            {
                return _numberOfPages;
            }
            set
            {
                _numberOfPages = value;
            }
        }

    }
}
