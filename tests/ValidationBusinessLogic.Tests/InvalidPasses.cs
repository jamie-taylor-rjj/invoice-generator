using InvoiceGenerator.BusinessLogic;
using InvoiceGenerator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ValidationBusinessLogic.Tests
{
    public class InvalidPasses
    {
        [Theory]
        [InlineData("", "", "", "")]
        [InlineData(null, null, null, null)]
        public void Check_If_Error_Is_Returned_When_Invalid_Details_Input(string clientName, string clientAddress, string contactName, string contactEmail)
        {
            // Arrange
            var expectedResult = new List<string>()
            {
                "Client Name must not be empty!",
                "Client Address must not be empty!",
                "Contact Name must not be empty!",
                "Contact Email must not be empty!"
            }.ToArray();
            var input = new ClientViewModel()
            {
                ClientName = clientName,
                ClientAddress = clientAddress,
                ContactName = contactName,
                ContactEmail = contactEmail
            };
            var SUT = new ValidationBLogic();
            // Act
            var result = SUT.validateUserDetails(input);
            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Check_ClientName_Null_Or_Empty(string clientName)
        {
            // Arrange
            var expectedResult = new List<string>()
            {
                "Client Name must not be empty!",
                "No error!",
                "No error!",
                "No error!"
            }.ToArray();
            var input = new ClientViewModel()
            {
                ClientName = clientName,
                ClientAddress = "10 Downing Street",
                ContactName = "Bob",
                ContactEmail = "bob@gmail.com"
            };
            var SUT = new ValidationBLogic();
            // Act
            var result = SUT.validateUserDetails(input);
            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Check_ClientAddress_Null_or_Empty(string clientAddress)
        {
            // Arrange
            var expectedResult = new List<string>()
            {
                "No error!",
                "Client Address must not be empty!",
                "No error!",
                "No error!"
            }.ToArray();
            var input = new ClientViewModel()
            {
                ClientName = "Jim",
                ClientAddress = clientAddress,
                ContactName = "Bob",
                ContactEmail = "bob@gmail.com"
            };
            var SUT = new ValidationBLogic();
            // Act
            var result = SUT.validateUserDetails(input);
            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Check_ContactName_Null_Or_Empty(string contactName)
        {
            // Arrange
            var expectedResult = new List<string>()
            {
                "No error!",
                "No error!",
                "Contact Name must not be empty!",
                "No error!"
            }.ToArray();
            var input = new ClientViewModel()
            {
                ClientName = "Jim",
                ClientAddress = "10 Downing Street",
                ContactName = contactName,
                ContactEmail = "bob@gmail.com"
            };
            var SUT = new ValidationBLogic();
            // Act
            var result = SUT.validateUserDetails(input);
            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Check_ContactEmail_Null_Or_Empty(string contactEmail)
        {
            // Arrange
            var expectedResult = new List<string>()
            {
                "No error!",
                "No error!",
                "No error!",
                "Contact Email must not be empty!"
            }.ToArray();
            var input = new ClientViewModel()
            {
                ClientName = "Jim",
                ClientAddress = "10 Downing Street",
                ContactName = "Bob",
                ContactEmail = contactEmail
            };
            var SUT = new ValidationBLogic();
            // Act
            var result = SUT.validateUserDetails(input);
            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
