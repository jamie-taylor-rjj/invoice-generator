using InvoiceGenerator.BusinessLogic;
using InvoiceGenerator.ViewModels;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace InvoiceGenerator
{
    public partial class ClientDetailsEntryScreen : Form
    {
        private readonly IClientService _clientService;

        private int index;

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

            var viewModel = new ClientViewModel()
            {
                ClientName = txt_clientName.Text,
                ClientAddress = txt_clientAddress.Text,
                ContactName = txt_contactName.Text,
                ContactEmail = txt_contactEmail.Text
            };

            bool[] validDetails = validationUI.validateUserDetails(viewModel, out index);      // Check for white space or null values for all inputs
            string[] validDetailsErrorMsgs = validationBLogic.validateUserDetails(viewModel);  // Obtain error messages for all inputs

            if (validDetails[0] && validDetails[1] && validDetails[2] && validDetails[3]) // If all checks are passed, do below
            {
                showUserDetailsErrorMsgs(validDetailsErrorMsgs, index); // Make text boxes white again as they are valid

                bool validEmailFormat = validationUI.validateEmailFormat(viewModel, out index);     // Check if the email input is of the correct format
                string validEmailFormatErrorMsg = validationBLogic.validateEmailFormat(viewModel);  // Obtain error message for the email input

                if (validEmailFormat)   // If the email is valid and user details are valid, insert new client
                {
                    showEmailFormatErrorMsg(validEmailFormatErrorMsg, index);

                    // Here we are using the injected class which matches the IClientService interface
                    _clientService.AddClient(viewModel); // Call method in business logic layer to add a new client

                    string message = "Client created successfully!";
                    string caption = "Success!";
                    DialogResult dialogResult = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Show confirmation message to the user, obtain result from it

                    if (dialogResult == DialogResult.OK) // Upon user pressing OK on message box, do below...
                    {
                        clearTextBoxes(); // Reset all text boxes so user can enter a new client
                    }
                }
                else    // If email is not valid, do below...
                {
                    showEmailFormatErrorMsg(validEmailFormatErrorMsg, index);
                }
            }
            else    // If any checks are failed, show error messages
            {
                showUserDetailsErrorMsgs(validDetailsErrorMsgs, index); // Show error messages
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

        #region Miscellaneous
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
        #endregion

        #region ErrorMessages
        private void showUserDetailsErrorMsgs(string[] validDetailsErrorMsgs, int index)
        {
            string message;
            string caption;

            switch (index)
            {
                case 1:
                    txt_clientName.BackColor = Color.FromArgb(0xFF, 0xFF, 0xCA, 0xCA); // Set the colour of the client name text box to red to visibly show error
                    txt_clientName.Focus();                                            // Put mouse cursor in the client name text box
                    message = validDetailsErrorMsgs[0];
                    caption = "Client Name Error!";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Display error message box to user
                    break;
                case 2:
                    txt_clientAddress.BackColor = Color.FromArgb(0xFF, 0xFF, 0xCA, 0xCA);
                    txt_clientAddress.Focus();
                    message = validDetailsErrorMsgs[1];
                    caption = "client Address Error!";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 3:
                    txt_contactName.BackColor = Color.FromArgb(0xFF, 0xFF, 0xCA, 0xCA);
                    txt_contactName.Focus();
                    message = validDetailsErrorMsgs[2];
                    caption = "Contact Name Error!";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 4:
                    txt_contactEmail.BackColor = Color.FromArgb(0xFF, 0xFF, 0xCA, 0xCA);
                    txt_contactEmail.Focus();
                    message = validDetailsErrorMsgs[3];
                    caption = "Contact Email Error!";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                default:
                    txt_clientName.BackColor = Color.White;
                    txt_clientAddress.BackColor = Color.White;
                    txt_contactName.BackColor = Color.White;
                    txt_contactEmail.BackColor = Color.White;
                    break;
            }
        }

        private void showEmailFormatErrorMsg(string validEmailFormatErrorMsg, int index)
        {
            string message;
            string caption;

            switch (index)
            {
                case 5:
                    txt_contactEmail.BackColor = Color.FromArgb(0xFF, 0xFF, 0xCA, 0xCA);
                    txt_contactEmail.Focus();
                    message = validEmailFormatErrorMsg;
                    caption = "Contact Email Error!";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                default:
                    txt_contactEmail.BackColor = Color.White;
                    break;
            }
        }
        #endregion
    }
}
