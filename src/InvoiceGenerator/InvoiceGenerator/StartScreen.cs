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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        #region ButtonClicks
        private void btn_generateInvoice_Click(object sender, EventArgs e)
        {
            // Create an instance of a new form 'NewInvoiceGenerationScreen'
            InvoiceGenerationScreen NewInvoiceGenerationScreen = new InvoiceGenerationScreen();
            // Hides the current form 'StartScreen'
            this.Hide();
            // When the 'NewInvoiceGenerationScreen' is closed, close the current form 'StartScreen'
            NewInvoiceGenerationScreen.FormClosed += (s, args) => this.Close();
            // Show the 'NewInvoiceGenerationScreen' to the screen
            NewInvoiceGenerationScreen.Show();
            // Opens the 'NewInvoiceGenerationScreen' in the same location as where the 'StartScreen' was closed
            NewInvoiceGenerationScreen.Location = this.Location;
        }

        private void btn_enterClientDetails_Click(object sender, EventArgs e)
        {
            // Create an instance of a new form 'NewClientDetailsEntryScreen'
            ClientDetailsEntryScreen NewClientDetailsEntryScreen = new ClientDetailsEntryScreen();
            // Hides the current form 'Start Screen'
            this.Hide();
            // When the 'NewClientDetailsEntryScreen' is closed, close the current form 'StartScreen'
            NewClientDetailsEntryScreen.FormClosed += (s, args) => this.Close();
            // Show the NewClientDetailsEntryScreen to the screen
            NewClientDetailsEntryScreen.Show();
            // Opens the 'NewClientDetailsEntryScreen' in the same location as where the 'StartScreen' was closed
            NewClientDetailsEntryScreen.Location = this.Location;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the current form 'StartScreen'
        }
        #endregion

    }
}
