
namespace EZRentalWindowsFormsApp
{
    partial class frmCreditCardUpdateForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpCardNumberSearch = new System.Windows.Forms.GroupBox();
            this.txtCNumber = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblEnter = new System.Windows.Forms.Label();
            this.grpCCUpdate = new System.Windows.Forms.GroupBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.cbStateCode = new System.Windows.Forms.ComboBox();
            this.cbActivationStatus = new System.Windows.Forms.ComboBox();
            this.dtpExpDate = new System.Windows.Forms.DateTimePicker();
            this.txtCreditCardLimit = new System.Windows.Forms.TextBox();
            this.txtCreditCardBalance = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.txtCreditCardCompany = new System.Windows.Forms.TextBox();
            this.txtCardOwner = new System.Windows.Forms.TextBox();
            this.txtCreditCardNumber = new System.Windows.Forms.TextBox();
            this.lblActivationStatus = new System.Windows.Forms.Label();
            this.lblCreditCardLimit = new System.Windows.Forms.Label();
            this.lblCreditCardBalance = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.lblCreditCardCompany = new System.Windows.Forms.Label();
            this.lblCardOwner = new System.Windows.Forms.Label();
            this.lblCreditCardNumber = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpCardNumberSearch.SuspendLayout();
            this.grpCCUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(98, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(164, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Credit Card Update";
            // 
            // grpCardNumberSearch
            // 
            this.grpCardNumberSearch.Controls.Add(this.txtCNumber);
            this.grpCardNumberSearch.Controls.Add(this.btnSearch);
            this.grpCardNumberSearch.Controls.Add(this.lblCardNumber);
            this.grpCardNumberSearch.Controls.Add(this.lblEnter);
            this.grpCardNumberSearch.Location = new System.Drawing.Point(34, 37);
            this.grpCardNumberSearch.Margin = new System.Windows.Forms.Padding(2);
            this.grpCardNumberSearch.Name = "grpCardNumberSearch";
            this.grpCardNumberSearch.Padding = new System.Windows.Forms.Padding(2);
            this.grpCardNumberSearch.Size = new System.Drawing.Size(334, 84);
            this.grpCardNumberSearch.TabIndex = 1;
            this.grpCardNumberSearch.TabStop = false;
            // 
            // txtCNumber
            // 
            this.txtCNumber.Location = new System.Drawing.Point(140, 51);
            this.txtCNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtCNumber.Name = "txtCNumber";
            this.txtCNumber.Size = new System.Drawing.Size(109, 20);
            this.txtCNumber.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(262, 49);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(53, 22);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(19, 54);
            this.lblCardNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(117, 13);
            this.lblCardNumber.TabIndex = 1;
            this.lblCardNumber.Text = "Credit Card Number";
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.Location = new System.Drawing.Point(16, 17);
            this.lblEnter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(265, 26);
            this.lblEnter.TabIndex = 0;
            this.lblEnter.Text = "Enter Credit Card Number of Credit Card to Update \r\n&& Click Search button to ret" +
    "urn the Credit Card Record:";
            // 
            // grpCCUpdate
            // 
            this.grpCCUpdate.Controls.Add(this.cbCountry);
            this.grpCCUpdate.Controls.Add(this.cbStateCode);
            this.grpCCUpdate.Controls.Add(this.cbActivationStatus);
            this.grpCCUpdate.Controls.Add(this.dtpExpDate);
            this.grpCCUpdate.Controls.Add(this.txtCreditCardLimit);
            this.grpCCUpdate.Controls.Add(this.txtCreditCardBalance);
            this.grpCCUpdate.Controls.Add(this.txtZipCode);
            this.grpCCUpdate.Controls.Add(this.txtCity);
            this.grpCCUpdate.Controls.Add(this.txtAddressLine2);
            this.grpCCUpdate.Controls.Add(this.txtAddressLine1);
            this.grpCCUpdate.Controls.Add(this.txtCreditCardCompany);
            this.grpCCUpdate.Controls.Add(this.txtCardOwner);
            this.grpCCUpdate.Controls.Add(this.txtCreditCardNumber);
            this.grpCCUpdate.Controls.Add(this.lblActivationStatus);
            this.grpCCUpdate.Controls.Add(this.lblCreditCardLimit);
            this.grpCCUpdate.Controls.Add(this.lblCreditCardBalance);
            this.grpCCUpdate.Controls.Add(this.lblCountry);
            this.grpCCUpdate.Controls.Add(this.lblZipCode);
            this.grpCCUpdate.Controls.Add(this.lblState);
            this.grpCCUpdate.Controls.Add(this.lblCity);
            this.grpCCUpdate.Controls.Add(this.lblAddressLine2);
            this.grpCCUpdate.Controls.Add(this.lblAddressLine1);
            this.grpCCUpdate.Controls.Add(this.lblExpDate);
            this.grpCCUpdate.Controls.Add(this.lblCreditCardCompany);
            this.grpCCUpdate.Controls.Add(this.lblCardOwner);
            this.grpCCUpdate.Controls.Add(this.lblCreditCardNumber);
            this.grpCCUpdate.Controls.Add(this.lblInfo);
            this.grpCCUpdate.Location = new System.Drawing.Point(34, 125);
            this.grpCCUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.grpCCUpdate.Name = "grpCCUpdate";
            this.grpCCUpdate.Padding = new System.Windows.Forms.Padding(2);
            this.grpCCUpdate.Size = new System.Drawing.Size(334, 403);
            this.grpCCUpdate.TabIndex = 2;
            this.grpCCUpdate.TabStop = false;
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(148, 279);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(133, 21);
            this.cbCountry.TabIndex = 30;
            // 
            // cbStateCode
            // 
            this.cbStateCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStateCode.FormattingEnabled = true;
            this.cbStateCode.Location = new System.Drawing.Point(148, 225);
            this.cbStateCode.Name = "cbStateCode";
            this.cbStateCode.Size = new System.Drawing.Size(52, 21);
            this.cbStateCode.TabIndex = 29;
            // 
            // cbActivationStatus
            // 
            this.cbActivationStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActivationStatus.FormattingEnabled = true;
            this.cbActivationStatus.Location = new System.Drawing.Point(148, 362);
            this.cbActivationStatus.Name = "cbActivationStatus";
            this.cbActivationStatus.Size = new System.Drawing.Size(111, 21);
            this.cbActivationStatus.TabIndex = 28;
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.CustomFormat = "yyyy-MM-dd";
            this.dtpExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpDate.Location = new System.Drawing.Point(148, 119);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(95, 20);
            this.dtpExpDate.TabIndex = 27;
            // 
            // txtCreditCardLimit
            // 
            this.txtCreditCardLimit.Location = new System.Drawing.Point(148, 308);
            this.txtCreditCardLimit.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreditCardLimit.Name = "txtCreditCardLimit";
            this.txtCreditCardLimit.Size = new System.Drawing.Size(111, 20);
            this.txtCreditCardLimit.TabIndex = 25;
            // 
            // txtCreditCardBalance
            // 
            this.txtCreditCardBalance.Location = new System.Drawing.Point(148, 335);
            this.txtCreditCardBalance.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreditCardBalance.Name = "txtCreditCardBalance";
            this.txtCreditCardBalance.Size = new System.Drawing.Size(111, 20);
            this.txtCreditCardBalance.TabIndex = 24;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(148, 253);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(95, 20);
            this.txtZipCode.TabIndex = 22;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(148, 198);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(95, 20);
            this.txtCity.TabIndex = 20;
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Location = new System.Drawing.Point(148, 171);
            this.txtAddressLine2.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(133, 20);
            this.txtAddressLine2.TabIndex = 19;
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Location = new System.Drawing.Point(148, 144);
            this.txtAddressLine1.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(133, 20);
            this.txtAddressLine1.TabIndex = 18;
            // 
            // txtCreditCardCompany
            // 
            this.txtCreditCardCompany.Location = new System.Drawing.Point(148, 94);
            this.txtCreditCardCompany.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreditCardCompany.Name = "txtCreditCardCompany";
            this.txtCreditCardCompany.Size = new System.Drawing.Size(111, 20);
            this.txtCreditCardCompany.TabIndex = 16;
            // 
            // txtCardOwner
            // 
            this.txtCardOwner.Location = new System.Drawing.Point(148, 70);
            this.txtCardOwner.Margin = new System.Windows.Forms.Padding(2);
            this.txtCardOwner.Name = "txtCardOwner";
            this.txtCardOwner.Size = new System.Drawing.Size(111, 20);
            this.txtCardOwner.TabIndex = 15;
            // 
            // txtCreditCardNumber
            // 
            this.txtCreditCardNumber.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtCreditCardNumber.Location = new System.Drawing.Point(148, 46);
            this.txtCreditCardNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreditCardNumber.Name = "txtCreditCardNumber";
            this.txtCreditCardNumber.ReadOnly = true;
            this.txtCreditCardNumber.Size = new System.Drawing.Size(111, 20);
            this.txtCreditCardNumber.TabIndex = 14;
            // 
            // lblActivationStatus
            // 
            this.lblActivationStatus.AutoSize = true;
            this.lblActivationStatus.Location = new System.Drawing.Point(21, 362);
            this.lblActivationStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActivationStatus.Name = "lblActivationStatus";
            this.lblActivationStatus.Size = new System.Drawing.Size(87, 13);
            this.lblActivationStatus.TabIndex = 13;
            this.lblActivationStatus.Text = "Activation Status";
            // 
            // lblCreditCardLimit
            // 
            this.lblCreditCardLimit.AutoSize = true;
            this.lblCreditCardLimit.Location = new System.Drawing.Point(21, 308);
            this.lblCreditCardLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreditCardLimit.Name = "lblCreditCardLimit";
            this.lblCreditCardLimit.Size = new System.Drawing.Size(83, 13);
            this.lblCreditCardLimit.TabIndex = 12;
            this.lblCreditCardLimit.Text = "Credit Card Limit";
            // 
            // lblCreditCardBalance
            // 
            this.lblCreditCardBalance.AutoSize = true;
            this.lblCreditCardBalance.Location = new System.Drawing.Point(21, 335);
            this.lblCreditCardBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreditCardBalance.Name = "lblCreditCardBalance";
            this.lblCreditCardBalance.Size = new System.Drawing.Size(101, 13);
            this.lblCreditCardBalance.TabIndex = 11;
            this.lblCreditCardBalance.Text = "Credit Card Balance";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(21, 279);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 10;
            this.lblCountry.Text = "Country";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(21, 253);
            this.lblZipCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(50, 13);
            this.lblZipCode.TabIndex = 9;
            this.lblZipCode.Text = "Zip Code";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(21, 225);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 8;
            this.lblState.Text = "State";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(21, 198);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "City";
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Location = new System.Drawing.Point(21, 171);
            this.lblAddressLine2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine2.TabIndex = 6;
            this.lblAddressLine2.Text = "Address Line 2";
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Location = new System.Drawing.Point(21, 144);
            this.lblAddressLine1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(74, 13);
            this.lblAddressLine1.TabIndex = 5;
            this.lblAddressLine1.Text = "Address Line1";
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Location = new System.Drawing.Point(21, 119);
            this.lblExpDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(79, 13);
            this.lblExpDate.TabIndex = 4;
            this.lblExpDate.Text = "Expiration Date";
            // 
            // lblCreditCardCompany
            // 
            this.lblCreditCardCompany.AutoSize = true;
            this.lblCreditCardCompany.Location = new System.Drawing.Point(21, 94);
            this.lblCreditCardCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreditCardCompany.Name = "lblCreditCardCompany";
            this.lblCreditCardCompany.Size = new System.Drawing.Size(106, 13);
            this.lblCreditCardCompany.TabIndex = 3;
            this.lblCreditCardCompany.Text = "Credit Card Company";
            // 
            // lblCardOwner
            // 
            this.lblCardOwner.AutoSize = true;
            this.lblCardOwner.Location = new System.Drawing.Point(21, 70);
            this.lblCardOwner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCardOwner.Name = "lblCardOwner";
            this.lblCardOwner.Size = new System.Drawing.Size(94, 13);
            this.lblCardOwner.TabIndex = 2;
            this.lblCardOwner.Text = "Card Owner Name";
            // 
            // lblCreditCardNumber
            // 
            this.lblCreditCardNumber.AutoSize = true;
            this.lblCreditCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardNumber.Location = new System.Drawing.Point(21, 46);
            this.lblCreditCardNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreditCardNumber.Name = "lblCreditCardNumber";
            this.lblCreditCardNumber.Size = new System.Drawing.Size(117, 13);
            this.lblCreditCardNumber.TabIndex = 1;
            this.lblCreditCardNumber.Text = "Credit Card Number";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(19, 17);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(194, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Enter Credit Card information to Update:";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(232, 549);
            this.btnApply.Margin = new System.Windows.Forms.Padding(2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(45, 21);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(317, 549);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 21);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCreditCardUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 590);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.grpCCUpdate);
            this.Controls.Add(this.grpCardNumberSearch);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCreditCardUpdateForm";
            this.Text = "Credit Card Update";
            this.Load += new System.EventHandler(this.frmCreditCardUpdateForm_Load);
            this.grpCardNumberSearch.ResumeLayout(false);
            this.grpCardNumberSearch.PerformLayout();
            this.grpCCUpdate.ResumeLayout(false);
            this.grpCCUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpCardNumberSearch;
        private System.Windows.Forms.TextBox txtCNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.GroupBox grpCCUpdate;
        private System.Windows.Forms.Label lblCreditCardCompany;
        private System.Windows.Forms.Label lblCardOwner;
        private System.Windows.Forms.Label lblCreditCardNumber;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.TextBox txtCreditCardLimit;
        private System.Windows.Forms.TextBox txtCreditCardBalance;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.TextBox txtCreditCardCompany;
        private System.Windows.Forms.TextBox txtCardOwner;
        private System.Windows.Forms.TextBox txtCreditCardNumber;
        private System.Windows.Forms.Label lblActivationStatus;
        private System.Windows.Forms.Label lblCreditCardLimit;
        private System.Windows.Forms.Label lblCreditCardBalance;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dtpExpDate;
        private System.Windows.Forms.ComboBox cbActivationStatus;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.ComboBox cbStateCode;
    }
}