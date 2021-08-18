using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }

        public DateTime BirthDate;
        public int Age { get; set; }
        public string Country { get; set; }
        public string Sex { get; set; }
        public List<string> Hobby { get; set; } = null;
        public Person()
        {

        }
        public Person(string Name, string SurName, DateTime BirthDate, int Age, string Country, string Sex)
        {
            this.Name = Name;
            this.SurName = SurName;
            this.BirthDate = BirthDate;
            this.Age = Age;
            this.Country = Country;
            this.Sex = Sex;
        }
    }
}
