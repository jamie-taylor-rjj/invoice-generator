using System;
using InvoiceGenerator.Domain.Models;
using InvoiceGenerator.ViewModels;
using Xunit;

namespace ClientService.Tests;

public class ClientMapperTests
{
    [Fact]
    public void Client_Maps_To_ClientViewModel_All_Properties_Present_And_Correct()
    {
        // Arrange
        var client = new Client()
        {
            ClientId = Guid.NewGuid(),
            ClientName = "Jim",
            ClientAddress = "10 Downing Street",
            ContactName = "Bob",
            ContactEmail = "bob@gmail.com"
        };
        // Act - 
        var clientViewModel = ClientViewModel.FromDbModel(client);
        // Assert - expected outcome vs actual outcome
        Assert.Equal(client.ClientName, clientViewModel.ClientName);
        Assert.Equal(client.ClientAddress, clientViewModel.ClientAddress);
        Assert.Equal(client.ContactName, clientViewModel.ContactName);
        Assert.Equal(client.ContactEmail, clientViewModel.ContactEmail);
    }
    
    [Fact]
    public void ClientViewModel_Maps_To_Client_All_Properties_Present_And_Correct()
    {
        // Arrange
        var viewModel = new ClientViewModel()
        {
            ClientName = "Jim",
            ClientAddress = "10 Downing Street",
            ContactName = "Bob",
            ContactEmail = "bob@gmail.com"
        };
        // Act
        var client = ClientViewModel.ToDbModel(viewModel);
        // Assert
        Assert.Equal(viewModel.ClientName, client.ClientName);
        Assert.Equal(viewModel.ClientAddress, client.ClientAddress);
        Assert.Equal(viewModel.ContactName, client.ContactName);
        Assert.Equal(viewModel.ContactEmail, client.ContactEmail);
    }
}