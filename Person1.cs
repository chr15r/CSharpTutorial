using System;

namespace CSharpTutorial
{
    public class Person
    {
        public string Name { get; set; }
        public void Introduce(string to)
        {
            Console.Write("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(String str)
        {
            Person person = new Person();
            person.Name = str;
            return person;
        }
    }
}
