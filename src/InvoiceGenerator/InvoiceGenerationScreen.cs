﻿using InvoiceGenerator.BusinessLogic;
using InvoiceGenerator.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace InvoiceGenerator
{
    public partial class InvoiceGenerationScreen : Form
    {
        private readonly string DEFAULT_SELECT_STRING = "--SELECT--";

        private readonly IClientService _clientService;
        public InvoiceGenerationScreen(IClientService clientService)
        {
            InitializeComponent();
            _clientService = clientService;
            fillComboBox();
        }

        #region ButtonClicks
        private void btn_Generate_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_addLineItem_Click(object sender, EventArgs e)
        {
            ValidationUI validationUI = new ValidationUI();          // ValidationUI methods will return the boolean values for the variables, this determines if they are actually valid or not
            ValidationBLogic validationBLogic = new ValidationBLogic();  // ValidationBLogic methods will return the error messages for the variables

            bool[] validLineItemDetails = validationUI.validateLineItemDetails(txt_lineItemDescription.Text, txt_lineItemCost.Text, txt_lineItemQuantity.Text); // Check for white space or null values for all inputs
            string[] validLineItemDetailsErrorMsgs = validationBLogic.validateLineItemDetails(txt_lineItemDescription.Text, txt_lineItemCost.Text, txt_lineItemQuantity.Text); // Obtain error messages for all the inputs

            if (validLineItemDetails[0] && validLineItemDetails[1] && validLineItemDetails[2]) // If all checks are passed, do below
            {
                showLineItemDetailsErrorMsgs(validLineItemDetails, validLineItemDetailsErrorMsgs); // Make text boxes white again as inputs are valid

                bool validLineItemCost = validationUI.checkCost(txt_lineItemCost.Text);
                string validLineItemCostErrorMsg = validationBLogic.checkCost(txt_lineItemCost.Text);
                bool validLineItemQuantity = validationUI.checkQuantity(txt_lineItemQuantity.Text);
                string validLineItemQuantityErrorMsg = validationBLogic.checkQuantity(txt_lineItemQuantity.Text);

                if (validLineItemCost && validLineItemQuantity) // If cost and quantity are valid, add line item to datagrid
                {
                    showLineItemCostAndQuantityErrorMsgs(validLineItemCost, validLineItemCostErrorMsg, validLineItemQuantity, validLineItemQuantityErrorMsg); // Make text boxes white again as inputs are valid
                }
                else // If cost and quantity are not valid, do below...
                {
                    showLineItemCostAndQuantityErrorMsgs(validLineItemCost, validLineItemCostErrorMsg, validLineItemQuantity, validLineItemQuantityErrorMsg); // Show lineItemCost and lineItemQuantity error messages 
                }
            }
            else    // If line item details aren't valid (White Space or null values), do below...
            {
                showLineItemDetailsErrorMsgs(validLineItemDetails, validLineItemDetailsErrorMsgs); // Show line item details error messages
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            // Create an instance of a new form 'NewStartScreen'
            StartScreen NewStartScreen = new StartScreen(_clientService);
            // Hides the current form 'InvoiceGenerationScreen'
            this.Hide();
            // When the 'NewStartScreen' is closed, close the current form 'InvoiceGenerationScreen'
            NewStartScreen.FormClosed += (s, args) => this.Close();
            // Show the 'NewStartScreen' to the screen
            NewStartScreen.Show();
            // Opens the 'NewStartScreen' in the same location as where the 'InvoiceGenerationScreen' was closed
            NewStartScreen.Location = this.Location;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the current form 'InvoiceGenerationScreen'
        }
        #endregion

        private void fillComboBox()
        {
            var service = new ClientService();

            var listOfClients = new List<ClientNameViewModel>()
            {
                new ClientNameViewModel
                {
                    ClientName = DEFAULT_SELECT_STRING,
                    Id = Guid.NewGuid(),
                }
            };

            var listFromDb = service.GetClientNames();

            listOfClients.AddRange(listFromDb);

            combox_clientNames.DataSource = listOfClients;
            combox_clientNames.DisplayMember = nameof(ClientNameViewModel.ClientName);
            combox_clientNames.ValueMember = nameof(ClientNameViewModel.Id);
            pnl_invoiceGenerationDetails.Hide();
        }

        private void combox_clientNames_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedClientViewModel = (ClientNameViewModel)combox_clientNames.SelectedItem;
            if (string.Equals(DEFAULT_SELECT_STRING, selectedClientViewModel.ClientName, StringComparison.OrdinalIgnoreCase))
            {
                // Drop out here, as the user has selected the default item in the list
                // OR we're still populating the list
                // (the SelectedValueChanged and SelectedIndexChanged events fire when the
                // first item is added to the list
                return;
            }

            // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            ValidationUI validationUI = new ValidationUI();          // ValidationUI methods will return the boolean values for the variables, this determines if they are actually valid or not
            ValidationBLogic validationBLogic = new ValidationBLogic();  // ValidationBLogic methods will return the error messages for the variables

            bool validComboBoxChoice = validationUI.validateComboBoxChoice(Convert.ToString(combox_clientNames.SelectedItem));               // Check if user has selected a client
            string validComboBoxChoiceErrorMsg = validationBLogic.validateComboBoxChoice(Convert.ToString(combox_clientNames.SelectedItem)); // Obtain error message for combo box input

            if (validComboBoxChoice) // If check has passsed, do below...
            {
                showComboBoxChoiceErrorMsg(validComboBoxChoice, validComboBoxChoiceErrorMsg); // Make combo box white again as input is valid

                pnl_invoiceGenerationDetails.Show();

                string clientChoice = combox_clientNames.SelectedItem.ToString();
                string dateToday = DateTime.Today.ToString("dd-mm-yyyy");
                txt_invoiceRef.Text = $"{clientChoice}-{dateToday}";
            }
            else
            {
                showComboBoxChoiceErrorMsg(validComboBoxChoice, validComboBoxChoiceErrorMsg); // Show combo box error messages
            }
            // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            // Above won't work till combo box error fixes

            pnl_invoiceGenerationDetails.Show();

            var clientName = selectedClientViewModel.ClientName;
            var todayAsString = DateTime.Today.ToString("dd-mm-yyyy");
            txt_invoiceRef.Text = $"RJJ-{clientName}-{todayAsString}";

            // You should be able to use selectedClientViewModel to do all the things you need

        }

        #region ErrorMessages
        private void showComboBoxChoiceErrorMsg(bool validComboBoxChoice, string validComboBoxChoiceErrorMsg)
        {
            if (validComboBoxChoice == false)   // If user has not selected a client, throw error
            {
                combox_clientNames.BackColor = Color.FromArgb(0xFF, 0xFF, 0xCA, 0xCA); // Make combo box red to visibly show error
                combox_clientNames.Focus(); // Put mouse cursor in the combo box
                string message = validComboBoxChoiceErrorMsg;
                string caption = "Error!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Display erorr message box to user
            }
            else if (validComboBoxChoice == true)
            {
                combox_clientNames.BackColor = Color.White;
            }
        }

        private void showLineItemDetailsErrorMsgs(bool[] validLineItemDetails, string[] validLineItemDetailsErrorMsgs)
        {
            if (validLineItemDetails[0] == false) // If the line item description is empty, throw error
            {
                txt_lineItemDescription.BackColor = Color.FromArgb(0xFF, 0xFF, 0xCA, 0xCA); // Make line item description text box red to visibly show error
                txt_lineItemDescription.Focus();    // Put mouse cursor in the client name text box
                string message = validLineItemDetailsErrorMsgs[0];
                string caption = "Error!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Display error messagebox to user
            }
            else if (validLineItemDetails[0] == true)
            {
                txt_lineItemDescription.BackColor = Color.White;
            }
            if (validLineItemDetails[1] == false) // If the line item cost is empty, throw error
            {
                txt_lineItemCost.BackColor = Color.FromArgb(0xFF, 0xFF, 0xCA, 0xCA);
                txt_lineItemCost.Focus();
                string message = validLineItemDetailsErrorMsgs[1];
                string caption = "Error!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (validLineItemDetails[1] == true)
            {
                txt_lineItemCost.BackColor = Color.White;
            }
            if (validLineItemDetails[2] == false) // If the line item quantity is empty, throw error
            {
                txt_lineItemQuantity.BackColor = Color.FromArgb(0xFF, 0xFF, 0xCA, 0xCA);
                txt_lineItemQuantity.Focus();
                string message = validLineItemDetailsErrorMsgs[2];
                string caption = "Error!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (validLineItemDetails[2] == true)
            {
                txt_lineItemQuantity.BackColor = Color.FromArgb(0xFF, 0xFF, 0xCA, 0xCA);
            }
        }

        private void showLineItemCostAndQuantityErrorMsgs(bool validLineItemCost, string validLineItemCostErrorMsg, bool validLineItemQuantity, string validLineItemQuantityErrorMsg)
        {
            if (validLineItemCost == false)
            {
                txt_lineItemCost.BackColor = Color.FromArgb(0xFF, 0xFF, 0xCA, 0xCA);
                txt_lineItemCost.Focus();
                string message = validLineItemCostErrorMsg;
                string caption = "Error!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (validLineItemCost == true)
            {
                txt_lineItemCost.BackColor = Color.White;
            }
            if (validLineItemQuantity == false)
            {
                txt_lineItemQuantity.BackColor = Color.FromArgb(0xFF, 0xFF, 0xCA, 0xCA);
                txt_lineItemQuantity.Focus();
                string message = validLineItemQuantityErrorMsg;
                string caption = "Error!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (validLineItemQuantity == true)
            {
                txt_lineItemQuantity.BackColor = Color.White;
            }
        }
        #endregion

        //private void combox_clientNames_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    var selected = (int)combox_clientNames.SelectedIndex;
        //    var name = (ClientNameViewModel)combox_clientNames.SelectedItem;
        //    if (name !=null)
        //    {

        //    }
        //}
    }
}