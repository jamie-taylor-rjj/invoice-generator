using InvoiceGenerator.BusinessLogic;
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

        private int index;

        public InvoiceGenerationScreen(IClientService clientService)
        {
            InitializeComponent();
            _clientService = clientService;
            fillComboBox();
            equalColumnWidths();
        }

        #region ButtonClicks
        private void btn_Generate_Click(object sender, EventArgs e)
        {
            ValidationUI validationUI = new ValidationUI(); // ValidationUI methods will return the boolean values for the variables, this determines if they are valid or not
            ValidationBLogic validationBLogic = new ValidationBLogic(); // ValidationBLogic methods will return the error messages for the variables

            var viewModel = new InvoiceViewModel()
            {
                VatRate = txt_vatOrSalesTax.Text,
            };

            bool validVAT = validationUI.checkVAT(txt_vatOrSalesTax.Text, out index);
            InvoiceViewModelValidationResult validationResult = validationBLogic.checkVAT(viewModel);

            if (validationResult.IsValidVAT()) // If check is passed, do below...
            {
                showVATErrorMsg(validationResult); // Make text box white as input is valid

                string caption = "Line Item Details:";
                int numberOfRows = dtaGridLineItems.Rows.Count; // Get the number of rows in the datagrid

                if (numberOfRows > 1)
                {
                    numberOfRows = dtaGridLineItems.Rows.Count - 1;
                }

                for (int i = 0; i < numberOfRows; i++) // For every single row in the datagrid, do below
                {
                    string description = dtaGridLineItems.Rows[i].Cells[0].Value.ToString(); // Get the line item description
                    string cost = dtaGridLineItems.Rows[i].Cells[1].Value.ToString();        // Get the line item cost
                    string quantity = dtaGridLineItems.Rows[i].Cells[2].Value.ToString();    // Get the line item quanity
                    string total = dtaGridLineItems.Rows[i].Cells[3].Value.ToString();       // Get the line item total

                    MessageBox.Show("Line Item Description: " + description + "\n" + // Display message box for each line item
                        "Line Item Cost: " + "£" + cost + "\n" +
                        "Line Item Quantity: " + quantity + "\n" +
                        "Line Item Total: " + "£" + total, caption, MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }

                string invoiceReference = txt_invoiceRef.Text;
                string VAT = txt_vatOrSalesTax.Text;

                double totalValue = 0;

                for (int i = 0; i < numberOfRows; i++) // For every single row in the datagrid, do below
                {
                    totalValue += double.Parse(dtaGridLineItems.Rows[i].Cells[3].Value.ToString()); // Obtain the total cost of all the line items
                }
                totalValue = Math.Round(totalValue, 2); // Round the totalValue to 2 decimal points

                //double invoiceTotal = (Convert.ToDouble(totalValue) + Convert.ToDouble(totalValue) * Convert.ToDouble(VAT)) / 100;
                double invoiceTotal = totalValue + (totalValue * double.Parse(VAT) / 100); // Calculate invoiceTotal based on totalValue and VAT
                invoiceTotal = Math.Round(invoiceTotal, 2); // Round invoiceTotal to 2 decimal points

                string issueDate = DateTime.Today.ToString("dd-MM-yyyy"); // Obtain the issue date
                string dueDate = DateTime.Today.AddMonths(1).ToString("dd-MM-yyyy"); // Obtain the due date (issue date + plus a month)

                MessageBox.Show("Invoice Refrence: " + invoiceReference + "\n" + // Display message box for the invoice
                    "Total Value: " + "£" + totalValue + "\n" +
                    "VAT Rate: " + VAT + "%" + "\n" +
                    "Issue Date: " + issueDate + "\n" +
                    "Due Date: " + dueDate + "\n" +
                    "Invoice Total: " + "£" + invoiceTotal, caption, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                string message = "Do you wish to create another invoice?";
                caption = "Create Another Invoice?";
                DialogResult dialogResult = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    txt_vatOrSalesTax.Text = "";
                    clearDataGrid(); // Empty data grid so user can enter new line items
                    txt_lineItemDescription.Focus(); // Put mouse cursor in the line item description text box
                    btn_Generate.Hide(); // Hide generation button so user can't generate invoice without entering line items
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close(); // Close the invoice generation screen
                }
                else
                {
                    this.Close();
                }
            }
            else // If check is not passed, do below...
            {
                showVATErrorMsg(validationResult); // Show error message
            }
        }

        private void btn_addLineItem_Click(object sender, EventArgs e)
        {
            ValidationUI validationUI = new ValidationUI();          // ValidationUI methods will return the boolean values for the variables, this determines if they are actually valid or not
            ValidationBLogic validationBLogic = new ValidationBLogic();  // ValidationBLogic methods will return the error messages for the variables

            var viewModel = new LineItemViewModel()
            {
                Description = txt_lineItemDescription.Text,
                CostPer = txt_lineItemCost.Text,
                Quantity = txt_lineItemQuantity.Text,
            };

            bool[] validLineItemDetails = validationUI.validateLineItemDetails(txt_lineItemDescription.Text, txt_lineItemCost.Text, txt_lineItemQuantity.Text, out index);     // Check for white space or null values for all inputs
            LineItemViewModelValidationResult validationResult = validationBLogic.validateLineItemDetails(viewModel); // Obtain error messages for all the inputs

            if (validationResult.IsValid()) // If all checks are passed, do below
            {
                showLineItemDetailsErrorMsgs(validationResult); // Make text boxes white again as they are valid

                bool validLineItemCost = validationUI.checkCost(txt_lineItemCost.Text, out index);
                LineItemViewModelValidationResult validationResultCheckCost = validationBLogic.checkCost(viewModel);

                if (validationResultCheckCost.IsValidCost()) // If cost is valid, do below...
                {
                    showLineItemCostErrorMsg(validationResultCheckCost); // Make text box white again as input is valid

                    bool validLineItemQuantity = validationUI.checkQuantity(txt_lineItemQuantity.Text, out index);
                    LineItemViewModelValidationResult validationResultCheckQuantity = validationBLogic.checkQuantity(viewModel);

                    if (validationResultCheckQuantity.IsValidQuantity()) // If quantity is valid, add line items to datagrid
                    {
                        showLineItemQuantityErrorMsg(validationResultCheckQuantity); // Make text box white again as input is valid

                        double lineItemTotal = double.Parse(txt_lineItemCost.Text) * int.Parse(txt_lineItemQuantity.Text);
                        lineItemTotal = Math.Round(lineItemTotal, 2);

                        addRow(txt_lineItemDescription.Text, txt_lineItemCost.Text, txt_lineItemQuantity.Text, lineItemTotal); // Add line items to datagrid
                        // Clear line item text boxes so user can enter another line item if they want
                        clearTextBoxes();
                        btn_Generate.Show(); // Show generate button as user has successfully generated a line item
                    }
                    else // If quantity is not valid, do below...
                    {
                        showLineItemQuantityErrorMsg(validationResultCheckQuantity); // Show error message
                    }
                }
                else // If cost is not valid, do below...
                {
                    showLineItemCostErrorMsg(validationResultCheckCost); // Show error message
                }
            }
            else // If any checks are failed, show error messages
            {
                showLineItemDetailsErrorMsgs(validationResult); // Show error messages
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

        #region Miscellaneous
        private void fillComboBox()
        {
            var listOfClients = new List<ClientNameViewModel>()
            {
                new ClientNameViewModel
                {
                    ClientName = DEFAULT_SELECT_STRING,
                    Id = Guid.NewGuid(),
                }
            };

            var listFromDb = _clientService.GetClientNames();

            listOfClients.AddRange(listFromDb);

            combox_clientNames.DataSource = listOfClients;
            combox_clientNames.DisplayMember = nameof(ClientNameViewModel.ClientName);
            combox_clientNames.ValueMember = nameof(ClientNameViewModel.Id);
            pnl_invoiceGenerationDetails.Hide();
        }

        private void equalColumnWidths()
        {
            // Make all the columns of the datagrid the same size
            dtaGridLineItems.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtaGridLineItems.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtaGridLineItems.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtaGridLineItems.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void addRow(string lineItemDescription, string lineItemCost, string lineItemQuantity, double lineItemTotal)
        {
            // Add line item details to the datagrid
            String[] row = { lineItemDescription, lineItemCost, lineItemQuantity, lineItemTotal.ToString() };
            dtaGridLineItems.Rows.Add(row);
        }

        private void clearDataGrid()
        {
            //dtaGridLineItems.DataSource = null; // Useful in data binding scenarios
            // OR
            dtaGridLineItems.Rows.Clear(); // Useful when data grid is populated manually
            dtaGridLineItems.Refresh();
        }

        private void clearTextBoxes()
        {
            // Reset all the textboxes
            txt_lineItemDescription.Text = String.Empty;
            txt_lineItemCost.Text = String.Empty;
            txt_lineItemQuantity.Text = String.Empty;
            txt_lineItemDescription.Focus(); // Put the mouse cursor in the first text box
        }

        private void combox_clientNames_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedClientViewModel = (ClientNameViewModel)combox_clientNames.SelectedItem;
            if (string.Equals(DEFAULT_SELECT_STRING, selectedClientViewModel.ClientName, StringComparison.OrdinalIgnoreCase))
            {
                pnl_invoiceGenerationDetails.Hide();
                // Drop out here, as the user has selected the default item in the list
                // OR we're still populating the list
                // (the SelectedValueChanged and SelectedIndexChanged events fire when the
                // first item is added to the list
                return;
            }

            // Show generation details panel as user has selected a client
            pnl_invoiceGenerationDetails.Show();
            // Hide generate button so user cant generate an invoice without entering line items
            btn_Generate.Hide();

            var clientName = selectedClientViewModel.ClientName;
            var todayAsString = DateTime.Today.ToString("dd-MM-yyyy");
            txt_invoiceRef.Text = $"RJJ-{clientName}-{todayAsString}"; // Create invoice reference

            // Change text box size based on invoice reference length
            Size textBoxSize = TextRenderer.MeasureText(txt_invoiceRef.Text, txt_invoiceRef.Font);
            txt_invoiceRef.Width = textBoxSize.Width;
            txt_invoiceRef.Height = textBoxSize.Height;

            // You should be able to use selectedClientViewModel to do all the things you need

        }
        #endregion

        #region ErrorMessages
        private void showLineItemDetailsErrorMsgs(LineItemViewModelValidationResult validLineItemDetailsErrorMsgs)
        {
            string message;
            string caption;

            if (validLineItemDetailsErrorMsgs.IsValid())
            {
                txt_lineItemDescription.BackColor = Color.White;
                txt_lineItemCost.BackColor = Color.White;
                txt_lineItemQuantity.BackColor = Color.White;
                return;
            }

            if (!validLineItemDetailsErrorMsgs.LineItemDescriptionIsValid())
            {
                txt_lineItemDescription.BackColor = Color.FromArgb(0xFF, 0xFF, 0xCA, 0xCA); // Set colour of line item description text box to visibly show error
                txt_lineItemDescription.Focus();        // Put mouse cursor in to the line item description text box
                message = validLineItemDetailsErrorMsgs.LineItemDescriptionValidationMessage;
                caption = "Line Item Description Error!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Display error message box to user
            }
            else if (validLineItemDetailsErrorMsgs.LineItemDescriptionIsValid())
            {
                txt_lineItemDescription.BackColor = Color.White;
            }
            if (!validLineItemDetailsErrorMsgs.LineItemCostIsValid())
            {
                txt_lineItemCost.BackColor = Color.FromArgb(0xFF, 0xFF, 0xCA, 0xCA);
                txt_lineItemCost.Focus();
                message = validLineItemDetailsErrorMsgs.LineItemCostValidationMessage;
                caption = "Line Item Cost Error!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (validLineItemDetailsErrorMsgs.LineItemCostIsValid())
            {
                txt_lineItemCost.BackColor = Color.White;
            }
            if (!validLineItemDetailsErrorMsgs.LineItemQuantityIsValid())
            {
                txt_lineItemQuantity.BackColor = Color.FromArgb(0xFF, 0xFF, 0xCA, 0xCA);
                txt_lineItemQuantity.Focus();
                message = validLineItemDetailsErrorMsgs.LineItemQuantityValidationMessage;
                caption = "Line Item Quantity Error!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (validLineItemDetailsErrorMsgs.LineItemQuantityIsValid())
            {
                txt_lineItemQuantity.BackColor = Color.White;
            }
        }

        private void showLineItemCostErrorMsg(LineItemViewModelValidationResult validLineItemCostErrorMsg)
        {
            string message;
            string caption;

            if (validLineItemCostErrorMsg.IsValidCost())
            {
                txt_lineItemCost.BackColor = Color.White;
                return;
            }

            if (!validLineItemCostErrorMsg.LineItemCheckCostIsValid())
            {
                txt_lineItemCost.BackColor = Color.FromArgb(0xFF, 0xFF, 0xCA, 0xCA);
                txt_lineItemCost.Focus();
                message = validLineItemCostErrorMsg.LineItemCheckCostValidationMessage;
                caption = "Line Item Cost Error!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (validLineItemCostErrorMsg.LineItemCheckCostIsValid())
            {
                txt_lineItemCost.BackColor = Color.White;
            }
        }

        private void showLineItemQuantityErrorMsg(LineItemViewModelValidationResult validLineItemQuantityErrorMsg)
        {
            string message;
            string caption;

            if (validLineItemQuantityErrorMsg.IsValidQuantity())
            {
                txt_lineItemQuantity.BackColor = Color.White;
                return;
            }

            if (!validLineItemQuantityErrorMsg.LineItemCheckQuantityIsValid())
            {
                txt_lineItemQuantity.BackColor = Color.FromArgb(0xFF, 0xFF, 0xCA, 0xCA);
                txt_lineItemQuantity.Focus();
                message = validLineItemQuantityErrorMsg.LineItemCheckQuantityValidationMessage;
                caption = "Line Item Quantity Error!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (validLineItemQuantityErrorMsg.LineItemCheckQuantityIsValid())
            {
                txt_lineItemQuantity.BackColor = Color.White;
            }
        }

        private void showVATErrorMsg(InvoiceViewModelValidationResult validVATErrorMsg)
        {
            string message;
            string caption;

            if (validVATErrorMsg.IsValidVAT())
            {
                txt_vatOrSalesTax.BackColor = Color.White;
                return;
            }

            if (!validVATErrorMsg.VATIsValid())
            {
                txt_vatOrSalesTax.BackColor = Color.FromArgb(0xFF, 0xFF, 0xCA, 0xCA);
                txt_vatOrSalesTax.Focus();
                message = validVATErrorMsg.VATValidationMessage;
                caption = "VAT/Salex Tax Error!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (validVATErrorMsg.VATIsValid())
            {
                txt_vatOrSalesTax.BackColor = Color.White;
            }
        }
        #endregion

    }
}