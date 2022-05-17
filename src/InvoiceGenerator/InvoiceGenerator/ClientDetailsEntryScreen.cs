using InvoiceGenerator.Models;
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
        private void btn_Create_Click(object sender, EventArgs e)
        {
            using (var context = new InvoiceDBContext())    // using statement is discarded once the squiggly brackets have been passed, saves memory
            {
                context.Database.EnsureCreated();   // Ensures database is created

                var client = new Client     // Acts as an intialiser
                {
                    ClientName = "Adam",
                    ClientAddress = "Gardens",
                    ContactName = "Bob",
                    ContactEmail = "bob@gmail.com",
                };

                context.Clients.Add(client);    // Add the client details
                context.SaveChanges();  // Save it

                MessageBox.Show("Saved!");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();   // Closes the current form 'ClientDetailsEntryScreen'
        }
        #endregion

    }
}
