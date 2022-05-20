using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
