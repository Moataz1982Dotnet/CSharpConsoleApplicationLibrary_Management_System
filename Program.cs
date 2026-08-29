using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Library_Management__System
{
    class Program
    {
        static void AddBook()
        {
            Console.Clear();
            Console.WriteLine("\n   ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "\n\n");
            Console.WriteLine("\t\t\t\t    Moataz Library Management System  ");
            Console.WriteLine("\t\t\t\t    ================================  \n\n");
            Console.WriteLine("\t\t\t\t      Books : Add Form          ");
            Console.WriteLine("\t\t\t\t          ========      \n\n\n\n");
            Console.Write("\t\tEnter the Count of Books you want to Add  :   ");
            int BookCount = 0;
            try
            {
                BookCount = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("You Entered An Invalid numbers >>>> Please Enter a Number From 1 - 10 ");
                Thread.Sleep(1000);
                AddBook();
            }
            for (int i = 0; i < BookCount; i++)
            {
                Console.Write("\t\t\tEnter the Book #{0} Title : ", i + 1);
                string BookName = Console.ReadLine();
                Console.Write("\t\t\tEnter the Book #{0} Author : ", i + 1);
                string BookAuthor = Console.ReadLine();
                Console.Write("\t\t\tEnter the Book #{0} isbn : ", i + 1);
                string Bookisbn = Console.ReadLine();
                Console.Write("\t\t\tEnter the Book #{0} is Avaliable (say <yes> or <no>) : ", i + 1);
                string BiA = Console.ReadLine();

                bool BookisAvaliable = false;
                if ((BiA == "yes")||(BiA == "y"))
                {
                    BookisAvaliable = true;
                }
                else
                {
                    BookisAvaliable = false;
                }

                Console.Write("\n");
                Library lib = new Library();
                lib.AddBook(BookName, BookAuthor, Bookisbn, BookisAvaliable);
            }
            Console.Write("\n\t Do you want to do anything else or logout ? (say <yes> or <no>)  :  ");
            string answer1 = Console.ReadLine();
            if ((answer1 == "yes") || (answer1 == "y"))
            {
                Console.Clear();
                StartPage();
            }
            else if ((answer1 == "no") || (answer1 == "n"))
            {
                Console.Clear();
                EndPage();
            }
            Console.ReadKey();
        }
        static void ListBooks()
        {
            Console.Clear();
            Console.WriteLine("\n   ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "\n\n");
            Console.WriteLine("\t\t\t\t    Moataz Student Management System  ");
            Console.WriteLine("\t\t\t\t    ================================  \n\n");
            Console.WriteLine("\t\t\t\t             Books : ListBooks          ");
            Console.WriteLine("\t\t\t\t          =======================      \n\n\n\n");
            Library lib = new Library();
            lib.ListBooks();

            Console.Write("\n\t Do you want to do anything else or logout ? (say <yes> or <no>)  :  ");
            string answer1 = Console.ReadLine();
            if ((answer1 == "yes") || (answer1 == "y"))
            {
                Console.Clear();
                StartPage();
            }
            else if ((answer1 == "no") || (answer1 == "n"))
            {
                Console.Clear();
                EndPage();
            }
            Console.ReadKey();
        }
        static void StartPage()
        {
            Console.Clear();
            Console.WriteLine("\n   ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "\n\n");
            Console.WriteLine("\t\t\t\t    Moataz Library Management System  ");
            Console.WriteLine("\t\t\t\t    ================================  \n\n");
            Console.WriteLine("\t\t\t\t          Main Form          ");
            Console.WriteLine("\t\t\t\t          =========      \n\n\n\n");
            Console.WriteLine("Please Select the id of Operation You Want To Do: ");
            Console.WriteLine("1-Add Book ");
            Console.WriteLine("2-List all Books ");
            Console.WriteLine("3-Search for a book by its title ");
            Console.WriteLine("4-Check out a book ");
            int OperationId = 0;
            try
            {
                Console.Write("\nThe Operation id : ");
                OperationId = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("You Entered An Invalid Choice... Please Enter Numbers from 1-4 ");
            }
            if (OperationId == 1)
            {
                AddBook();
            }
            else if (OperationId == 2)
            {
                ListBooks();
            }
            else if (OperationId == 3)
            {
                Searchforabookbyitstitle();
            }
            else if (OperationId == 4)
            {
                CheckAbookAsUnAvaliable();
            }
            else
            {
                Console.WriteLine("You Entered an Invalid Operation Id...");
            }
        }
        static void EndPage()
        {
            Console.Clear();
            Console.WriteLine("\n   ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "\n\n");
            Console.WriteLine("\t\t\t\t    Moataz Library Management System  ");
            Console.WriteLine("\t\t\t\t    ================================  ");
            Console.WriteLine("\t\t\t\t    ================================  ");
            Console.WriteLine("\t\t\t\t              The End                 ");
            Console.WriteLine("\t\t\t\t    ================================  ");
            Console.WriteLine("\t\t\t\t    ================================  ");
            Console.WriteLine("\t\t\t\t    ================================  ");
            Console.WriteLine("\t\t\t\t    ================================  ");
            Console.ReadKey();
        }
        static void Searchforabookbyitstitle()
        {
            Console.Clear();
            Console.WriteLine("\n   ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "\n\n");
            Console.WriteLine("\t\t\t\t    Moataz Library Management System  ");
            Console.WriteLine("\t\t\t\t    ================================  \n\n");
            Console.WriteLine("\t\t\t\t      Books : Search for a book by its title.          ");
            Console.WriteLine("\t\t\t\t              =======================      \n\n\n\n");
            Console.Write("\t\tEnter the Name of Book you want to find : ");
            string bookTitle = Console.ReadLine();
            Library lib = new Library();
            book x = null;
            try
            {
                x = lib.SearchByTitle(bookTitle);
                Console.WriteLine("The title : {0} , The author : {1} , The isbn : {2} , The isavailable : {3} ", x.Title, x.Author, x.ISBN, x.ISAvaliable);
            }
            catch (Exception )
            {
                Console.Write("\t\tThe Searched Book is unavaliable ");
            }

            Console.Write("\n\t Do you want to do anything else or logout ? (say <yes> or <no>)  :  ");
            string answer1 = Console.ReadLine();
            if ((answer1 == "yes") || (answer1 == "y"))
            {
                Console.Clear();
                StartPage();
            }
            else if ((answer1 == "no") || (answer1 == "n"))
            {
                Console.Clear();
                EndPage();
            }
            Console.ReadKey();
        }
        static void CheckAbookAsUnAvaliable()
        {
            Console.Clear();
            Console.WriteLine("\n   ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "\n\n");
            Console.WriteLine("\t\t\t\t    Moataz Library Management System  ");
            Console.WriteLine("\t\t\t\t    ================================  \n\n");
            Console.WriteLine("\t\t\t\t      Books : Check out a book          ");
            Console.WriteLine("\t\t\t\t       =======================      \n\n\n\n");
            Console.Write("\t\tEnter the Name of Book you want to find : ");
            string bookTitle = Console.ReadLine();
            Library lib = new Library();
            book x = null;
            try
            {
                x = lib.SearchByTitle(bookTitle);
                lib.CheckOutBook(x);
                Console.WriteLine("The title : {0} , The author : {1} , The isbn : {2} , The isavailable : {3} ", x.Title, x.Author, x.ISBN, x.ISAvaliable);
            }
            catch (Exception)
            {
                Console.Write("\t\tThe Searched Book is unavaliable ");
            }

            Console.Write("\n\t Do you want to do anything else or logout ? (say <yes> or <no>)  :  ");
            string answer1 = Console.ReadLine();
            if ((answer1 == "yes") || (answer1 == "y"))
            {
                Console.Clear();
                StartPage();
            }
            else if ((answer1 == "no") || (answer1 == "n"))
            {
                Console.Clear();
                EndPage();
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            StartPage();
            Console.ReadKey();
        }
    }
}
