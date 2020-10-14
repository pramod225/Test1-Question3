using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tesx3
{
   public class Book
    {
        
        public string BookId, BookName, AuthorName, Genre, BookPublicedDate;
        public  int BookPrice;

        public Book()
        {

        }
        public Book(string BookId,string BookName, string AuthorName, string Genre, int BookPrice, string BookPublicedDate)
        {
            this.BookId = BookId;
            this.BookName = BookName;
            this.AuthorName = AuthorName;
            this.Genre = Genre;
            this.BookPrice = BookPrice;
            this.BookPublicedDate = BookPublicedDate;
        }
        public void GetBookDetails()
        {
            try
            {
                Console.WriteLine("Enter Book Id");
                BookId = Console.ReadLine();
                if (BookId != null)
                {
                    throw new BookCustomException("Book Id can not be null");
                }
                
                Console.WriteLine("Enter Book Name");
                BookName = Console.ReadLine();
                if (BookName.Length < 20)
                {
                    throw new BookCustomException(" Book Name should have minimum 20 character ");
                }

                Console.WriteLine("Enter Book Price");
                BookPrice = Convert.ToInt16(Console.ReadLine());
                if (BookPrice <= 2000)
                {
                    throw new BookCustomException(" Book Price can not more then 2000");
                }
                Console.WriteLine("Enter Book Author Name");
                AuthorName = Console.ReadLine();
                if (AuthorName != null)
                {
                    throw new BookCustomException("Book Author can not be null");
                }

                Console.WriteLine("Enter Book Genre");
                Genre = Console.ReadLine();
                if (Genre!= null)
                {
                    throw new BookCustomException("Book Genre can not be null");
                }

                Console.WriteLine("Enter Book published Date");
                BookPublicedDate = Console.ReadLine();
                if (BookPublicedDate != null)
                {
                    throw new BookCustomException("Enter Book Published date ");
                }


            }
            catch (BookCustomException obj)
            {
                Console.WriteLine(obj.massage);

            }
            
          

        }
        public void DisplayBookList()
        {
            Console.WriteLine("Book id " + "\t" + "Book Name " + "\t" + "AuthorName " + "\t"  + "Genre " + "\t" +"\t" + "Book Price " + "\t" + "Published Date " + "\t");
            foreach (Book list in Program.books)
            {

                Console.Write(list.BookId + "\t" + "\t");
                Console.Write(list.BookName + "\t" + "\t");
                Console.Write(list.AuthorName + "\t" + "\t");
                Console.Write(list.Genre + "\t" + "\t");
                Console.Write(list.BookPrice + "\t" + "\t");
                Console.WriteLine(list.BookPublicedDate + "\t" + "\t");
            }
        }

        
       
    }
}
