using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator.BusinessLogic
{
    public class Invoice
    {
        public Guid InvoiceId { get; set; }
        public Guid ClientId { get; set; }
        public string InvoiceReference { get; set; }
        public double TotalValue { get; set; }
        public int VatRate { get; set; }
        public double InvoiceTotal { get; set; }
        public DateOnly IssueDate { get; set; }
        public DateOnly DueDate { get; set; }
    }
}
