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

    //[Theory]
    //[InlineData(1, 2, 3)]
    //[InlineData(2, 3, 4)]
    //[InlineData(3, 4, 5)]
    //[InlineData(4, 5, 6)]    
    //[InlineData(5, 6, 7)]
    //public void Will_Not_Compile(int one, int two, int expected)
    //{
    //    // arrange
    //    var calc = new Calculator();

    //    // act
    //    var result = calc.Add(one, two);

    //    // assert
    //    Assert.Equal(expected, result);
    //}
}