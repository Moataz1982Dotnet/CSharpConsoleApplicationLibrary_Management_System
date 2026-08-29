using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management__System
{
    public class Library :book
    {
        public List<book> Books = new List<book>();
        //Adds a book to the library.
        public void AddBook(string titlex, string authorx, string isbnx, bool isavalx)
        {
            book booka = new book();
            booka.Title = titlex;
            booka.Author = authorx;
            booka.ISBN = isbnx;
            booka.ISAvaliable = isavalx;
            Books.Add(booka);
        }
        //Lists all books in the library.
        public void ListBooks()
        {
            for (int i = 0; i < Books.Count; i++)
            {
                Console.WriteLine("The title : {0} , The author : {1} , The isbn : {2} , The isavailable : {3} ", base.Title, base.Author, base.ISBN, base.ISAvaliable);
            }
            
        }
        //Searches for books by title(case-insensitive).
        public book SearchByTitle(string title)
        {
            return Books.Find(b => b.Title == title);
        }
        //Marks a book as checked out (sets IsAvailable to false).
        public void CheckOutBook(book a)
        {
            a.ISAvaliable = false;
        }
    }
}
