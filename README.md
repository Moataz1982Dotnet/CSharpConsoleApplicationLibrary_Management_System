                                         Library Management System in C#

This system will have the following features:
1. Add a new book (title, author, isbn, isAvailable ).
2. List all books.
3. Search for a book by its title.
4. Check out a book.

Explanation:
1. Book Class:
o This class represents a book with attributes such as Title, Author, ISBN,
and IsAvailable (to track whether the book is checked out or available).
o It includes a constructor for initialization and an overridden ToString()
method to represent the book in a user-friendly format.

2. Library Class:
o This class manages a list of books.
o It includes methods to:
 AddBook: Adds a book to the library.
 ListBooks: Lists all books in the library.
 SearchByTitle: Searches for books by title (case-insensitive).
 CheckOutBook: Marks a book as checked out (sets IsAvailable to
false).

3. Main Program:
o This is where we create the library instance, add books, and demonstrate
various functionalities such as listing books, searching, and checking out
a book.
