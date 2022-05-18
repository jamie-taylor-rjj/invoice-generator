using InvoiceGenerator.Models;
using System.Net.Mail;
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
        public ClientDetailsEntryScreen()
        {
            InitializeComponent();
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
            using (var context = new InvoiceDBContext())    // using statement is discarded once the squiggly brackets have been passed, saves memory
            {
                context.Database.EnsureCreated();   // Ensures database is created

                bool validUserDetails = validateUserDetails();
                bool validEmailFormat = validateEmailFormatting();

                if (validUserDetails && validEmailFormat)
                {
                    var client = new Client     // Acts as an intialiser
                    {
                        ClientName = txt_clientName.Text,
                        ClientAddress = txt_clientAddress.Text,
                        ContactName = txt_contactName.Text,
                        ContactEmail = txt_contactEmail.Text,
                    };

                    context.Clients.Add(client);    // Add the client details

                    context.SaveChanges();  // Save it

                    MessageBox.Show("Saved!");
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();   // Closes the current form 'ClientDetailsEntryScreen'
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            using (var context = new InvoiceDBContext())    // Using statement is discarded once the squishy brackets have been passed, saves memory
            {
                context.Database.EnsureCreated();   // Ensures database is created

                var clients = context.Clients.ToList(); // Assign a bunch of client objects to a list

                var viewModels = new List<ClientViewModel>();
                foreach (var db in clients)
                {
                    viewModels.Add(ClientViewModel.FromDbModel(db));    // Add the client details to a list
                }
                dtaGridDetails.DataSource = viewModels; // Show all the client details on a datagrid
                //dtaGridDetails.DataSource = context.Clients.ToList();
                //context.SaveChanges();

                MessageBox.Show("Viewed!");
            }
        }

        private void btn_Exit2_Click(object sender, EventArgs e)
        {
            this.Close();   // Closes the current form 'ClientDetailsEntryScreen'
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            // Create an instance of a new form 'NewStartScreen'
            StartScreen NewStartScreen = new StartScreen();
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
        }

        #region Validation
        private bool validateUserDetails()
        {
            bool clientNameOk, clientAddressOk, contactNameOk, contactEmailOk;
            clientNameOk = clientAddressOk = contactNameOk = contactEmailOk = true;   // Set all values to 'true'

            if (String.IsNullOrWhiteSpace(txt_clientName.Text))
            {
                txt_clientName.BackColor = Color.FromArgb(0xFF, 0xFF, 0xCA, 0xCA);  // Set colour of text box to red
                txt_clientName.Focus(); // Put mouse cursor in the text box
                clientNameOk = false;   // Set to false as it was invalid
                string message = "Client Name must not be empty!";
                string caption = "Error!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);    // Informative error message displayed to user
            }
            if (String.IsNullOrWhiteSpace(txt_clientAddress.Text))
            {
                txt_clientAddress.BackColor = Color.FromArgb(0xFF, 0xFF, 0xCA, 0xCA);
                txt_clientAddress.Focus();
                clientAddressOk = false;
                string message = "Client Address must not be empty!";
                string caption = "Error!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (String.IsNullOrWhiteSpace(txt_contactName.Text))
            {
                txt_contactName.BackColor = Color.FromArgb(0xFF, 0xFF, 0xCA, 0xCA);
                txt_contactName.Focus();
                contactNameOk = false;
                string message = "Contact Name should not be empty!";
                string caption = "Error!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (String.IsNullOrWhiteSpace(txt_contactEmail.Text))
            {
                txt_contactEmail.BackColor = Color.FromArgb(0xFF, 0xFF, 0xCA, 0xCA);
                txt_contactEmail.Focus();
                contactEmailOk = false;
                string message = "Contact Email should not be empty!";
                string caption = "Error!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (clientNameOk == false || clientAddressOk == false || contactNameOk == false || contactEmailOk == false) // If any checks are failed, return false 
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validateEmailFormatting()
        {
            bool emailValid = false;
            try
            {
                MailAddress isValidEmail = new MailAddress(txt_contactEmail.Text);
                emailValid = true;
            }
            catch (FormatException)
            {
                txt_contactEmail.BackColor = Color.FromArgb(0xFF, 0xFF, 0xCA, 0xCA); // Set the colour of the text box to red
                txt_contactEmail.Focus();   // Put the mouse cursor in the text box
                emailValid = false;
                string message = "Contact Email must be formatted correctly!";
                string caption = "Error!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);    // Informative error message displayed to user
            }
            return emailValid;
        }
        #endregion

    }
}
