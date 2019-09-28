using System;

namespace CSharpTutorial
{


    partial class Program
    {

        static void Main(string[] args)  
        {
            //var p = Person.Parse("Mike");
            //p.Introduce("John");

            var customer = new Customer(1, "Chris");
            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);


        }
    }
}
