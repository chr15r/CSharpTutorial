using System.Collections.Generic;

namespace CSharpTutorial
{
    public class Customer1
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer1()
        {
            Orders = new List<Order>();
        }

        public Customer1(int id)
             : this()
        {           
            this.Id = id;
        }

        public Customer1(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

    }
}
