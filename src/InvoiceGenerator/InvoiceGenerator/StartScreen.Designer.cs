namespace InvoiceGenerator
{
    partial class StartScreen
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
            this.lbl_pleaseSelect = new System.Windows.Forms.Label();
            this.btn_generateInvoice = new System.Windows.Forms.Button();
            this.btn_enterClientDetails = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_welcomeToTheStartScreen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_pleaseSelect
            // 
            this.lbl_pleaseSelect.AutoSize = true;
            this.lbl_pleaseSelect.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_pleaseSelect.Location = new System.Drawing.Point(415, 243);
            this.lbl_pleaseSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pleaseSelect.Name = "lbl_pleaseSelect";
            this.lbl_pleaseSelect.Size = new System.Drawing.Size(326, 41);
            this.lbl_pleaseSelect.TabIndex = 0;
            this.lbl_pleaseSelect.Text = "Please Select:";
            // 
            // btn_generateInvoice
            // 
            this.btn_generateInvoice.BackColor = System.Drawing.Color.LightGray;
            this.btn_generateInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_generateInvoice.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_generateInvoice.Location = new System.Drawing.Point(370, 332);
            this.btn_generateInvoice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_generateInvoice.Name = "btn_generateInvoice";
            this.btn_generateInvoice.Size = new System.Drawing.Size(174, 118);
            this.btn_generateInvoice.TabIndex = 1;
            this.btn_generateInvoice.Text = "Generate Invoice";
            this.btn_generateInvoice.UseVisualStyleBackColor = false;
            this.btn_generateInvoice.Click += new System.EventHandler(this.btn_generateInvoice_Click);
            // 
            // btn_enterClientDetails
            // 
            this.btn_enterClientDetails.BackColor = System.Drawing.Color.Silver;
            this.btn_enterClientDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_enterClientDetails.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_enterClientDetails.Location = new System.Drawing.Point(670, 332);
            this.btn_enterClientDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_enterClientDetails.Name = "btn_enterClientDetails";
            this.btn_enterClientDetails.Size = new System.Drawing.Size(174, 118);
            this.btn_enterClientDetails.TabIndex = 2;
            this.btn_enterClientDetails.Text = "Enter Client Details";
            this.btn_enterClientDetails.UseVisualStyleBackColor = false;
            this.btn_enterClientDetails.Click += new System.EventHandler(this.btn_enterClientDetails_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Exit.Location = new System.Drawing.Point(1000, 583);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(174, 118);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_welcomeToTheStartScreen
            // 
            this.lbl_welcomeToTheStartScreen.AutoSize = true;
            this.lbl_welcomeToTheStartScreen.Font = new System.Drawing.Font("Courier New", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_welcomeToTheStartScreen.Location = new System.Drawing.Point(198, 120);
            this.lbl_welcomeToTheStartScreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_welcomeToTheStartScreen.Name = "lbl_welcomeToTheStartScreen";
            this.lbl_welcomeToTheStartScreen.Size = new System.Drawing.Size(750, 49);
            this.lbl_welcomeToTheStartScreen.TabIndex = 4;
            this.lbl_welcomeToTheStartScreen.Text = "Welcome to the Start Screen!";
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 758);
            this.Controls.Add(this.lbl_welcomeToTheStartScreen);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_enterClientDetails);
            this.Controls.Add(this.btn_generateInvoice);
            this.Controls.Add(this.lbl_pleaseSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "StartScreen";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pleaseSelect;
        private System.Windows.Forms.Button btn_generateInvoice;
        private System.Windows.Forms.Button btn_enterClientDetails;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_welcomeToTheStartScreen;
    }
}

