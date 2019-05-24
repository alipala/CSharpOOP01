using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class04
{
    public class Customer
    {
        public int Id;
        public string Name;

        //It is a List decleration
        //public List<Order> Orders;

        //It is an initialization
        //If re-set the accidentally the field List
        //You can get a compile time error
        //readonly field can not be assigned
        //We can only initialize the readonly field
        //either when we declearing or in a constructor
        public readonly List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            Orders = new List<Order>();
            //...
        }

    }
}
