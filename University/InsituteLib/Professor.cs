using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteLib
{
    public enum Rank
    {
        Full,
        Associate,
        AssistantProfessor
    }
    [Serializable]
    public class Professor : Person
    {


        public string ProfessorRank { get; set; }

        public string GetName(string name)
        {
            if (name.Contains("Dr."))
                return name;
            else
                return "Dr." + name;
        }

        //public Professor(string name, string surname, int age, List<Course> courses) : base(name, surname, age)
        //{
        //    //ProfessorRank = rank;
        //    Courses = courses;

        //}
    }
}
