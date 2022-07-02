using InvoiceGenerator.Domain.Models;

namespace InvoiceGenerator.ViewModels
{
    public class ClientViewModel
    {
        public string ClientName { get; set; } = string.Empty;
        public string ClientAddress { get; set; } = string.Empty;
        public string ContactName { get; set; } = string.Empty;
        public string ContactEmail { get; set; } = string.Empty;

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

        public static Client ToDbModel(ClientViewModel viewModel)
        {
            return new Client
            {
                ClientName = viewModel.ClientName,
                ClientAddress = viewModel.ClientAddress,
                ContactName = viewModel.ContactName,
                ContactEmail = viewModel.ContactEmail
            };
        }
    }
}
