﻿namespace InvoiceGenerator
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
            this.btn_Exit.Location = new System.Drawing.Point(1000, 583);
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
            this.btn_Back.Location = new System.Drawing.Point(982, 111);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(174, 118);
            this.btn_Back.TabIndex = 19;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // InvoiceGenerationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 758);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lbl_welcomeToTheInvoiceGenerationScreen);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "InvoiceGenerationScreen";
            this.Text = "InvoiceGeneration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcomeToTheInvoiceGenerationScreen;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Back;
    }
}