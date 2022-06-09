using InvoiceGenerator.Domain.Models;

namespace InvoiceGenerator.ViewModels
{
    public class ClientViewModel
    {
        public string? ClientName { get; set; }
        public string? ClientAddress { get; set; }
        public string? ContactName { get; set; }
        public string? ContactEmail { get; set; }

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
