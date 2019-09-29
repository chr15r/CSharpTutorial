using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public class Size
    {

    }

    public class Shape
    {

    }

    public class Position
    {

    }

    public class TextBox : UIControl, IDraggable, IDroppable
    {
        public void Drag()
        {
            throw new NotImplementedException();
        }

        public void Drop()
        {
            throw new NotImplementedException();
        }
    }

    public class UIControl
    {
        public string Id { get; set; }
        public Size Size { get; set; }
        public Position Position { get; set; }

        public virtual void Draw()
        {

        }

        public void Focus()
        {
            Console.WriteLine("Received Focus");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
