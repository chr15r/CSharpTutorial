using System;

namespace CSharpTutorial
{


    partial class Program
    {

        static void Main(string[] args)
        {

            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote();

            Console.WriteLine(customer.Orders.Count);

        }



        static void UsePerson()
        {
            var p = Person.Parse("Mike");
            p.Introduce("John");

            var customer = new Customer1(1, "Chris");
            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }

        static void UseParams()
        {
            var calc = new Calculator();
            calc.Add(1, 2, 3, 4, 5, 6, 7);
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                point.Move(null);
                Console.WriteLine("Moved to ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Moved to ({0}, {1})", point.X, point.Y);

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error - " + ex.Message);
            }
        }

        static void ParseInt()
        {
            int number;
            var results = int.TryParse("abc", out number);
            if (results)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }

    }
}
