using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Professor : Person
    {
       
        public string Rank { get; set; }
        public string GetName()
        {
            if (_name.Contains("Dr."))
                return _name;
            else
                return "Dr." + _name;
        }
        public Course[] Courses { get; set; }
        public Professor()
        {

        }
        public void Teach(Course course, DateTime dateTime) { }
        
        public void SetGrade(Grade studentID, Course course, Grade _Grade) { }
       
        
    }
}
