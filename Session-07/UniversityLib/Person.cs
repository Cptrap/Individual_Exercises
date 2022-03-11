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
        private int Age { get; set; }
        public List<Course> Courses { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            ID = Guid.NewGuid();
        }
    }
}
