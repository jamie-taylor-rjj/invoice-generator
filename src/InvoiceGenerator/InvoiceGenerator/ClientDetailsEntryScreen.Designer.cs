﻿namespace InvoiceGenerator
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
            this.lbl_welcomeToTheInvoiceGenerationScreen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(857, 505);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(149, 102);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_welcomeToTheInvoiceGenerationScreen
            // 
            this.lbl_welcomeToTheInvoiceGenerationScreen.AutoSize = true;
            this.lbl_welcomeToTheInvoiceGenerationScreen.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcomeToTheInvoiceGenerationScreen.Location = new System.Drawing.Point(98, 79);
            this.lbl_welcomeToTheInvoiceGenerationScreen.Name = "lbl_welcomeToTheInvoiceGenerationScreen";
            this.lbl_welcomeToTheInvoiceGenerationScreen.Size = new System.Drawing.Size(908, 36);
            this.lbl_welcomeToTheInvoiceGenerationScreen.TabIndex = 8;
            this.lbl_welcomeToTheInvoiceGenerationScreen.Text = "Welcome to the Client Detail Generation Screen!";
            // 
            // ClientDetailsEntryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 657);
            this.Controls.Add(this.lbl_welcomeToTheInvoiceGenerationScreen);
            this.Controls.Add(this.btn_Exit);
            this.Name = "ClientDetailsEntryScreen";
            this.Text = "ClientDetailsEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_welcomeToTheInvoiceGenerationScreen;
    }
}