using InvoiceGenerator.Domain;
using InvoiceGenerator.Domain.Models;
using InvoiceGenerator.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace InvoiceGenerator.BusinessLogic
{
    public class ClientService : IClientService
    {
        private readonly IRepository<Client> _clientRepository;

        public ClientService(IRepository<Client> clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public List<ClientViewModel> GetClients()
        {
            var clients = _clientRepository.GetAll(); // Assign a bunch of client objects to a list

            var viewModels = new List<ClientViewModel>();

            foreach (var db in clients)
            {
                viewModels.Add(ClientViewModel.FromDbModel(db)); // Add the client details to a list
            }
            return viewModels;
        }

        public List<ClientNameViewModel> GetClientNames()
        {

            var clientNames = _clientRepository.GetAll();

            var nameModels = new List<ClientNameViewModel>();

            foreach (var db in clientNames)
            {
                nameModels.Add(ClientNameViewModel.FromDbModel(db));
            }
            return nameModels;
        }

        public int AddClient(ClientViewModel viewModel)
        {

            var client = new Client     // Acts as an intialiser
            {
                // Set client details to the text box inputs on the client details entry screen
                ClientName = viewModel.ClientName,
                ClientAddress = viewModel.ClientAddress,
                ContactName = viewModel.ContactName,
                ContactEmail = viewModel.ContactEmail,
            };

            var recordsChanged = _clientRepository.Add(client);
            return recordsChanged;
        }
    }
}
