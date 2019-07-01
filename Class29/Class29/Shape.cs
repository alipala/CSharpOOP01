using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class29
{
    public abstract class Shape
    {
        public int Height
        {
            get; set;
        }

        public int Width
        {
            get; set;
        }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Copied to clipborad...");
        }

        public void Select()
        {
            Console.WriteLine("Selected the item...");
        }
    }
}
