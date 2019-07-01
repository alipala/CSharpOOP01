using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Multicast
{
    class Program
    {
        public delegate void Print(int value);
        static void Main(string[] args)
        {
            Print printDelegate = PrintNumber;
            printDelegate += PrintHexadecimal;
            printDelegate += PrintMoney;

            printDelegate(1000);

            printDelegate -= PrintHexadecimal;
            printDelegate(2000);
        }

        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }

        public static void PrintHexadecimal(int dec)
        {
            Console.WriteLine("Hexadecimal: {0:X}", dec);
        }

    }
}
