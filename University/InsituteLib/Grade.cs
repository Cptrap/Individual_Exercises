using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteLib
{
    [Serializable]
    public class Grade
    {
        public Guid ID { get; set; }
        public Guid StudentID { get; }
        public Guid CourseID { get; }
        public int _Grade { get; set; }
        public Grade(Guid studentId, Guid courseId, int grade)
        {
            ID = Guid.NewGuid();
            StudentID = studentId;
            CourseID = courseId;
            _Grade = grade;

        }
    }
}
