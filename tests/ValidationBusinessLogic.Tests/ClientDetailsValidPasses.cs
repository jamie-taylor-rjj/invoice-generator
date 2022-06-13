using InvoiceGenerator.BusinessLogic;
using InvoiceGenerator.ViewModels;
using System.Collections.Generic;
using Xunit;

namespace ValidationBusinessLogic.Tests;

public class ClientDetailsValidPasses
{
    [Fact]
    public void Check_If_NoError_Is_Returned_When_Valid_Details_Input()
    {
        // Arrange
        var expectedResult = new ClientViewModelValidationResult()
        {
            ClientNameValidationMessage = "No error!",
            ClientAddressValidationMessage = "No error!",
            ContactNameValidationMessage = "No error!",
            ContactEmailValidationMessage = "No error!"
        };
        var viewModel = new ClientViewModel()
        {
            ClientName = "Jim",
            ClientAddress = "10 Downing Street",
            ContactName = "Bob",
            ContactEmail = "bob@gmail.com"
        };
        var SUT = new ValidationBLogic();
        // Act
        var result = SUT.validateUserDetails(viewModel);
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
            ContactEmailFormatValidationMessage = "No error!"
        };
        var viewModel = new ClientViewModel()
        {
            ContactEmail = "bob@gmail.com"
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