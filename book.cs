using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management__System
{
    public class book
    {
        private string title;
        private string author;
        private string isbn;
        private bool isavailable;

        public string Title
        {
            get { return title; }
            set
            {
                if (value == "")
                    throw new ArgumentOutOfRangeException(nameof(value), "Title cannot be null");
                title = value;
            }
        }
        public string Author
        {
            get { return author; }
            set
            {
                if (value == "")
                    throw new ArgumentOutOfRangeException(nameof(value), "Author cannot be null");
                author = value;
            }
        }
        public string ISBN
        {
            get { return isbn; }
            set
            {
                if (value == "")
                    throw new ArgumentOutOfRangeException(nameof(value), "isbn cannot be null");
                isbn = value;
            }
        }
        public bool ISAvaliable
        {
            get { return isavailable; }
            set
            {
                isavailable = value;
            }
       }

        //public book(string titlex, string authorx, string isbnx, bool isavalx)
        //{
        //    title = titlex;
        //    author = authorx;
        //    isbn = isbnx;
        //    isavailable = isavalx;
        //}
    }
}
