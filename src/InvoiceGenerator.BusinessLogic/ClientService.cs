using InvoiceGenerator.Domain;
using InvoiceGenerator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoiceGenerator.BusinessLogic
{
    public class ClientService
    {
        public List<ClientViewModel> GetClients()
        {
            using (var context = new InvoiceDBContext()) // using statement is discarded once the squiggly brackets have been passed, saves memory
            {
                context.Database.EnsureCreated();   // Ensures database is created

                var clients = context.Clients.ToList(); // Assign a bunch of client objects to a list

                var viewModels = new List<ClientViewModel>();

                foreach (var db in clients)
                {
                    viewModels.Add(ClientViewModel.FromDbModel(db)); // Add the client details to a list
                }
                return viewModels;

            }
        }
        
        public List<ClientNameViewModel> GetClientNames()
        {
            using (var context = new InvoiceDBContext())
            {
                context.Database.EnsureCreated();

                var clientNames = context.Clients.ToList();

                var nameModels = new List<ClientNameViewModel>();

                foreach (var db in clientNames)
                {
                    nameModels.Add(ClientNameViewModel.FromDbModel(db));
                }
                return nameModels;
            }
        }

        public void AddClients(string clientName, string clientAddress, string contactName, string contactEmail)
        {
            using (var context = new InvoiceDBContext())    // using statement is discarded once the squiggly brackets have been passed, saves memory
            {
                context.Database.EnsureCreated();   // Ensures database is created

                var client = new Client     // Acts as an intialiser
                {
                    // Set client details to the text box inputs on the client details entry screen
                    ClientName = clientName,
                    ClientAddress = clientAddress,
                    ContactName = contactName,
                    ContactEmail = contactEmail,
                };

                context.Clients.Add(client); // Add client details to the database

                context.SaveChanges();  // Save the changes made to the database
            }
        }

    }
}
