using InvoiceGenerator.ViewModels;
using System;
using System.Net.Mail;

namespace InvoiceGenerator
{
    public class ValidationUI
    {
        public bool[] validateUserDetails(ClientViewModel viewModel, out int index) // Validate all inputs on clientdetailsentryscreen
        {
            bool clientNameValid, clientAddressValid, contactNameValid, contactEmailValid;
            clientNameValid = clientAddressValid = contactNameValid = contactEmailValid = true; // Set all values to 'true'
            index = 0;

            if (String.IsNullOrWhiteSpace(viewModel.ContactEmail)) // If the contact email is empty, or a bunch of spaces, error
            {
                contactEmailValid = false; // Set contactEmailValid to false as contact email was not valid
                index = 4;
            }
            if (String.IsNullOrWhiteSpace(viewModel.ContactName))
            {
                contactNameValid = false;
                index = 3;
            }
            if (string.IsNullOrWhiteSpace(viewModel.ClientAddress))
            {
                clientAddressValid = false;
                index = 2;
            }
            if (String.IsNullOrWhiteSpace(viewModel.ClientName))
            {
                clientNameValid = false;
                index = 1;
            }

            bool[] validDetails = { clientNameValid, clientAddressValid, contactNameValid, contactEmailValid };

            return validDetails; // Return all the boolean values for selection later
        }

        public bool validateEmailFormat(ClientViewModel viewModel, out int index)    // Validate the contact email to see if its of the correct format
        {
            bool emailFormatValid;
            index = 0;

            try
            {
                MailAddress mailAddress = new MailAddress(viewModel.ContactEmail); // Validate the email using an email checker
                emailFormatValid = true; // Set emailFormatValid to true as email is of the correct format
            }
            catch (FormatException) // Catch error so program doesn't crash
            {
                emailFormatValid = false; // Set emailFormatValid to false as email is not of the correct format
                index = 5;
            }

            return emailFormatValid; // Return boolean value for selection later
        }

        public bool[] validateLineItemDetails(string lineItemDescription, string lineItemCost, string lineItemQuantity, out int index) // Validate line item inputs on invoicegenerationscreen
        {
            bool lineItemDescriptionValid, lineItemCostValid, lineItemQuantityValid;
            lineItemDescriptionValid = lineItemCostValid = lineItemQuantityValid = true; // Set all values to 'true'
            index = 0;

            if (String.IsNullOrWhiteSpace(lineItemQuantity)) // If the line item quantity is empty, or a bunch of spaces, error
            {
                lineItemQuantityValid = false; // Set lineItemQuantityValid to false as line item quantity was not valid
                index = 3;
            }
            if (String.IsNullOrWhiteSpace(lineItemCost))
            {
                lineItemCostValid = false;
                index = 2;
            }
            if (String.IsNullOrWhiteSpace(lineItemDescription))
            {
                lineItemDescriptionValid = false;
                index = 1;
            }

            bool[] validLineItemDetails = { lineItemDescriptionValid, lineItemCostValid, lineItemQuantityValid };

            return validLineItemDetails; // Return boolean values for selection later
        }

        public bool checkCost(string lineItemCost, out int index)   // Check if cost from invoicegenerationscrren is a double
        {
            double result;
            bool validCost;
            validCost = true;
            index = 0;

            bool validParse = double.TryParse(lineItemCost, out result); // Try convert lineItemCost input to a double

            if (validParse) // If the parse was succesful...
            {
                validCost = true; // Set validCost to true
            }
            else // If the parse was not successful...
            {
                validCost = false; // Set validCost to false;
                index = 4;
            }

            return validCost; // Return boolean value for selection later
        }

        public bool checkQuantity(string lineItemQuantity, out int index) // Check if quantity from invoicegenerationscreen is only digits
        {
            int result;
            bool validQuantity;
            validQuantity = true;
            index = 0;

            bool validParse = int.TryParse(lineItemQuantity, out result); // Try convert lineItemQuantity input to an int

            if (validParse) // If the parse was successful...
            {
                validQuantity = true; // Set validQuantity to true
            }
            else // If the parse was not succesful...
            {
                validQuantity = false; // Set validQuantity to false
                index = 5;
            }

            return validQuantity; // Return boolean value for selection later
        }

        public bool checkVAT(string VAT, out int index) // Check if VAT from invoicegenerationscreen is only digits
        {
            int result;
            bool validVAT;
            validVAT = true;
            index = 0;

            bool validParse = int.TryParse(VAT, out result); // Try convert VAT input to an int

            if (validParse) // If the parse was successful...
            {
                validVAT = true;
            }
            else // If the parse was not successful...
            {
                validVAT = false;
                index = 6;
            }

            return validVAT; // Return boolean value for selection later
        }
    }

}
