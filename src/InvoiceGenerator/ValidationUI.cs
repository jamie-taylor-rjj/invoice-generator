using System;
using System.Net.Mail;

namespace InvoiceGenerator
{
    public class ValidationUI
    {
        public bool[] validateUserDetails(string clientName, string clientAddress, string contactName, string contactEmail) // Validate all inputs on clientdetailsentryscreen
        {
            bool clientNameValid, clientAddressValid, contactNameValid, contactEmailValid;
            clientNameValid = clientAddressValid = contactNameValid = contactEmailValid = true; // Set all values to 'true'

            if (String.IsNullOrWhiteSpace(clientName))  // If the client name is empty, or a bunch of spaces, error
            {
                clientNameValid = false; // Set clientNameValid to false as client name was not valid
            }
            if (String.IsNullOrWhiteSpace(clientAddress))
            {
                clientAddressValid = false;
            }
            if (String.IsNullOrWhiteSpace(contactName))
            {
                contactNameValid = false;
            }
            if (String.IsNullOrWhiteSpace(contactEmail))
            {
                contactEmailValid = false;
            }

            bool[] validDetails = { clientNameValid, clientAddressValid, contactNameValid, contactEmailValid };

            return validDetails; // Return all the boolean values for selection later
        }

        public bool validateEmailFormat(string contactEmail)    // Validate the contact email to see if its of the correct format
        {
            bool emailFormatValid;

            try
            {
                MailAddress mailAddress = new MailAddress(contactEmail); // Validate the email using an email checker
                emailFormatValid = true; // Set emailFormatValid to true as email is of the correct format
            }
            catch (FormatException) // Catch error so program doesn't crash
            {
                emailFormatValid = false; // Set emailFormatValid to false as email is not of the correct format
            }

            return emailFormatValid; // Return boolean value for selection later
        }

        public bool validateComboBoxChoice(string comboBoxChoice)
        {
            bool comboBoxChoiceValid;
            comboBoxChoiceValid = true; // Set value to 'true'

            if (comboBoxChoice == "Please Select:") // If user has not selexted a client, throw error
            {
                comboBoxChoiceValid = false;    // Set comboBoxChoiceValid to false as comboBoxChoice was not valid
            }

            return comboBoxChoiceValid; // Return boolean value for selection later
        }

        public bool[] validateLineItemDetails(string lineItemDescription, string lineItemCost, string lineItemQuantity) // Validate line item inputs on invoicegenerationscreen
        {
            bool lineItemDescriptionValid, lineItemCostValid, lineItemQuantityValid;
            lineItemDescriptionValid = lineItemCostValid = lineItemQuantityValid = true; // Set all values to 'true'

            if (String.IsNullOrWhiteSpace(lineItemDescription)) // If the line item description is empty, throw error
            {
                lineItemDescriptionValid = false;   // Set lineItemDescription to false as lineItemDescription was not valid
            }
            if (String.IsNullOrWhiteSpace(lineItemCost))
            {
                lineItemCostValid = false;
            }
            if (String.IsNullOrWhiteSpace(lineItemQuantity))
            {
                lineItemQuantityValid = false;
            }

            bool[] validLineItemDetails = { lineItemDescriptionValid, lineItemCostValid, lineItemQuantityValid };

            return validLineItemDetails; // Return boolean values for selection later
        }

        public bool checkCost(string lineItemCost)   // Check if cost from invoicegenerationscrren is a double
        {
            double result;
            bool validCost;
            validCost = true;

            bool validParse = double.TryParse(lineItemCost, out result); // Try convert lineItemCost input to a double

            if (validParse) // If the parse was succesful...
            {
                validCost = true; // Set validCost to true
            }
            else // If the parse was not successful...
            {
                validCost = false; // Set validCost to false;
            }

            return validCost; // Return boolean value for selection later
        }

        public bool checkQuantity(string lineItemQuantity) // Check if quantity from invoicegenerationscreen is only digits
        {
            int result;
            bool validQuantity;
            validQuantity = true;

            bool validParse = int.TryParse(lineItemQuantity, out result); // Try convert lineItemQuantity input to an int

            if (validParse) // If the parse was successful...
            {
                validQuantity = true; // Set validQuantity to true
            }
            else // If the parse was not succesful...
            {
                validQuantity = false; // Set validQuantity to false
            }

            return validQuantity; // Return boolean value for selection later
        }
    }
}
