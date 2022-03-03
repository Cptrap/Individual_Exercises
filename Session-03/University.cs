using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class University : Institute
    {
        Array[] students = new Array[30];

        Array[] courses = new Array[50];

        Array[] grades = new Array[30];

        Array[] scheduledCourses = new Array[60];


        public Array GetStudents() { return students; }
        public Array GetCourses() { return courses; }
        public Array GetGrades() { return grades; }
        public Array GetScheduledCourses() { return scheduledCourses; }


        public University()
        {


        }

        public void SetSchedule(Grade courseID,Grade professorID, DateTime dateTime) { }
     
    }
}
