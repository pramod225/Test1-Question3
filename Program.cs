using System;
using System.Collections.Generic;


namespace tesx3
{
    class Program
    {
        public static List<Book> books;
        static void Main(string[] args)
        {
                Book book = new Book();
                books = new List<Book>()
         { 
            new Book(BookId: "B001", BookName: "Java", AuthorName: "son", Genre: "Programming", BookPrice: 200, BookPublicedDate: "20-Oct-2020"),
            new Book(BookId: "P001", BookName: "Python", AuthorName: "son", Genre: "Programming", BookPrice: 500, BookPublicedDate: "20-Oct-2020"),
            new Book(BookId: "C001", BookName: "C#", AuthorName: "son", Genre: "Programming", BookPrice: 800, BookPublicedDate: "20-Oct-2020"),
            new Book(BookId: "JS001", BookName: "JavaScript", AuthorName: "son", Genre: "Programming", BookPrice: 300, BookPublicedDate: "20-Oct-2020"),
            new Book(BookId: "CC001", BookName: "C", AuthorName: "son", Genre: "Programming", BookPrice: 800, BookPublicedDate: "20-Oct-2020"),
            new Book(BookId: "CCC001", BookName: "C++", AuthorName: "son", Genre: "Programming", BookPrice: 200, BookPublicedDate: "20-Oct-2020")
        };
                book.DisplayBookList();
                for (int i = 0; i < 3; i++)
                {
                    book = new Book();
                    book.GetBookDetails();
                    books.Add(book);
                }

                foreach (Book book1 in books)
                {
                    Console.Write(book1.BookId + "\t");
                    Console.Write(book1.BookName + "\t");
                    Console.Write(book1.AuthorName + "\t");
                    Console.Write(book1.Genre + "\t");
                    Console.Write(book1.BookPrice + "\t");
                    Console.Write(book1.BookPublicedDate + "\t");

                }
            }

        }   
}

        
    

