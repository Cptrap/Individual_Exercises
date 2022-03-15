using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteLib
{
    [Serializable]
    public class Person
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
        //public Person(string name, string surname, int age)
        //{
        //    Name = name;
        //    Surname = surname;
        //    Age = age;
        //    ID = Guid.NewGuid();
        //}
        public string FullName
        {
            get{
                return $"{Name} {Surname}";
            }

        }
    }
}
