using InvoiceGenerator.BusinessLogic;
using InvoiceGenerator.ViewModels;
using Xunit;

namespace ValidationBusinessLogic.Tests
{
    public class LineItemDetailsInvalidPasses
    {
        [Theory]
        [InlineData("", "", "")]
        [InlineData(null, null, null)]
        public void Check_If_Error_Is_Returned_When_Invalid_Details_Input(string lineItemDescription, string lineItemCost, string lineItemQuantity)
        {
            // Arrange
            var expectedResult = new LineItemViewModelValidationResult()
            {
                LineItemDescriptionValidationMessage = "Line Item Description must not be empty!",
                LineItemCostValidationMessage = "Line Item Cost must not be empty!",
                LineItemQuantityValidationMessage = "Line Item Quantity must not be empty!"
            };
            var input = new LineItemViewModel()
            {
                Description = lineItemDescription,
                CostPer = lineItemCost,
                Quantity = lineItemQuantity
            };
            var SUT = new ValidationBLogic();
            // Act
            var result = SUT.validateLineItemDetails(input);
            // Assert
            Assert.Equal(expectedResult.LineItemDescriptionValidationMessage, result.LineItemDescriptionValidationMessage);
            Assert.Equal(expectedResult.LineItemCostValidationMessage, result.LineItemCostValidationMessage);
            Assert.Equal(expectedResult.LineItemQuantityValidationMessage, result.LineItemQuantityValidationMessage);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Check_LineItemDescription_Null_Or_Empty(string lineItemDescription)
        {
            // Arrange
            var expectedResult = new LineItemViewModelValidationResult()
            {
                LineItemDescriptionValidationMessage = "Line Item Description must not be empty!",
                LineItemCostValidationMessage = "No error!",
                LineItemQuantityValidationMessage = "No error!"
            };
            var input = new LineItemViewModel()
            {
                Description = lineItemDescription,
                CostPer = "1.65",
                Quantity = "3"
            };
            var SUT = new ValidationBLogic();
            // Act
            var result = SUT.validateLineItemDetails(input);
            // Assert
            Assert.Equal(expectedResult.LineItemDescriptionValidationMessage, result.LineItemDescriptionValidationMessage);
            Assert.Equal(expectedResult.LineItemCostValidationMessage, result.LineItemCostValidationMessage);
            Assert.Equal(expectedResult.LineItemQuantityValidationMessage, result.LineItemQuantityValidationMessage);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Check_LineItemCost_Null_Or_Empty(string lineItemCost)
        {
            // Arrange
            var expectedResult = new LineItemViewModelValidationResult()
            {
                LineItemDescriptionValidationMessage = "No error!",
                LineItemCostValidationMessage = "Line Item Cost must not be empty!",
                LineItemQuantityValidationMessage = "No error!"
            };
            var input = new LineItemViewModel()
            {
                Description = "Butter",
                CostPer = lineItemCost,
                Quantity = "3"
            };
            var SUT = new ValidationBLogic();
            // Act
            var result = SUT.validateLineItemDetails(input);
            // Assert
            Assert.Equal(expectedResult.LineItemDescriptionValidationMessage, result.LineItemDescriptionValidationMessage);
            Assert.Equal(expectedResult.LineItemCostValidationMessage, result.LineItemCostValidationMessage);
            Assert.Equal(expectedResult.LineItemQuantityValidationMessage, result.LineItemQuantityValidationMessage);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Check_LineItemQuantity_Null_Or_Empty(string lineItemQuantity)
        {
            // Arrange
            var expectedResult = new LineItemViewModelValidationResult()
            {
                LineItemDescriptionValidationMessage = "No error!",
                LineItemCostValidationMessage = "No error!",
                LineItemQuantityValidationMessage = "Line Item Quantity must not be empty!"
            };
            var input = new LineItemViewModel()
            {
                Description = "Butter",
                CostPer = "1.65",
                Quantity = lineItemQuantity
            };
            var SUT = new ValidationBLogic();
            // Act
            var result = SUT.validateLineItemDetails(input);
            // Assert
            Assert.Equal(expectedResult.LineItemDescriptionValidationMessage, result.LineItemDescriptionValidationMessage);
            Assert.Equal(expectedResult.LineItemCostValidationMessage, result.LineItemCostValidationMessage);
            Assert.Equal(expectedResult.LineItemQuantityValidationMessage, result.LineItemQuantityValidationMessage);
        }

        [Fact]
        public void Check_If_Error_Is_Returned_When_Invalid_Cost_Input()
        {
            // Arrange
            var expectedResult = new LineItemViewModelValidationResult()
            {
                LineItemCheckCostValidationMessage = "Line Item Cost must be a decimal number!"
            };
            var viewModel = new LineItemViewModel()
            {
                CostPer = "Test"
            };
            var SUT = new ValidationBLogic();
            // Act
            var result = SUT.checkCost(viewModel);
            // Assert
            Assert.Equal(expectedResult.LineItemCheckCostValidationMessage, result.LineItemCheckCostValidationMessage);
        }

        [Fact]
        public void Check_If_Error_Is_Returned_When_Invalid_Quantity_Input()
        {
            // Arrange
            var expectedResult = new LineItemViewModelValidationResult()
            {
                LineItemCheckQuantityValidationMessage = "Line Item Quantity must be an integer!"
            };
            var viewModel = new LineItemViewModel()
            {
                Quantity = "Test"
            };
            var SUT = new ValidationBLogic();
            // Act
            var result = SUT.checkQuantity(viewModel);
            // Assert
            Assert.Equal(expectedResult.LineItemCheckQuantityValidationMessage, result.LineItemCheckQuantityValidationMessage);
        }
    }
}
