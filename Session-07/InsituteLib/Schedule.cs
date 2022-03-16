using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteLib
{
    [Serializable]
    public class Schedule
    {
        public Guid ScheduleID { get; set; }
        public Guid CourseID { get; }
        public Guid ProfessorID { get; }
        public DateTime Calendar { get; set; }
        public Schedule(Guid courseId, Guid professorId, DateTime calendar)
        {
            ScheduleID = Guid.NewGuid();
            CourseID = courseId;
            ProfessorID = professorId;
            Calendar = calendar;
        }
    }
}
