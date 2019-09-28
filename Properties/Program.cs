using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {

        static void Main(string[] args)
        {
            var person = new Person();
            person.BirthDate = new System.DateTime(1983, 12,15);
            System.Console.WriteLine(person.Age);
        }
    }
}
