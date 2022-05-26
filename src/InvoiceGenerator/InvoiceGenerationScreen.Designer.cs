namespace InvoiceGenerator
{
    partial class InvoiceGenerationScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_welcomeToTheInvoiceGenerationScreen = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.pnl_invoiceGeneration = new System.Windows.Forms.Panel();
            this.pnl_invoiceGenerationDetails = new System.Windows.Forms.Panel();
            this.txt_vatOrSalesTax = new System.Windows.Forms.TextBox();
            this.lbl_vatOrSalesTax = new System.Windows.Forms.Label();
            this.btn_addLineItem = new System.Windows.Forms.Button();
            this.dtaGridLineItems = new System.Windows.Forms.DataGridView();
            this.col_invoiceReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_lineItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_lineItemCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_lineItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_lineItemTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_lineItemQuantity = new System.Windows.Forms.TextBox();
            this.txt_lineItemCost = new System.Windows.Forms.TextBox();
            this.txt_lineItemDescription = new System.Windows.Forms.TextBox();
            this.lbl_lineItemQuantity = new System.Windows.Forms.Label();
            this.lbl_lineItemCost = new System.Windows.Forms.Label();
            this.lbl_lineItemDescription = new System.Windows.Forms.Label();
            this.txt_invoiceRef = new System.Windows.Forms.TextBox();
            this.lbl_invoiceRef = new System.Windows.Forms.Label();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.lbl_clientName = new System.Windows.Forms.Label();
            this.combox_clientNames = new System.Windows.Forms.ComboBox();
            this.pnl_invoiceGeneration.SuspendLayout();
            this.pnl_invoiceGenerationDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridLineItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_welcomeToTheInvoiceGenerationScreen
            // 
            this.lbl_welcomeToTheInvoiceGenerationScreen.AutoSize = true;
            this.lbl_welcomeToTheInvoiceGenerationScreen.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_welcomeToTheInvoiceGenerationScreen.Location = new System.Drawing.Point(115, 68);
            this.lbl_welcomeToTheInvoiceGenerationScreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_welcomeToTheInvoiceGenerationScreen.Name = "lbl_welcomeToTheInvoiceGenerationScreen";
            this.lbl_welcomeToTheInvoiceGenerationScreen.Size = new System.Drawing.Size(878, 40);
            this.lbl_welcomeToTheInvoiceGenerationScreen.TabIndex = 5;
            this.lbl_welcomeToTheInvoiceGenerationScreen.Text = "Welcome to the Invoice Generation Screen!";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Exit.Location = new System.Drawing.Point(868, 325);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(174, 118);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.LightGray;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Back.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Back.Location = new System.Drawing.Point(903, 22);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(174, 118);
            this.btn_Back.TabIndex = 19;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // pnl_invoiceGeneration
            // 
            this.pnl_invoiceGeneration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_invoiceGeneration.Controls.Add(this.pnl_invoiceGenerationDetails);
            this.pnl_invoiceGeneration.Controls.Add(this.lbl_clientName);
            this.pnl_invoiceGeneration.Controls.Add(this.combox_clientNames);
            this.pnl_invoiceGeneration.Controls.Add(this.btn_Back);
            this.pnl_invoiceGeneration.Location = new System.Drawing.Point(58, 111);
            this.pnl_invoiceGeneration.Name = "pnl_invoiceGeneration";
            this.pnl_invoiceGeneration.Size = new System.Drawing.Size(1104, 609);
            this.pnl_invoiceGeneration.TabIndex = 20;
            // 
            // pnl_invoiceGenerationDetails
            // 
            this.pnl_invoiceGenerationDetails.Controls.Add(this.txt_vatOrSalesTax);
            this.pnl_invoiceGenerationDetails.Controls.Add(this.lbl_vatOrSalesTax);
            this.pnl_invoiceGenerationDetails.Controls.Add(this.btn_addLineItem);
            this.pnl_invoiceGenerationDetails.Controls.Add(this.dtaGridLineItems);
            this.pnl_invoiceGenerationDetails.Controls.Add(this.txt_lineItemQuantity);
            this.pnl_invoiceGenerationDetails.Controls.Add(this.txt_lineItemCost);
            this.pnl_invoiceGenerationDetails.Controls.Add(this.txt_lineItemDescription);
            this.pnl_invoiceGenerationDetails.Controls.Add(this.lbl_lineItemQuantity);
            this.pnl_invoiceGenerationDetails.Controls.Add(this.lbl_lineItemCost);
            this.pnl_invoiceGenerationDetails.Controls.Add(this.lbl_lineItemDescription);
            this.pnl_invoiceGenerationDetails.Controls.Add(this.txt_invoiceRef);
            this.pnl_invoiceGenerationDetails.Controls.Add(this.lbl_invoiceRef);
            this.pnl_invoiceGenerationDetails.Controls.Add(this.btn_Exit);
            this.pnl_invoiceGenerationDetails.Controls.Add(this.btn_Generate);
            this.pnl_invoiceGenerationDetails.Location = new System.Drawing.Point(35, 146);
            this.pnl_invoiceGenerationDetails.Name = "pnl_invoiceGenerationDetails";
            this.pnl_invoiceGenerationDetails.Size = new System.Drawing.Size(1052, 448);
            this.pnl_invoiceGenerationDetails.TabIndex = 23;
            // 
            // txt_vatOrSalesTax
            // 
            this.txt_vatOrSalesTax.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_vatOrSalesTax.Location = new System.Drawing.Point(297, 358);
            this.txt_vatOrSalesTax.Name = "txt_vatOrSalesTax";
            this.txt_vatOrSalesTax.Size = new System.Drawing.Size(218, 35);
            this.txt_vatOrSalesTax.TabIndex = 35;
            // 
            // lbl_vatOrSalesTax
            // 
            this.lbl_vatOrSalesTax.AutoSize = true;
            this.lbl_vatOrSalesTax.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_vatOrSalesTax.Location = new System.Drawing.Point(297, 325);
            this.lbl_vatOrSalesTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_vatOrSalesTax.Name = "lbl_vatOrSalesTax";
            this.lbl_vatOrSalesTax.Size = new System.Drawing.Size(301, 30);
            this.lbl_vatOrSalesTax.TabIndex = 34;
            this.lbl_vatOrSalesTax.Text = "VAT or Sales Tax%:";
            // 
            // btn_addLineItem
            // 
            this.btn_addLineItem.BackColor = System.Drawing.Color.LightGray;
            this.btn_addLineItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addLineItem.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_addLineItem.Location = new System.Drawing.Point(16, 325);
            this.btn_addLineItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_addLineItem.Name = "btn_addLineItem";
            this.btn_addLineItem.Size = new System.Drawing.Size(230, 83);
            this.btn_addLineItem.TabIndex = 33;
            this.btn_addLineItem.Text = "Add Line Item";
            this.btn_addLineItem.UseVisualStyleBackColor = false;
            this.btn_addLineItem.Click += new System.EventHandler(this.btn_addLineItem_Click);
            // 
            // dtaGridLineItems
            // 
            this.dtaGridLineItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridLineItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_invoiceReference,
            this.col_lineItemDescription,
            this.col_lineItemCost,
            this.col_lineItemQuantity,
            this.col_lineItemTotal});
            this.dtaGridLineItems.Location = new System.Drawing.Point(427, 19);
            this.dtaGridLineItems.Name = "dtaGridLineItems";
            this.dtaGridLineItems.RowTemplate.Height = 25;
            this.dtaGridLineItems.Size = new System.Drawing.Size(547, 265);
            this.dtaGridLineItems.TabIndex = 32;
            // 
            // col_invoiceReference
            // 
            this.col_invoiceReference.HeaderText = "Invoice Ref.";
            this.col_invoiceReference.Name = "col_invoiceReference";
            this.col_invoiceReference.ReadOnly = true;
            // 
            // col_lineItemDescription
            // 
            this.col_lineItemDescription.HeaderText = "Description";
            this.col_lineItemDescription.Name = "col_lineItemDescription";
            this.col_lineItemDescription.ReadOnly = true;
            // 
            // col_lineItemCost
            // 
            this.col_lineItemCost.HeaderText = "Cost";
            this.col_lineItemCost.Name = "col_lineItemCost";
            this.col_lineItemCost.ReadOnly = true;
            // 
            // col_lineItemQuantity
            // 
            this.col_lineItemQuantity.HeaderText = "Quantity";
            this.col_lineItemQuantity.Name = "col_lineItemQuantity";
            this.col_lineItemQuantity.ReadOnly = true;
            // 
            // col_lineItemTotal
            // 
            this.col_lineItemTotal.HeaderText = "Total";
            this.col_lineItemTotal.Name = "col_lineItemTotal";
            this.col_lineItemTotal.ReadOnly = true;
            // 
            // txt_lineItemQuantity
            // 
            this.txt_lineItemQuantity.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_lineItemQuantity.Location = new System.Drawing.Point(21, 282);
            this.txt_lineItemQuantity.Name = "txt_lineItemQuantity";
            this.txt_lineItemQuantity.Size = new System.Drawing.Size(218, 35);
            this.txt_lineItemQuantity.TabIndex = 31;
            // 
            // txt_lineItemCost
            // 
            this.txt_lineItemCost.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_lineItemCost.Location = new System.Drawing.Point(21, 207);
            this.txt_lineItemCost.Name = "txt_lineItemCost";
            this.txt_lineItemCost.Size = new System.Drawing.Size(218, 35);
            this.txt_lineItemCost.TabIndex = 30;
            // 
            // txt_lineItemDescription
            // 
            this.txt_lineItemDescription.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_lineItemDescription.Location = new System.Drawing.Point(21, 123);
            this.txt_lineItemDescription.Name = "txt_lineItemDescription";
            this.txt_lineItemDescription.Size = new System.Drawing.Size(218, 35);
            this.txt_lineItemDescription.TabIndex = 29;
            // 
            // lbl_lineItemQuantity
            // 
            this.lbl_lineItemQuantity.AutoSize = true;
            this.lbl_lineItemQuantity.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_lineItemQuantity.Location = new System.Drawing.Point(21, 249);
            this.lbl_lineItemQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lineItemQuantity.Name = "lbl_lineItemQuantity";
            this.lbl_lineItemQuantity.Size = new System.Drawing.Size(317, 30);
            this.lbl_lineItemQuantity.TabIndex = 28;
            this.lbl_lineItemQuantity.Text = "Line Item Quantity:";
            // 
            // lbl_lineItemCost
            // 
            this.lbl_lineItemCost.AutoSize = true;
            this.lbl_lineItemCost.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_lineItemCost.Location = new System.Drawing.Point(20, 167);
            this.lbl_lineItemCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lineItemCost.Name = "lbl_lineItemCost";
            this.lbl_lineItemCost.Size = new System.Drawing.Size(253, 30);
            this.lbl_lineItemCost.TabIndex = 27;
            this.lbl_lineItemCost.Text = "Line Item Cost:";
            // 
            // lbl_lineItemDescription
            // 
            this.lbl_lineItemDescription.AutoSize = true;
            this.lbl_lineItemDescription.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_lineItemDescription.Location = new System.Drawing.Point(21, 90);
            this.lbl_lineItemDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lineItemDescription.Name = "lbl_lineItemDescription";
            this.lbl_lineItemDescription.Size = new System.Drawing.Size(365, 30);
            this.lbl_lineItemDescription.TabIndex = 26;
            this.lbl_lineItemDescription.Text = "Line Item Description:";
            // 
            // txt_invoiceRef
            // 
            this.txt_invoiceRef.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_invoiceRef.Location = new System.Drawing.Point(21, 52);
            this.txt_invoiceRef.Name = "txt_invoiceRef";
            this.txt_invoiceRef.ReadOnly = true;
            this.txt_invoiceRef.Size = new System.Drawing.Size(317, 35);
            this.txt_invoiceRef.TabIndex = 25;
            // 
            // lbl_invoiceRef
            // 
            this.lbl_invoiceRef.AutoSize = true;
            this.lbl_invoiceRef.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_invoiceRef.Location = new System.Drawing.Point(21, 19);
            this.lbl_invoiceRef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_invoiceRef.Name = "lbl_invoiceRef";
            this.lbl_invoiceRef.Size = new System.Drawing.Size(205, 30);
            this.lbl_invoiceRef.TabIndex = 24;
            this.lbl_invoiceRef.Text = "Invoice Ref:";
            // 
            // btn_Generate
            // 
            this.btn_Generate.BackColor = System.Drawing.Color.LightGray;
            this.btn_Generate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Generate.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Generate.Location = new System.Drawing.Point(668, 325);
            this.btn_Generate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(174, 118);
            this.btn_Generate.TabIndex = 22;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = false;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // lbl_clientName
            // 
            this.lbl_clientName.AutoSize = true;
            this.lbl_clientName.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_clientName.Location = new System.Drawing.Point(35, 59);
            this.lbl_clientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_clientName.Name = "lbl_clientName";
            this.lbl_clientName.Size = new System.Drawing.Size(205, 30);
            this.lbl_clientName.TabIndex = 21;
            this.lbl_clientName.Text = "Client Name:";
            // 
            // combox_clientNames
            // 
            this.combox_clientNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_clientNames.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combox_clientNames.FormattingEnabled = true;
            this.combox_clientNames.Location = new System.Drawing.Point(35, 92);
            this.combox_clientNames.Name = "combox_clientNames";
            this.combox_clientNames.Size = new System.Drawing.Size(273, 31);
            this.combox_clientNames.TabIndex = 20;
            this.combox_clientNames.SelectedValueChanged += new System.EventHandler(this.combox_clientNames_SelectedValueChanged);
            // 
            // InvoiceGenerationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 758);
            this.Controls.Add(this.pnl_invoiceGeneration);
            this.Controls.Add(this.lbl_welcomeToTheInvoiceGenerationScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "InvoiceGenerationScreen";
            this.Text = "InvoiceGeneration";
            this.pnl_invoiceGeneration.ResumeLayout(false);
            this.pnl_invoiceGeneration.PerformLayout();
            this.pnl_invoiceGenerationDetails.ResumeLayout(false);
            this.pnl_invoiceGenerationDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridLineItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcomeToTheInvoiceGenerationScreen;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel pnl_invoiceGeneration;
        private System.Windows.Forms.ComboBox combox_clientNames;
        private System.Windows.Forms.Label lbl_clientName;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.Panel pnl_invoiceGenerationDetails;
        private System.Windows.Forms.DataGridView dtaGridLineItems;
        private System.Windows.Forms.TextBox txt_lineItemQuantity;
        private System.Windows.Forms.TextBox txt_lineItemCost;
        private System.Windows.Forms.TextBox txt_lineItemDescription;
        private System.Windows.Forms.Label lbl_lineItemQuantity;
        private System.Windows.Forms.Label lbl_lineItemCost;
        private System.Windows.Forms.Label lbl_lineItemDescription;
        private System.Windows.Forms.TextBox txt_invoiceRef;
        private System.Windows.Forms.Label lbl_invoiceRef;
        private System.Windows.Forms.TextBox txt_vatOrSalesTax;
        private System.Windows.Forms.Label lbl_vatOrSalesTax;
        private System.Windows.Forms.Button btn_addLineItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_invoiceReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_lineItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_lineItemCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_lineItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_lineItemTotal;
    }
}