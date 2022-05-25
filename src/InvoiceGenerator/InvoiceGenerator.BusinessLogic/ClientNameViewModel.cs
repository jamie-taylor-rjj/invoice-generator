using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator.BusinessLogic
{
    public class ClientNameViewModel
    {
        public string ClientName { get; set; }

        public static ClientNameViewModel FromDbModel(Client dbModel)
        {
            return new ClientNameViewModel
            {
                ClientName = dbModel.ClientName
            };
        }
    }
}
