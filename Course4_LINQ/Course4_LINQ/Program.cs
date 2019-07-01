using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course4_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Books collection
            var books = new BookRepository().GetBooks();

            // There are 2 solutions while using LINQ

            // 1. LINQ Query Operators
            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b;


            // 2. LINQ Extension Methods
            // This solution is faster than LINQ Query Operators
            var cheapBooks = books
                                .Where(b => b.Price < 10) // Filter
                                .OrderBy(b => b.Title) // Sort
                                .Select(b => b.Title); // Select

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book);
            }

            //var pagedBooks = books.Skip(2).Take(3);

            //foreach (var pagedBook in pagedBooks)
            //{
            //    Console.WriteLine(pagedBook.Title);
            //}



        }
    }
}
