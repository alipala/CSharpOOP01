using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03
{
    class Program
    {
        static void Main(string[] args)
        {

            UseParams();

            UsePoints();


        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
        }

        static void UsePoints()
        {
            //Global error handling mechanism
            try
            {
                var point = new Point(10, 20);

                //Since the null is given to the Move method, 
                //it returns an exception
                point.Move(null);
                Console.WriteLine("Points is at ({0}, {1})", point.X, point.Y);

                //Move method overloading 
                point.Move(100, 200);
                Console.WriteLine("Points is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured...");
            }
        }

    }

   
}
