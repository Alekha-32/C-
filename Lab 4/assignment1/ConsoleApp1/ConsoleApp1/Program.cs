using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book();
            Console.WriteLine("Enter your BookId :" );
            book.BookName = Console.ReadLine();
            try
            {
                if(book.BookId <= 0)
                {
                    Console.WriteLine("BookId must be greater than 0 : " + book.BookId);
                    book.BookId = Convert.ToInt32(Console.ReadLine());
                    Console.ReadLine();
                }
               
            }
            catch(Exception ex)
            {
                Console.WriteLine("bookId must be greater than 0 " + ex);
                Console.ReadLine();
            }
            book.BookName = Console.ReadLine();
            try
            {
                if (book.BookName.Length <=0)
                {
                    Console.WriteLine("Book Name should not be blank");
                    Console.ReadLine();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("book Name should not be blank " + ex);
                Console.ReadLine();
            }
            book.Author = Console.ReadLine();
            book.Genre = Console.ReadLine();
            book.Price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(book.BookId);
            Console.WriteLine(book.BookName);
            Console.WriteLine(book.Author);
            Console.WriteLine(book.Genre);
            Console.WriteLine(book.Price);
            Console.ReadLine();

        }
    }
}
