using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Session_14.Model
{
    public class Manager : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal SallaryPerMonth { get; set; }
        public List<Engineer> Engineers { get; set; } 
        public List<Transaction> Transactions { get; set; }
        public Manager()
        {
            
        }
    }
}
