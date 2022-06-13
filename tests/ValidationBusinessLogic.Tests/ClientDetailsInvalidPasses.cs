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
    public class ClientDetailsInvalidPasses
    {
        [Theory]
        [InlineData("", "", "", "")]
        [InlineData(null, null, null, null)]
        public void Check_If_Error_Is_Returned_When_Invalid_Details_Input(string clientName, string clientAddress, string contactName, string contactEmail)
        {
            // Arrange
            var expectedResult = new ClientViewModelValidationResult()
            {
                ClientNameValidationMessage = "Client Name must not be empty!",
                ClientAddressValidationMessage = "Client Address must not be empty!",
                ContactNameValidationMessage = "Contact Name must not be empty!",
                ContactEmailValidationMessage = "Contact Email must not be empty!"
            };
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
            Assert.Equal(expectedResult.ClientNameValidationMessage, result.ClientNameValidationMessage);
            Assert.Equal(expectedResult.ClientAddressValidationMessage, result.ClientAddressValidationMessage);
            Assert.Equal(expectedResult.ContactNameValidationMessage, result.ContactNameValidationMessage);
            Assert.Equal(expectedResult.ContactEmailValidationMessage, result.ContactEmailValidationMessage);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Check_ClientName_Null_Or_Empty(string clientName)
        {
            // Arrange
            var expectedResult = new ClientViewModelValidationResult()
            {
                ClientNameValidationMessage = "Client Name must not be empty!",
                ClientAddressValidationMessage = "No error!",
                ContactNameValidationMessage = "No error!",
                ContactEmailValidationMessage = "No error!"
            };
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
            Assert.Equal(expectedResult.ClientNameValidationMessage, result.ClientNameValidationMessage);
            Assert.Equal(expectedResult.ClientAddressValidationMessage, result.ClientAddressValidationMessage);
            Assert.Equal(expectedResult.ContactNameValidationMessage, result.ContactNameValidationMessage);
            Assert.Equal(expectedResult.ContactEmailValidationMessage, result.ContactEmailValidationMessage);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Check_ClientAddress_Null_or_Empty(string clientAddress)
        {
            // Arrange
            var expectedResult = new ClientViewModelValidationResult()
            {
                ClientNameValidationMessage = "No error!",
                ClientAddressValidationMessage = "Client Address must not be empty!",
                ContactNameValidationMessage = "No error!",
                ContactEmailValidationMessage = "No error!"
            };
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
            Assert.Equal(expectedResult.ClientNameValidationMessage, result.ClientNameValidationMessage);
            Assert.Equal(expectedResult.ClientAddressValidationMessage, result.ClientAddressValidationMessage);
            Assert.Equal(expectedResult.ContactNameValidationMessage, result.ContactNameValidationMessage);
            Assert.Equal(expectedResult.ContactEmailValidationMessage, result.ContactEmailValidationMessage);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Check_ContactName_Null_Or_Empty(string contactName)
        {
            // Arrange
            var expectedResult = new ClientViewModelValidationResult()
            {
                ClientNameValidationMessage = "No error!",
                ClientAddressValidationMessage = "No error!",
                ContactNameValidationMessage = "Contact Name must not be empty!",
                ContactEmailValidationMessage = "No error!"
            };
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
            Assert.Equal(expectedResult.ClientNameValidationMessage, result.ClientNameValidationMessage);
            Assert.Equal(expectedResult.ClientAddressValidationMessage, result.ClientAddressValidationMessage);
            Assert.Equal(expectedResult.ContactNameValidationMessage, result.ContactNameValidationMessage);
            Assert.Equal(expectedResult.ContactEmailValidationMessage, result.ContactEmailValidationMessage);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Check_ContactEmail_Null_Or_Empty(string contactEmail)
        {
            // Arrange
            var expectedResult = new ClientViewModelValidationResult()
            {
                ClientNameValidationMessage = "No error!",
                ClientAddressValidationMessage = "No error!",
                ContactNameValidationMessage = "No error!",
                ContactEmailValidationMessage = "Contact Email must not be empty!"
            };
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
            Assert.Equal(expectedResult.ClientNameValidationMessage, result.ClientNameValidationMessage);
            Assert.Equal(expectedResult.ClientAddressValidationMessage, result.ClientAddressValidationMessage);
            Assert.Equal(expectedResult.ContactNameValidationMessage, result.ContactNameValidationMessage);
            Assert.Equal(expectedResult.ContactEmailValidationMessage, result.ContactEmailValidationMessage);
        }

        [Fact]
        public void Check_If_NoError_Is_Returned_When_Valid_EmailFormat_Input()
        {
            // Arrange
            var expectedResult = new ClientViewModelValidationResult()
            {
                ContactEmailFormatValidationMessage = "Contact Email must be formatted correctly!"
            };
            var viewModel = new ClientViewModel()
            {
                ContactEmail = "bobgmail.com"
            };
            var SUT = new ValidationBLogic();
            // Act
            var result = SUT.validateEmailFormat(viewModel);
            // Assert
            Assert.Equal(expectedResult.ClientNameValidationMessage, result.ClientNameValidationMessage);
            Assert.Equal(expectedResult.ClientAddressValidationMessage, result.ClientAddressValidationMessage);
            Assert.Equal(expectedResult.ContactNameValidationMessage, result.ContactNameValidationMessage);
            Assert.Equal(expectedResult.ContactEmailValidationMessage, result.ContactEmailValidationMessage);
            Assert.Equal(expectedResult.ContactEmailFormatValidationMessage, result.ContactEmailFormatValidationMessage);
        }
    }
}
