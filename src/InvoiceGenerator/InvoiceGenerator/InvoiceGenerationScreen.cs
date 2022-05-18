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
    public partial class InvoiceGenerationScreen : Form
    {
        public InvoiceGenerationScreen()
        {
            InitializeComponent();
        }

        #region ButtonClicks
        private void btn_Back_Click(object sender, EventArgs e)
        {
            // Create an instance of a new form 'NewStartScreen'
            StartScreen NewStartScreen = new StartScreen();
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

    }
}
