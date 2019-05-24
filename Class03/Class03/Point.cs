using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03
{
    class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLoation)
        {
            if (newLoation == null)
                throw new ArgumentNullException("newLocation");
            //Call Move method to prevent 
            //the usage of this.X as many
            Move(newLoation.X, newLoation.Y);
            //this.X = newLoation.X;
            //this.Y = newLoation.Y;
        }
    }
}
