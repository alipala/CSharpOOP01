using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02
{
    class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            //Initializing the empty list
            Orders = new List<Order>();
        }

        //When this constructer is being called
        //the empty constructor is called before
        //by this()
        public Customer(int id)
            :this()
        {
            this.Id = id;
        }

        //When this constructer is being called
        //the constructor includes id parameter is called before
        //by this(id)
        public Customer(int id, string name)
            :this(id)
        {
            this.Name = name;
        }
    }
}
