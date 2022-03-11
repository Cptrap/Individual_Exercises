using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InstituteLib
{
    [Serializable]
    public class Student : Person
    {
        public int RegistrationNumber { get; set; }
        public Student(string name, int age, int registrationNumber): base(name,age)
        {
            RegistrationNumber = registrationNumber;
        }
    }
}
