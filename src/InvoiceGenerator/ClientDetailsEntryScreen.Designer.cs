namespace InvoiceGenerator
{
    partial class ClientDetailsEntryScreen
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_welcomeToTheClientDetailEntryScreen = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_enterDetails = new System.Windows.Forms.Button();
            this.btn_viewDetails = new System.Windows.Forms.Button();
            this.pnl_enterDetails = new System.Windows.Forms.Panel();
            this.txt_contactEmail = new System.Windows.Forms.TextBox();
            this.lbl_contactEmail = new System.Windows.Forms.Label();
            this.txt_contactName = new System.Windows.Forms.TextBox();
            this.lbl_contactName = new System.Windows.Forms.Label();
            this.txt_clientAddress = new System.Windows.Forms.TextBox();
            this.lbl_clientAddress = new System.Windows.Forms.Label();
            this.txt_clientName = new System.Windows.Forms.TextBox();
            this.lbl_clientName = new System.Windows.Forms.Label();
            this.pnl_viewDetails = new System.Windows.Forms.Panel();
            this.lbl_pageNo = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_View = new System.Windows.Forms.Button();
            this.dtaGridDetails = new System.Windows.Forms.DataGridView();
            this.btn_Exit2 = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.pnl_enterDetails.SuspendLayout();
            this.pnl_viewDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Exit.Location = new System.Drawing.Point(641, 361);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(174, 118);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_welcomeToTheClientDetailEntryScreen
            // 
            this.lbl_welcomeToTheClientDetailEntryScreen.AutoSize = true;
            this.lbl_welcomeToTheClientDetailEntryScreen.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_welcomeToTheClientDetailEntryScreen.Location = new System.Drawing.Point(210, 36);
            this.lbl_welcomeToTheClientDetailEntryScreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_welcomeToTheClientDetailEntryScreen.Name = "lbl_welcomeToTheClientDetailEntryScreen";
            this.lbl_welcomeToTheClientDetailEntryScreen.Size = new System.Drawing.Size(813, 36);
            this.lbl_welcomeToTheClientDetailEntryScreen.TabIndex = 8;
            this.lbl_welcomeToTheClientDetailEntryScreen.Text = "Welcome to the Client Detail Entry Screen!";
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.LightGray;
            this.btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Create.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Create.Location = new System.Drawing.Point(448, 361);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(174, 118);
            this.btn_Create.TabIndex = 9;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_enterDetails
            // 
            this.btn_enterDetails.BackColor = System.Drawing.Color.LightGray;
            this.btn_enterDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_enterDetails.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_enterDetails.Location = new System.Drawing.Point(41, 92);
            this.btn_enterDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_enterDetails.Name = "btn_enterDetails";
            this.btn_enterDetails.Size = new System.Drawing.Size(174, 118);
            this.btn_enterDetails.TabIndex = 10;
            this.btn_enterDetails.Text = "Enter Details";
            this.btn_enterDetails.UseVisualStyleBackColor = false;
            this.btn_enterDetails.Click += new System.EventHandler(this.btn_enterDetails_Click);
            // 
            // btn_viewDetails
            // 
            this.btn_viewDetails.BackColor = System.Drawing.Color.LightGray;
            this.btn_viewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_viewDetails.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_viewDetails.Location = new System.Drawing.Point(254, 92);
            this.btn_viewDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_viewDetails.Name = "btn_viewDetails";
            this.btn_viewDetails.Size = new System.Drawing.Size(174, 118);
            this.btn_viewDetails.TabIndex = 11;
            this.btn_viewDetails.Text = "View Details";
            this.btn_viewDetails.UseVisualStyleBackColor = false;
            this.btn_viewDetails.Click += new System.EventHandler(this.btn_viewDetails_Click);
            // 
            // pnl_enterDetails
            // 
            this.pnl_enterDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_enterDetails.Controls.Add(this.txt_contactEmail);
            this.pnl_enterDetails.Controls.Add(this.lbl_contactEmail);
            this.pnl_enterDetails.Controls.Add(this.txt_contactName);
            this.pnl_enterDetails.Controls.Add(this.lbl_contactName);
            this.pnl_enterDetails.Controls.Add(this.txt_clientAddress);
            this.pnl_enterDetails.Controls.Add(this.lbl_clientAddress);
            this.pnl_enterDetails.Controls.Add(this.txt_clientName);
            this.pnl_enterDetails.Controls.Add(this.lbl_clientName);
            this.pnl_enterDetails.Controls.Add(this.btn_Create);
            this.pnl_enterDetails.Controls.Add(this.btn_Exit);
            this.pnl_enterDetails.Location = new System.Drawing.Point(41, 230);
            this.pnl_enterDetails.Name = "pnl_enterDetails";
            this.pnl_enterDetails.Size = new System.Drawing.Size(828, 497);
            this.pnl_enterDetails.TabIndex = 12;
            // 
            // txt_contactEmail
            // 
            this.txt_contactEmail.BackColor = System.Drawing.Color.White;
            this.txt_contactEmail.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_contactEmail.Location = new System.Drawing.Point(49, 267);
            this.txt_contactEmail.Name = "txt_contactEmail";
            this.txt_contactEmail.Size = new System.Drawing.Size(272, 29);
            this.txt_contactEmail.TabIndex = 17;
            // 
            // lbl_contactEmail
            // 
            this.lbl_contactEmail.AutoSize = true;
            this.lbl_contactEmail.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_contactEmail.Location = new System.Drawing.Point(49, 241);
            this.lbl_contactEmail.Name = "lbl_contactEmail";
            this.lbl_contactEmail.Size = new System.Drawing.Size(179, 23);
            this.lbl_contactEmail.TabIndex = 16;
            this.lbl_contactEmail.Text = "Contact Email";
            // 
            // txt_contactName
            // 
            this.txt_contactName.BackColor = System.Drawing.Color.White;
            this.txt_contactName.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_contactName.Location = new System.Drawing.Point(49, 198);
            this.txt_contactName.Name = "txt_contactName";
            this.txt_contactName.Size = new System.Drawing.Size(272, 29);
            this.txt_contactName.TabIndex = 15;
            // 
            // lbl_contactName
            // 
            this.lbl_contactName.AutoSize = true;
            this.lbl_contactName.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_contactName.Location = new System.Drawing.Point(49, 172);
            this.lbl_contactName.Name = "lbl_contactName";
            this.lbl_contactName.Size = new System.Drawing.Size(166, 23);
            this.lbl_contactName.TabIndex = 14;
            this.lbl_contactName.Text = "Contact Name";
            // 
            // txt_clientAddress
            // 
            this.txt_clientAddress.BackColor = System.Drawing.Color.White;
            this.txt_clientAddress.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_clientAddress.Location = new System.Drawing.Point(49, 127);
            this.txt_clientAddress.Name = "txt_clientAddress";
            this.txt_clientAddress.Size = new System.Drawing.Size(272, 29);
            this.txt_clientAddress.TabIndex = 13;
            // 
            // lbl_clientAddress
            // 
            this.lbl_clientAddress.AutoSize = true;
            this.lbl_clientAddress.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_clientAddress.Location = new System.Drawing.Point(49, 101);
            this.lbl_clientAddress.Name = "lbl_clientAddress";
            this.lbl_clientAddress.Size = new System.Drawing.Size(192, 23);
            this.lbl_clientAddress.TabIndex = 12;
            this.lbl_clientAddress.Text = "Client Address";
            // 
            // txt_clientName
            // 
            this.txt_clientName.BackColor = System.Drawing.Color.White;
            this.txt_clientName.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_clientName.Location = new System.Drawing.Point(49, 60);
            this.txt_clientName.Name = "txt_clientName";
            this.txt_clientName.Size = new System.Drawing.Size(272, 29);
            this.txt_clientName.TabIndex = 11;
            // 
            // lbl_clientName
            // 
            this.lbl_clientName.AutoSize = true;
            this.lbl_clientName.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_clientName.Location = new System.Drawing.Point(49, 34);
            this.lbl_clientName.Name = "lbl_clientName";
            this.lbl_clientName.Size = new System.Drawing.Size(153, 23);
            this.lbl_clientName.TabIndex = 10;
            this.lbl_clientName.Text = "Client Name";
            // 
            // pnl_viewDetails
            // 
            this.pnl_viewDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_viewDetails.Controls.Add(this.lbl_pageNo);
            this.pnl_viewDetails.Controls.Add(this.btn_Next);
            this.pnl_viewDetails.Controls.Add(this.btn_Previous);
            this.pnl_viewDetails.Controls.Add(this.btn_View);
            this.pnl_viewDetails.Controls.Add(this.dtaGridDetails);
            this.pnl_viewDetails.Controls.Add(this.btn_Exit2);
            this.pnl_viewDetails.Location = new System.Drawing.Point(41, 230);
            this.pnl_viewDetails.Name = "pnl_viewDetails";
            this.pnl_viewDetails.Size = new System.Drawing.Size(828, 497);
            this.pnl_viewDetails.TabIndex = 13;
            // 
            // lbl_pageNo
            // 
            this.lbl_pageNo.AutoSize = true;
            this.lbl_pageNo.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_pageNo.Location = new System.Drawing.Point(194, 367);
            this.lbl_pageNo.Name = "lbl_pageNo";
            this.lbl_pageNo.Size = new System.Drawing.Size(87, 21);
            this.lbl_pageNo.TabIndex = 21;
            this.lbl_pageNo.Text = "PageNo.";
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.LightGray;
            this.btn_Next.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Next.Location = new System.Drawing.Point(311, 361);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 32);
            this.btn_Next.TabIndex = 20;
            this.btn_Next.Text = ">";
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.BackColor = System.Drawing.Color.LightGray;
            this.btn_Previous.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Previous.Location = new System.Drawing.Point(113, 361);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(75, 32);
            this.btn_Previous.TabIndex = 19;
            this.btn_Previous.Text = "<";
            this.btn_Previous.UseVisualStyleBackColor = false;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_View
            // 
            this.btn_View.BackColor = System.Drawing.Color.LightGray;
            this.btn_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_View.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_View.Location = new System.Drawing.Point(443, 361);
            this.btn_View.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(174, 118);
            this.btn_View.TabIndex = 18;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = false;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // dtaGridDetails
            // 
            this.dtaGridDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridDetails.Location = new System.Drawing.Point(37, 34);
            this.dtaGridDetails.Name = "dtaGridDetails";
            this.dtaGridDetails.RowTemplate.Height = 25;
            this.dtaGridDetails.Size = new System.Drawing.Size(560, 310);
            this.dtaGridDetails.TabIndex = 8;
            // 
            // btn_Exit2
            // 
            this.btn_Exit2.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Exit2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Exit2.Location = new System.Drawing.Point(641, 361);
            this.btn_Exit2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Exit2.Name = "btn_Exit2";
            this.btn_Exit2.Size = new System.Drawing.Size(174, 118);
            this.btn_Exit2.TabIndex = 7;
            this.btn_Exit2.Text = "Exit";
            this.btn_Exit2.UseVisualStyleBackColor = false;
            this.btn_Exit2.Click += new System.EventHandler(this.btn_Exit2_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.LightGray;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Back.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Back.Location = new System.Drawing.Point(978, 92);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(174, 118);
            this.btn_Back.TabIndex = 18;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // ClientDetailsEntryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 758);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.pnl_viewDetails);
            this.Controls.Add(this.pnl_enterDetails);
            this.Controls.Add(this.btn_viewDetails);
            this.Controls.Add(this.btn_enterDetails);
            this.Controls.Add(this.lbl_welcomeToTheClientDetailEntryScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ClientDetailsEntryScreen";
            this.Text = "ClientDetailsEntry";
            this.Load += new System.EventHandler(this.onFormLoad);
            this.pnl_enterDetails.ResumeLayout(false);
            this.pnl_enterDetails.PerformLayout();
            this.pnl_viewDetails.ResumeLayout(false);
            this.pnl_viewDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_welcomeToTheClientDetailEntryScreen;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_enterDetails;
        private System.Windows.Forms.Button btn_viewDetails;
        private System.Windows.Forms.Panel pnl_enterDetails;
        private System.Windows.Forms.TextBox txt_contactEmail;
        private System.Windows.Forms.Label lbl_contactEmail;
        private System.Windows.Forms.TextBox txt_contactName;
        private System.Windows.Forms.Label lbl_contactName;
        private System.Windows.Forms.TextBox txt_clientAddress;
        private System.Windows.Forms.Label lbl_clientAddress;
        private System.Windows.Forms.TextBox txt_clientName;
        private System.Windows.Forms.Label lbl_clientName;
        private System.Windows.Forms.Panel pnl_viewDetails;
        private System.Windows.Forms.DataGridView dtaGridDetails;
        private System.Windows.Forms.Button btn_Exit2;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Label lbl_pageNo;
    }
}