﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Session_14.Model
{
    public class TransactionLine : BaseEntity
    {
        
        public  decimal PricePerHour {get;set;}
        public Guid TransactionID { get; set; }
        public Transaction Transaction { get; set; }
        public Guid ServiceTaskID { get; set; }
        public ServiceTask ServiceTask { get; set; }
        public Guid EngineerID { get; set; }
        public Engineer Engineer { get; set; }
        public decimal Hours { get; set; }
        public decimal Price { get; set; }

        public TransactionLine()
        {

        }
    }
}
