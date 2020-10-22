﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Derscanu_Smaranda_Lab2.Models
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}