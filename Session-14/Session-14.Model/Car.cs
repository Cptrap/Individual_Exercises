using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Session_14.Model
{
    public class Car : BaseEntity
    {
        public Brands Brand { get; set; }
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }
        public List<Transaction> Transactions { get; set; }
        public Car()
        {

        }
    }
}
