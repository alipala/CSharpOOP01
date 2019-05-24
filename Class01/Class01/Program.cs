using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class01
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hello {0}! I am {1}", to, Name);
        }

        //Static method can be call directly using class name
        //Person.Parse(string srt)
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            //Calling static member
            //Static member is only 
            //accessible from class not its object
            var person = Person.Parse("Ali");
            person.Introduce("Pala");
        }
    }
}
