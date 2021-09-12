namespace EZRentalWindowsFormsApp
{
    partial class frmCreditCardListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCreditCardList = new System.Windows.Forms.DataGridView();
            this.cohCreditCardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohCreditCardOwnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohCreditCardBank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohAddressLine1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohAddressLine2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohCreditCardLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohCreditCardBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohActivationStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCreditCardList = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetAllCreditCards = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditCardList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCreditCardList
            // 
            this.dgvCreditCardList.AllowUserToAddRows = false;
            this.dgvCreditCardList.AllowUserToDeleteRows = false;
            this.dgvCreditCardList.AllowUserToResizeColumns = false;
            this.dgvCreditCardList.AllowUserToResizeRows = false;
            this.dgvCreditCardList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCreditCardList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCreditCardList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCreditCardList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cohCreditCardNumber,
            this.cohCreditCardOwnerName,
            this.cohCreditCardBank,
            this.cohExpirationDate,
            this.cohAddressLine1,
            this.cohAddressLine2,
            this.cohCity,
            this.cohState,
            this.cohZipCode,
            this.cohCountry,
            this.cohCreditCardLimit,
            this.cohCreditCardBalance,
            this.cohActivationStatus});
            this.dgvCreditCardList.EnableHeadersVisualStyles = false;
            this.dgvCreditCardList.Location = new System.Drawing.Point(55, 126);
            this.dgvCreditCardList.MultiSelect = false;
            this.dgvCreditCardList.Name = "dgvCreditCardList";
            this.dgvCreditCardList.ReadOnly = true;
            this.dgvCreditCardList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCreditCardList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCreditCardList.Size = new System.Drawing.Size(1343, 245);
            this.dgvCreditCardList.TabIndex = 0;
            // 
            // cohCreditCardNumber
            // 
            this.cohCreditCardNumber.DataPropertyName = "CreditCardNumber";
            this.cohCreditCardNumber.HeaderText = "Card Number";
            this.cohCreditCardNumber.Name = "cohCreditCardNumber";
            this.cohCreditCardNumber.ReadOnly = true;
            // 
            // cohCreditCardOwnerName
            // 
            this.cohCreditCardOwnerName.DataPropertyName = "CreditCardOwnerName";
            this.cohCreditCardOwnerName.HeaderText = "Owner Name";
            this.cohCreditCardOwnerName.Name = "cohCreditCardOwnerName";
            this.cohCreditCardOwnerName.ReadOnly = true;
            // 
            // cohCreditCardBank
            // 
            this.cohCreditCardBank.DataPropertyName = "MerchantName";
            this.cohCreditCardBank.HeaderText = "Card Company";
            this.cohCreditCardBank.Name = "cohCreditCardBank";
            this.cohCreditCardBank.ReadOnly = true;
            // 
            // cohExpirationDate
            // 
            this.cohExpirationDate.DataPropertyName = "ExpDate";
            this.cohExpirationDate.HeaderText = "Expiration Date";
            this.cohExpirationDate.Name = "cohExpirationDate";
            this.cohExpirationDate.ReadOnly = true;
            // 
            // cohAddressLine1
            // 
            this.cohAddressLine1.DataPropertyName = "AddressLine1";
            this.cohAddressLine1.HeaderText = "Address Line 1";
            this.cohAddressLine1.Name = "cohAddressLine1";
            this.cohAddressLine1.ReadOnly = true;
            // 
            // cohAddressLine2
            // 
            this.cohAddressLine2.DataPropertyName = "AddressLine2";
            this.cohAddressLine2.HeaderText = "Address Line 2";
            this.cohAddressLine2.Name = "cohAddressLine2";
            this.cohAddressLine2.ReadOnly = true;
            // 
            // cohCity
            // 
            this.cohCity.DataPropertyName = "City";
            this.cohCity.HeaderText = "City";
            this.cohCity.Name = "cohCity";
            this.cohCity.ReadOnly = true;
            // 
            // cohState
            // 
            this.cohState.DataPropertyName = "State";
            this.cohState.HeaderText = "State";
            this.cohState.Name = "cohState";
            this.cohState.ReadOnly = true;
            // 
            // cohZipCode
            // 
            this.cohZipCode.DataPropertyName = "ZipCode";
            this.cohZipCode.HeaderText = "Zip Code";
            this.cohZipCode.Name = "cohZipCode";
            this.cohZipCode.ReadOnly = true;
            // 
            // cohCountry
            // 
            this.cohCountry.DataPropertyName = "Country";
            this.cohCountry.HeaderText = "Country";
            this.cohCountry.Name = "cohCountry";
            this.cohCountry.ReadOnly = true;
            // 
            // cohCreditCardLimit
            // 
            this.cohCreditCardLimit.DataPropertyName = "CreditCardLimit";
            this.cohCreditCardLimit.HeaderText = "Credit Limit";
            this.cohCreditCardLimit.Name = "cohCreditCardLimit";
            this.cohCreditCardLimit.ReadOnly = true;
            // 
            // cohCreditCardBalance
            // 
            this.cohCreditCardBalance.DataPropertyName = "CreditCardBalance";
            this.cohCreditCardBalance.HeaderText = "Credit Balance";
            this.cohCreditCardBalance.Name = "cohCreditCardBalance";
            this.cohCreditCardBalance.ReadOnly = true;
            // 
            // cohActivationStatus
            // 
            this.cohActivationStatus.DataPropertyName = "ActivationStatus";
            this.cohActivationStatus.HeaderText = "Activation Status";
            this.cohActivationStatus.Name = "cohActivationStatus";
            this.cohActivationStatus.ReadOnly = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(706, 387);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCreditCardList
            // 
            this.lblCreditCardList.AutoSize = true;
            this.lblCreditCardList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCreditCardList.Location = new System.Drawing.Point(54, 9);
            this.lblCreditCardList.Name = "lblCreditCardList";
            this.lblCreditCardList.Size = new System.Drawing.Size(134, 20);
            this.lblCreditCardList.TabIndex = 2;
            this.lblCreditCardList.Text = "List Credit Card";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Click the button below to list all credit cards";
            // 
            // btnGetAllCreditCards
            // 
            this.btnGetAllCreditCards.Location = new System.Drawing.Point(58, 82);
            this.btnGetAllCreditCards.Name = "btnGetAllCreditCards";
            this.btnGetAllCreditCards.Size = new System.Drawing.Size(117, 23);
            this.btnGetAllCreditCards.TabIndex = 4;
            this.btnGetAllCreditCards.Text = "List all credit cards";
            this.btnGetAllCreditCards.UseVisualStyleBackColor = true;
            this.btnGetAllCreditCards.Click += new System.EventHandler(this.btnGetAllCreditCards_Click);
            // 
            // frmCreditCardListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 450);
            this.Controls.Add(this.btnGetAllCreditCards);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCreditCardList);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvCreditCardList);
            this.Name = "frmCreditCardListForm";
            this.Text = "frmCreditCardListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditCardList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCreditCardList;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohCreditCardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohCreditCardOwnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohCreditCardBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohExpirationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohAddressLine1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohAddressLine2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohState;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohZipCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohCreditCardLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohCreditCardBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohActivationStatus;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCreditCardList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetAllCreditCards;
    }
}