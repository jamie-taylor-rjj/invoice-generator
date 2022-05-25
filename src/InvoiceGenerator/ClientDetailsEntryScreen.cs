using InvoiceGenerator.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceGenerator
{
    public partial class ClientDetailsEntryScreen : Form
    {
        private readonly IClientService _clientService;

        // We're asking the DI container to find a class which satisfies the
        // IClientService interface and inject it in here.
        public ClientDetailsEntryScreen(IClientService clientService)
        {
            InitializeComponent();
            _clientService = clientService;
        }

        #region ButtonClicks
        private void btn_enterDetails_Click(object sender, EventArgs e)
        {
            pnl_viewDetails.Hide();
            pnl_enterDetails.Show();
        }

        private void btn_viewDetails_Click(object sender, EventArgs e)
        {
            pnl_enterDetails.Hide();
            pnl_viewDetails.Show();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            ValidationUI validationUI = new ValidationUI();          // ValidationUI methods will return the boolean values for the variables, this determines if they are actually valid or not
            ValidationBLogic validationBLogic = new ValidationBLogic();  // ValidationBLogic methods will return the error messages for the variables

            bool[] validDetails = validationUI.validateUserDetails(txt_clientName.Text, txt_clientAddress.Text, txt_contactName.Text, txt_contactEmail.Text); // Check for white space or null values for all inputs
            string[] validDetailsErrorMsgs = validationBLogic.validateUserDetails(txt_clientName.Text, txt_clientAddress.Text, txt_contactName.Text, txt_contactEmail.Text);    // Obtain error messages for all the inputs

            if (validDetails[0] && validDetails[1] && validDetails[2] && validDetails[3])   // If all checks are passed, do below
            {
                showUserDetailsErrorMsgs(validDetails, validDetailsErrorMsgs); // Hide error messages as they are valid

                bool validEmailFormat = validationUI.validateEmailFormat(txt_contactEmail.Text);    // Check if the email input is of the correct format
                string validEmailFormatErrorMsg = validationBLogic.validateEmailFormat(txt_contactEmail.Text);  // Obtain error message for the email input

                if (validEmailFormat)   // If the email is valid and user details are valid, insert new client
                {
                    showEmailFormatErrorMsg(validEmailFormat, validEmailFormatErrorMsg);    // Hide error messages as they are valid

                    // Here we are using the injected class which matches the IClientService interface
                    _clientService.AddClients(txt_clientName.Text, txt_clientAddress.Text, txt_contactName.Text, txt_contactEmail.Text);   // Call method in business logic layer to add a new client

                    string message = "Client created successfully!";
                    string caption = "Success!";
                    DialogResult digalogResult = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Show confirmation message to the user, obtain result from it

                    if (digalogResult == DialogResult.OK) // Upon user pressing OK, do below...
                    {
                        clearTextBoxes(); // Reset all text boxes so user can enter a new client
                    }
                }
                else    // If email is not valid, do below...
                {
                    showEmailFormatErrorMsg(validEmailFormat, validEmailFormatErrorMsg);    // Show email format error message
                }
            }
            else    // If user details aren't valid (White space or null values), do below...
            {
                showUserDetailsErrorMsgs(validDetails, validDetailsErrorMsgs); // Show user details error messages
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();   // Closes the current form 'ClientDetailsEntryScreen'
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            // Here we are using the injected class which matches the IClientService interface          
            var viewModels = _clientService.GetClients(); // Obtain all the client details from the database
            dtaGridDetails.DataSource = viewModels; // Fill the data grid with all the client details

            string message = "Clients viewed successfully!";
            string caption = "Success!";
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Show confirmation message to user
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit2_Click(object sender, EventArgs e)
        {
            this.Close();   // Closes the current form 'ClientDetailsEntryScreen'
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            // Create an instance of a new form 'NewStartScreen'
            StartScreen NewStartScreen = new StartScreen(_clientService);
            // Hides the current form 'ClientDetailsEntryScreen'
            this.Hide();
            // When the 'NewStartScreen' is closed, close the current form 'ClientDetailsEntryScreen'
            NewStartScreen.FormClosed += (s, args) => this.Close();
            // Show the 'NewStartScreen' to the screen
            NewStartScreen.Show();
            // Opens the 'NewStartScreen' in the same location as where the 'ClientDetailsEntryScreen' was closed
            NewStartScreen.Location = this.Location;
        }
        #endregion

        private void onFormLoad(object sender, EventArgs e)
        {
            pnl_enterDetails.Hide();
            pnl_viewDetails.Hide();
            btn_Previous.Hide();
            btn_Next.Hide();
            lbl_pageNo.Hide();
        }

        private void clearTextBoxes()
        {
            // Reset all the textboxes
            txt_clientName.Text = String.Empty;
            txt_clientAddress.Text = String.Empty;
            txt_contactName.Text = String.Empty;
            txt_contactEmail.Text = String.Empty;
            txt_clientName.Focus(); // Put the mouse cursor in the first text box
        }

        #region ErrorMessages
        private void showUserDetailsErrorMsgs(bool[] validDetails, string[] validDetailsErrorMsgs)
        {
            if (validDetails[0] == false)   // If the client name is empty, throw error
            {
                txt_clientName.BackColor = Color.FromArgb(0xFF, 0xFF, 0xCA, 0xCA);  // Make client name text box red to visibly show error
                txt_clientName.Focus();     // Put mouse cursor in the client name text box
                string message = validDetailsErrorMsgs[0];
                string caption = "Error!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Display error message box to user
            }
            else if (validDetails[0] == true)
            {
                txt_clientName.BackColor = Color.White;
            }
            if (validDetails[1] == false)   // If the client address is empty, throw error
            {
                txt_clientAddress.BackColor = Color.FromArgb(0xFF, 0xFF, 0xCA, 0xCA);
                txt_clientAddress.Focus();
                string message = validDetailsErrorMsgs[1];
                string caption = "Error!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (validDetails[1] == true)
            {
                txt_clientAddress.BackColor = Color.White;
            }
            if (validDetails[2] == false)   // If the contact name is empty, throw error
            {
                txt_contactName.BackColor = Color.FromArgb(0xFF, 0xFF, 0xCA, 0xCA);
                txt_contactName.Focus();
                string message = validDetailsErrorMsgs[2];
                string caption = "Error!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (validDetails[2] == true)
            {
                txt_contactName.BackColor = Color.White;
            }
            if (validDetails[3] == false)   // If the contact email is empty, throw error
            {
                txt_contactEmail.BackColor = Color.FromArgb(0xFF, 0xFF, 0xCA, 0xCA);
                txt_contactEmail.Focus();
                string message = validDetailsErrorMsgs[3];
                string caption = "Error!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (validDetails[3] == true)
            {
                txt_contactEmail.BackColor = Color.White;
            }
        }

        private void showEmailFormatErrorMsg(bool validEmailFormat, string validEmailFormatErrorMsg)
        {
            if (validEmailFormat == false)  // If the contact email is not formatted correctly, throw error
            {
                txt_contactEmail.BackColor = Color.FromArgb(0xFF, 0xFF, 0xCA, 0xCA);
                txt_contactEmail.Focus();
                string message = validEmailFormatErrorMsg;
                string caption = "Error!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (validEmailFormat == true)
            {
                txt_contactEmail.BackColor = Color.White;
            }
        }
        #endregion
    }
}
