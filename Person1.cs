using System;

namespace CSharpTutorial
{
    public class Person1
    {
        public string Name { get; set; }
        public void Introduce(string to)
        {
            Console.Write("Hi {0}, I am {1}", to, Name);
        }

        public static Person1 Parse(String str)
        {
            Person1 person = new Person1();
            person.Name = str;
            return person;
        }
    }
}
