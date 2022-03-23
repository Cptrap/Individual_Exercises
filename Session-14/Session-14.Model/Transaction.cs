using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Session_14.Model
{
    public class Transaction : BaseEntity
    {
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; } = DateTime.Now;
        public Guid CustomerID { get; set; }
        public Customer Customer { get; set; }
        public Guid CarID { get; set; }
        public Car Car { get; set; }
        public Guid ManagerID { get; set; }
        public Manager Manager { get; set; }
        public decimal TotalPrice { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }
        public Transaction(DateTime date)
        {
            Date = date;
        }
    }
}
