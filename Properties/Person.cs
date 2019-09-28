using System;

namespace Properties
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; private set; } // DOB private, can only be set in constructor

        public Person(DateTime birthDate)
        {
            BirthDate = birthDate;
        }

        public int Age
        {
            get
            {              
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
    }
}
