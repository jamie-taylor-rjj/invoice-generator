using InvoiceGenerator.BusinessLogic;
using InvoiceGenerator.ViewModels;
using System.Collections.Generic;
using Xunit;

namespace ValidationBusinessLogic.Tests;

public class ValidPasses
{
    [Fact]
    public void Check_If_NoError_Is_Returned_When_Valid_Details_Input()
    {
        // Arrange
        var expectedResult = new List<string>()
        {
            "No error!",
            "No error!",
            "No error!",
            "No error!"
        }.ToArray();
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
        Assert.Equal(expectedResult, result);
    }

}