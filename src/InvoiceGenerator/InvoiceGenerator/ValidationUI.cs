using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
