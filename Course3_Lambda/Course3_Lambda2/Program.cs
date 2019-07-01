using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course3_Lambda2
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //Remove this line of codes to use the lambda exp.
            //var cheapBooks = books.FindAll(IsCheaperThan100Dollars);

            var cheapBooks = books.FindAll(book => book.Price < 10);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }



        }
        //Remove this line of codes to use the lambda exp.
        //static bool IsCheaperThan100Dollars(Book book)
        //{
        //    return book.Price < 10;

        //}
    }
}
