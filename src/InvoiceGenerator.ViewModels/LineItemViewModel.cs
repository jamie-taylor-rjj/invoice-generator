using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator.ViewModels
{
    public class LineItemViewModel
    {
        public string Description { get; set; } = string.Empty;
        public string Quantity { get; set; } = string.Empty;
        public string CostPer { get; set; } = string.Empty;
    }
}
