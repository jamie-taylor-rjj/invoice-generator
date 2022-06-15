using InvoiceGenerator.BusinessLogic;
using InvoiceGenerator.ViewModels;
using Xunit;

namespace ValidationBusinessLogic.Tests
{
    public class InvoiceInvalidPasses
    {
        [Fact]
        public void Check_If_Error_Is_Returned_When_Invalid_VAT_Input()
        {
            // Arrange
            var expectedResult = new InvoiceViewModelValidationResult()
            {
                VATValidationMessage = "VAT/Sales Tax must be an integer!"
            };
            var viewModel = new InvoiceViewModel()
            {
                VatRate = "Test"
            };
            var SUT = new ValidationBLogic();
            // Act
            var result = SUT.checkVAT(viewModel);
            // Assert
            Assert.Equal(expectedResult.VATValidationMessage, result.VATValidationMessage);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Check_VAT_Null_Or_Empty(string VAT)
        {
            // Arrange
            var expectedResult = new InvoiceViewModelValidationResult()
            {
                VATValidationMessage = "VAT/Sales Tax must be an integer!"
            };
            var input = new InvoiceViewModel()
            {
                VatRate = VAT
            };
            var SUT = new ValidationBLogic();
            // Act
            var result = SUT.checkVAT(input);
            // Assert
            Assert.Equal(expectedResult.VATValidationMessage, result.VATValidationMessage);
        }
    }
}
