using System;

namespace Properties
{
    public class Person
    {
        public DateTime BirthDate { get; set; }
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
