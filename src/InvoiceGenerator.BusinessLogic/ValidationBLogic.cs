using System;
using System.Net.Mail;

namespace InvoiceGenerator.BusinessLogic
{
    public class ValidationBLogic
    {
        public string[] validateUserDetails(string clientName, string clientAddress, string contactName, string contactEmail) // Validate all user inputs on client details entry screen
        {
            string clientNameErrorMsg = "No error!", clientAddressErrorMsg = "No error!", contactNameErrorMsg = "No error!", contactEmailErrorMsg = "No error!";

            if (String.IsNullOrWhiteSpace(clientName))  // If client name is null or white space
            {
                clientNameErrorMsg = "Client Name must not be empty!"; // Make error message
            }
            if (String.IsNullOrWhiteSpace(clientAddress))
            {
                clientAddressErrorMsg = "Client Address must not be empty!";
            }
            if (String.IsNullOrWhiteSpace(contactName))
            {
                contactNameErrorMsg = "Contact Name must not be empty!";
            }
            if (String.IsNullOrWhiteSpace(contactEmail))
            {
                contactEmailErrorMsg = "Contact Email must not be empty!";
            }

            string[] errorMessages = { clientNameErrorMsg, clientAddressErrorMsg, contactNameErrorMsg, contactEmailErrorMsg };

            return errorMessages; // Return all the error messages
        }

        public string validateEmailFormat(string contactEmail)  // Validate contact email input to see if it is of the correct format
        {
            string emailFormatErrorMsg;

            try
            {
                MailAddress mailAddress = new MailAddress(contactEmail); // Validate email with an email checker
                emailFormatErrorMsg = "No error!";
            }
            catch (FormatException) // Catch error so program does not crash
            {
                emailFormatErrorMsg = "Contact Email must be formatted correctly!"; // Make error message
            }

            return emailFormatErrorMsg; // Return error message
        }

        public string validateComboBoxChoice(string comboBoxChoice)
        {
            string comboBoxChoiceErrorMsg = "No error!";

            if (comboBoxChoice == "Please Select:") // If user has not selexted a client, throw error
            {
                comboBoxChoiceErrorMsg = "Please select a client!";    // Make error message
            }

            return comboBoxChoiceErrorMsg; // Return error message
        }

        public string[] validateLineItemDetails(string lineItemDescription, string lineItemCost, string lineItemQuantity)
        {
            string lineItemDescriptionErrorMsg = "No error!", lineItemCostErrorMsg = "No error!", lineItemQuantityErrorMsg = "No error!";
            
            if (String.IsNullOrWhiteSpace(lineItemDescription)) // If the line item description is empty, throw error
            {
                lineItemDescriptionErrorMsg = "Line Item Description must not be empty!"; // Make error message
            }
            if (String.IsNullOrWhiteSpace(lineItemCost))
            {
                lineItemCostErrorMsg = "Line Item Cost must not be empty!";
            }
            if (String.IsNullOrWhiteSpace(lineItemQuantity))
            {
                lineItemQuantityErrorMsg = "Line Item Quantity must not be empty!";
            }

            string[] errorMessages = { lineItemDescriptionErrorMsg, lineItemCostErrorMsg, lineItemQuantityErrorMsg };

            return errorMessages;   // Return all the error messages
        }

        public string checkCost(string lineItemCost)
        {
            double result;
            string validCostErrorMsg;

            bool validParse = double.TryParse(lineItemCost, out result); // Try convert lineItemCost input to a double

            if (validParse) // If the parse was successful...
            {
                validCostErrorMsg = "Line Item Cost must be a decimal number!"; // Make error message
            }
            else // If the parse was not successful..
            {
                validCostErrorMsg = "No error!"; // No error
            }

            return validCostErrorMsg; // Return error message
        }

        public string checkQuantity(string lineItemQuantity)
        {
            int result;
            string validQuantityErrorMsg;

            bool validParse = int.TryParse(lineItemQuantity, out result); // Try convert lineItemQuantity input to an int

            if (validParse) // If the parse was successful...
            {
                validQuantityErrorMsg = "Line Item Cost must be an integer!"; // Make error message
            }
            else // If the parse was not successful...
            {
                validQuantityErrorMsg = "No error!"; // No error
            }

            return validQuantityErrorMsg; // Return error message
        }

    }
}
