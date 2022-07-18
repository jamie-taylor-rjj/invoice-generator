﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using InvoiceGenerator_dotnet_maui_UI.Services;
using System.Collections.ObjectModel;

namespace InvoiceGenerator_dotnet_maui_UI.ViewModels
{
    public partial class InvoiceGenerationViewModel : BaseViewModel
    {
        private readonly ClientService clientService;

        [ObservableProperty]
        private bool _areClientNamesLoading;

        [ObservableProperty]
        public LineItemDisplayModel _lineItemVm = new();

        [ObservableProperty]
        public string _vat;

        public ObservableCollection<ClientNameViewModel> ClientNames { get; } = new ObservableCollection<ClientNameViewModel>();

        public ObservableCollection<LineItemDisplayModel> LineItems { get; } = new ObservableCollection<LineItemDisplayModel>();

        public InvoiceGenerationViewModel(ClientService clientService)
        {
            this.clientService = clientService;
            _ = GetClientNames();
        }

        public double CalculateTotalValue()
        {
            return LineItems.Sum(x => x.Total);
        }

        public double CalculateInvoiceTotal()
        {
            var totalValue = CalculateTotalValue();

            double invoiceTotal = Math.Round(totalValue + (totalValue * double.Parse(_vat) / 100), 2);

            return invoiceTotal;
        }

        [RelayCommand]
        public async Task GetClientNames()
        {
            _areClientNamesLoading = true;

            var allClientNames = await clientService.GetClientNamesFromApi();

            if (ClientNames.Count != 0)
            {
                ClientNames.Clear();
            }

            foreach (var clientName in allClientNames)
            {
                ClientNames.Add(clientName);
            }

            _areClientNamesLoading = false;
        }

        [RelayCommand]
        public void AddLineItems()
        {
            IsBusy = true;

            var newLineItem = new LineItemDisplayModel
            {
                Description = _lineItemVm.Description,
                Cost = _lineItemVm.Cost,
                Quantity = _lineItemVm.Quantity
            };
            LineItems.Add(newLineItem);

            IsBusy = false;
        }
    }
}
