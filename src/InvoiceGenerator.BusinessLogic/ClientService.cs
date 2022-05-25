using InvoiceGenerator.Domain;
using InvoiceGenerator.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace InvoiceGenerator.BusinessLogic
{
    public class ClientService : IClientService
    {
        private readonly IInvoiceDbContext _invoiceDbContext;

        public ClientService(IInvoiceDbContext invoiceDbContext)
        {
            _invoiceDbContext = invoiceDbContext;
        }

        public List<ClientViewModel> GetClients()
        {
            var clients = _invoiceDbContext.Clients.ToList(); // Assign a bunch of client objects to a list

            var viewModels = new List<ClientViewModel>();

            foreach (var db in clients)
            {
                viewModels.Add(ClientViewModel.FromDbModel(db)); // Add the client details to a list
            }
            return viewModels;
        }

        public List<ClientNameViewModel> GetClientNames()
        {

            var clientNames = _invoiceDbContext.Clients.ToList();

            var nameModels = new List<ClientNameViewModel>();

            foreach (var db in clientNames)
            {
                nameModels.Add(ClientNameViewModel.FromDbModel(db));
            }
            return nameModels;
        }

        public void AddClients(string clientName, string clientAddress, string contactName, string contactEmail)
        {

            var client = new Client     // Acts as an intialiser
            {
                // Set client details to the text box inputs on the client details entry screen
                ClientName = clientName,
                ClientAddress = clientAddress,
                ContactName = contactName,
                ContactEmail = contactEmail,
            };

            _invoiceDbContext.Clients.Add(client); // Add client details to the database

            _invoiceDbContext.SaveChanges();  // Save the changes made to the database
        }
    }
}
