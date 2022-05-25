﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator.BusinessLogic
{
    public class LineItem
    {
        public Guid LineItemId { get; set; }
        public Guid InvoiceId { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double CostPer { get; set; }
        public double Total { get; set; }
    }
}