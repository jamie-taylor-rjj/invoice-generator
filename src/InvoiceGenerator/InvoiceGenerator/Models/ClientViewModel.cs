using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator.Models
{
    public class ClientViewModel
    {
        public string ClientName { get; set; }
        public string ClientAddress { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }

        public static ClientViewModel FromDbModel(Client dbModel)
        {
            return new ClientViewModel
            {
                ClientName = dbModel.ClientName,
                ClientAddress = dbModel.ClientAddress,
                ContactName = dbModel.ContactName,
                ContactEmail = dbModel.ContactEmail
            };
        }
    }
}
