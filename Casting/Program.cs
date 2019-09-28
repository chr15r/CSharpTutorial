using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Text text = new Text();
            //Shape shape = text;

            //text.Width = 200;
            //shape.Width = 100;

            //Console.WriteLine("Width - " + text.Width);

            //StreamReader sr = new StreamReader(new FileStream())

            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add("hjhjkhkjhjk");


            //var anotherList = new List<int>();

            Shape shape = new Text();


            Text text = (Text)shape;
       


        }
    }
}
