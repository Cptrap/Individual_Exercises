using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Session_14.Model
{
    public class Engineer : BaseEntity
    {
        public Guid ManagerID { get; set; }
        public Manager Manager { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal SallaryPerMonth { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }

        public Engineer()
        {

        }
        public Engineer(string name, string surname, decimal sallary)
        {
            Name = name;
            Surname = surname;
            SallaryPerMonth = sallary;
        }
    }
}
