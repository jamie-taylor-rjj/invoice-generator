using System;
using System.Collections.Generic;
using System.Linq;
using InvoiceGenerator.Domain;
using InvoiceGenerator.Domain.Models;
using InvoiceGenerator.ViewModels;
using Moq;
using Xunit;

namespace ClientService.Tests
{
    public class ClientServiceTests
    {
        [Fact]
        public void Check_If_Created_List_Of_Client_Details_Matches_Database_Client_Details()
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
            var ClientsForMock = new List<Client>() { client };
            var MockedRepository = new Mock<IRepository<Client>>();
            MockedRepository.Setup(x => x.GetAll()).Returns(ClientsForMock);

            //hint for later - for AddClients
            //MockedRepository.Setup(x => x.Add(client)).Returns(It.IsAny<int>());

            var SUT = new InvoiceGenerator.BusinessLogic.ClientService(MockedRepository.Object); // Service Under Tests
                                                                                                 // Act
            var result = SUT.GetClients();
            // Assert
            Assert.Equal(client.ClientName, result.FirstOrDefault()?.ClientName);
            Assert.Equal(client.ClientAddress, result.FirstOrDefault()?.ClientAddress);
            Assert.Equal(client.ContactName, result.FirstOrDefault()?.ContactName);
            Assert.Equal(client.ContactEmail, result.FirstOrDefault()?.ContactEmail);
        }
    }
}
