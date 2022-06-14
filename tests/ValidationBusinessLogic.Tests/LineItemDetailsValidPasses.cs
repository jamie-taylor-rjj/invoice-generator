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
    public class LineItemDetailsValidPasses
    {
        [Fact]
        public void Check_If_NoError_Is_Returned_When_Valid_Details_Input()
        {
            // Arrange
            var expectedResult = new LineItemViewModelValidationResult()
            {
                LineItemDescriptionValidationMessage = "No error!",
                LineItemCostValidationMessage = "No error!",
                LineItemQuantityValidationMessage = "No error!"
            };
            var viewModel = new LineItemViewModel()
            {
                Description = "Butter",
                CostPer = "1.65",
                Quantity = "3"
            };
            var SUT = new ValidationBLogic();
            // Act
            var result = SUT.validateLineItemDetails(viewModel);
            // Assert
            Assert.Equal(expectedResult.LineItemDescriptionValidationMessage, result.LineItemDescriptionValidationMessage);
            Assert.Equal(expectedResult.LineItemCostValidationMessage, result.LineItemCostValidationMessage);
            Assert.Equal(expectedResult.LineItemQuantityValidationMessage, result.LineItemQuantityValidationMessage);
        }

        [Fact]
        public void Check_If_NoError_Is_Returned_When_Valid_Cost_Input()
        {
            // Arrange
            var expectedResult = new LineItemViewModelValidationResult()
            {
                LineItemCheckCostValidationMessage = "No error!"
            };
            var viewModel = new LineItemViewModel()
            {
                CostPer = "1.65"
            };
            var SUT = new ValidationBLogic();
            // Act
            var result = SUT.checkCost(viewModel);
            // Assert
            Assert.Equal(expectedResult.LineItemCheckCostValidationMessage, result.LineItemCheckCostValidationMessage);
        }

        [Fact]
        public void Check_If_NoError_Is_Returned_When_Valid_Quantity_Input()
        {
            // Arrange
            var expectedResult = new LineItemViewModelValidationResult()
            {
                LineItemCheckQuantityValidationMessage = "No error!"
            };
            var viewModel = new LineItemViewModel()
            {
                Quantity = "3"
            };
            var SUT = new ValidationBLogic();
            // Act
            var result = SUT.checkQuantity(viewModel);
            // Assert
            Assert.Equal(expectedResult.LineItemCheckQuantityValidationMessage, result.LineItemCheckQuantityValidationMessage);
        }
    }
}
