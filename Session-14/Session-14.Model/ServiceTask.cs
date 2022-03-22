using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Session_14.Model
{
    public class ServiceTask : BaseEntity
    {
        public int Code { get; set; }
        public string Description { get; set; }
        public decimal Hours { get; set; }
        public List<TransactionLine> TransactionLines { get; set; } 
        public ServiceTask()
        {

        }
    }
}
