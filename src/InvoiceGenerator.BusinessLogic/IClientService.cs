using InvoiceGenerator.ViewModels;
using System.Collections.Generic;

namespace InvoiceGenerator.BusinessLogic
{
    public interface IClientService
    {
        void AddClients(string clientName, string clientAddress, string contactName, string contactEmail);
        List<ClientNameViewModel> GetClientNames();
        List<ClientViewModel> GetClients();
    }
}