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
    public class VATValidPasses
    {
        [Fact]
        public void Check_If_NoError_Is_Returned_When_Valid_Details_Input()
        {
            // Arrange
            var expectedResult = new InvoiceViewModelValidationResult()
            {
                VATValidationMessage = "No error!"
            };
            var viewModel = new InvoiceViewModel()
            {
                VatRate = "10"
            };
            var SUT = new ValidationBLogic();
            // Act
            var result = SUT.checkVAT(viewModel);
            // Assert
            Assert.Equal(expectedResult.VATValidationMessage, result.VATValidationMessage);
        }
    }
}
