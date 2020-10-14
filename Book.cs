using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tesx3
{
   public class Book
    {
        
        public string BookId, BookName, Author, Genre, PublicedDate;
        public  int BookPrice;

        public Book()
        {

        }
        public Book(string BookId,string BookName, string Author, string Genre, int BookPrice, string PublicedDate)
        {
            this.BookId = BookId;
            this.BookName = BookName;
            this.Author = Author;
            this.Genre = Genre;
            this.BookPrice = BookPrice;
            this.PublicedDate = PublicedDate;
        }
        public void GetBookDetails()
        {
            Console.WriteLine("Enter Book Id");
            BookId = Console.ReadLine();
            try
            {
                Console.WriteLine("Enter Book Name");
                BookName = Console.ReadLine();
                Console.WriteLine("Enter Book Price");
                BookPrice = Convert.ToInt16(Console.ReadLine());
                if (BookName.Length < 20)
                {
                    throw new BookCustomException(" Book Name should have minimum 20 character ");
                }
                if (BookPrice <= 2000)
                {
                    throw new BookCustomException(" Book Price can not more then 2000");
                }
            }
            catch (Exception obj)
            {
                Console.WriteLine(obj.Message);

            }
            
            Console.WriteLine("Enter Book Author Name");
            Author = Console.ReadLine();
            Console.WriteLine("Enter Book Genre");
            Genre = Console.ReadLine();
            Console.WriteLine("Enter Book published Date");
            PublicedDate = Console.ReadLine();


        }
        public void DisplayBookList()
        {
            Console.WriteLine("Book id " + "\t" + "Book Name " + "\t" + "Author " + "\t"  + "Genre " + "\t" +"\t" + "Book Price " + "\t" + "Published Date " + "\t");
            foreach (Book list in Program.books)
            {

                Console.Write(list.BookId + "\t" + "\t");
                Console.Write(list.BookName + "\t" + "\t");
                Console.Write(list.Author + "\t" + "\t");
                Console.Write(list.Genre + "\t" + "\t");
                Console.Write(list.BookPrice + "\t" + "\t");
                Console.WriteLine(list.PublicedDate + "\t" + "\t");
            }
        }

        
       
    }
}
