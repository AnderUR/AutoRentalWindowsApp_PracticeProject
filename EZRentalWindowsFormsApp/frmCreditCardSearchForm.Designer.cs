
namespace EZRentalWindowsFormsApp
{
    partial class frmCreditCardSearchForm
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
            this.lblEnter = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.txtCNumber = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblCreditCardNumber = new System.Windows.Forms.Label();
            this.txtCreditCardNumber = new System.Windows.Forms.TextBox();
            this.lblCardOwner = new System.Windows.Forms.Label();
            this.txtCardOwner = new System.Windows.Forms.TextBox();
            this.lblCreditCardCompany = new System.Windows.Forms.Label();
            this.txtCreditCardCompany = new System.Windows.Forms.TextBox();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCreditCardBalance = new System.Windows.Forms.Label();
            this.lblCreditCardLimit = new System.Windows.Forms.Label();
            this.lblActivationStatus = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCreditCardBalance = new System.Windows.Forms.TextBox();
            this.txtCreditCardLimit = new System.Windows.Forms.TextBox();
            this.txtActivationStatus = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpCardNumberSearch = new System.Windows.Forms.GroupBox();
            this.grpCCInfo = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblPrintCreditCardInfo = new System.Windows.Forms.Label();
            this.grpCardNumberSearch.SuspendLayout();
            this.grpCCInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(115, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(162, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Credit Card Search";
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.Location = new System.Drawing.Point(9, 14);
            this.lblEnter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(200, 13);
            this.lblEnter.TabIndex = 1;
            this.lblEnter.Text = "Enter Credit Card Number && Click Submit:";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(11, 35);
            this.lblCardNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(80, 13);
            this.lblCardNumber.TabIndex = 2;
            this.lblCardNumber.Text = "Card Number";
            // 
            // txtCNumber
            // 
            this.txtCNumber.Location = new System.Drawing.Point(99, 31);
            this.txtCNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtCNumber.Name = "txtCNumber";
            this.txtCNumber.Size = new System.Drawing.Size(105, 20);
            this.txtCNumber.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(240, 30);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(53, 21);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(9, 14);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(117, 13);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Credit Card Information:";
            // 
            // lblCreditCardNumber
            // 
            this.lblCreditCardNumber.AutoSize = true;
            this.lblCreditCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardNumber.Location = new System.Drawing.Point(9, 34);
            this.lblCreditCardNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreditCardNumber.Name = "lblCreditCardNumber";
            this.lblCreditCardNumber.Size = new System.Drawing.Size(117, 13);
            this.lblCreditCardNumber.TabIndex = 6;
            this.lblCreditCardNumber.Text = "Credit Card Number";
            // 
            // txtCreditCardNumber
            // 
            this.txtCreditCardNumber.Location = new System.Drawing.Point(137, 34);
            this.txtCreditCardNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreditCardNumber.Name = "txtCreditCardNumber";
            this.txtCreditCardNumber.ReadOnly = true;
            this.txtCreditCardNumber.Size = new System.Drawing.Size(109, 20);
            this.txtCreditCardNumber.TabIndex = 7;
            // 
            // lblCardOwner
            // 
            this.lblCardOwner.AutoSize = true;
            this.lblCardOwner.Location = new System.Drawing.Point(9, 57);
            this.lblCardOwner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCardOwner.Name = "lblCardOwner";
            this.lblCardOwner.Size = new System.Drawing.Size(94, 13);
            this.lblCardOwner.TabIndex = 8;
            this.lblCardOwner.Text = "Card Owner Name";
            // 
            // txtCardOwner
            // 
            this.txtCardOwner.Location = new System.Drawing.Point(137, 57);
            this.txtCardOwner.Margin = new System.Windows.Forms.Padding(2);
            this.txtCardOwner.Name = "txtCardOwner";
            this.txtCardOwner.ReadOnly = true;
            this.txtCardOwner.Size = new System.Drawing.Size(109, 20);
            this.txtCardOwner.TabIndex = 9;
            // 
            // lblCreditCardCompany
            // 
            this.lblCreditCardCompany.AutoSize = true;
            this.lblCreditCardCompany.Location = new System.Drawing.Point(9, 81);
            this.lblCreditCardCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreditCardCompany.Name = "lblCreditCardCompany";
            this.lblCreditCardCompany.Size = new System.Drawing.Size(106, 13);
            this.lblCreditCardCompany.TabIndex = 10;
            this.lblCreditCardCompany.Text = "Credit Card Company";
            // 
            // txtCreditCardCompany
            // 
            this.txtCreditCardCompany.Location = new System.Drawing.Point(137, 81);
            this.txtCreditCardCompany.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreditCardCompany.Name = "txtCreditCardCompany";
            this.txtCreditCardCompany.ReadOnly = true;
            this.txtCreditCardCompany.Size = new System.Drawing.Size(109, 20);
            this.txtCreditCardCompany.TabIndex = 11;
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Location = new System.Drawing.Point(11, 105);
            this.lblExpDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(79, 13);
            this.lblExpDate.TabIndex = 12;
            this.lblExpDate.Text = "Expiration Date";
            this.lblExpDate.UseWaitCursor = true;
            // 
            // txtExpDate
            // 
            this.txtExpDate.Location = new System.Drawing.Point(136, 105);
            this.txtExpDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.ReadOnly = true;
            this.txtExpDate.Size = new System.Drawing.Size(110, 20);
            this.txtExpDate.TabIndex = 13;
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Location = new System.Drawing.Point(11, 131);
            this.lblAddressLine1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine1.TabIndex = 14;
            this.lblAddressLine1.Text = "Address Line 1";
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Location = new System.Drawing.Point(136, 131);
            this.txtAddressLine1.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.ReadOnly = true;
            this.txtAddressLine1.Size = new System.Drawing.Size(157, 20);
            this.txtAddressLine1.TabIndex = 15;
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Location = new System.Drawing.Point(136, 155);
            this.txtAddressLine2.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.ReadOnly = true;
            this.txtAddressLine2.Size = new System.Drawing.Size(157, 20);
            this.txtAddressLine2.TabIndex = 16;
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Location = new System.Drawing.Point(11, 155);
            this.lblAddressLine2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine2.TabIndex = 17;
            this.lblAddressLine2.Text = "Address Line 2";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(11, 179);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 18;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(136, 179);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(110, 20);
            this.txtCity.TabIndex = 19;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(11, 203);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 20;
            this.lblState.Text = "State";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(11, 228);
            this.lblZipCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(50, 13);
            this.lblZipCode.TabIndex = 21;
            this.lblZipCode.Text = "Zip Code";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(11, 252);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 22;
            this.lblCountry.Text = "Country";
            // 
            // lblCreditCardBalance
            // 
            this.lblCreditCardBalance.AutoSize = true;
            this.lblCreditCardBalance.Location = new System.Drawing.Point(11, 302);
            this.lblCreditCardBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreditCardBalance.Name = "lblCreditCardBalance";
            this.lblCreditCardBalance.Size = new System.Drawing.Size(101, 13);
            this.lblCreditCardBalance.TabIndex = 23;
            this.lblCreditCardBalance.Text = "Credit Card Balance";
            // 
            // lblCreditCardLimit
            // 
            this.lblCreditCardLimit.AutoSize = true;
            this.lblCreditCardLimit.Location = new System.Drawing.Point(11, 278);
            this.lblCreditCardLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreditCardLimit.Name = "lblCreditCardLimit";
            this.lblCreditCardLimit.Size = new System.Drawing.Size(83, 13);
            this.lblCreditCardLimit.TabIndex = 24;
            this.lblCreditCardLimit.Text = "Credit Card Limit";
            // 
            // lblActivationStatus
            // 
            this.lblActivationStatus.AutoSize = true;
            this.lblActivationStatus.Location = new System.Drawing.Point(11, 326);
            this.lblActivationStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActivationStatus.Name = "lblActivationStatus";
            this.lblActivationStatus.Size = new System.Drawing.Size(87, 13);
            this.lblActivationStatus.TabIndex = 25;
            this.lblActivationStatus.Text = "Activation Status";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(136, 203);
            this.txtState.Margin = new System.Windows.Forms.Padding(2);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(37, 20);
            this.txtState.TabIndex = 26;
            // 
            // txtZipcode
            // 
            this.txtZipcode.Location = new System.Drawing.Point(136, 228);
            this.txtZipcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.ReadOnly = true;
            this.txtZipcode.Size = new System.Drawing.Size(110, 20);
            this.txtZipcode.TabIndex = 27;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(136, 252);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(2);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(110, 20);
            this.txtCountry.TabIndex = 28;
            // 
            // txtCreditCardBalance
            // 
            this.txtCreditCardBalance.Location = new System.Drawing.Point(136, 302);
            this.txtCreditCardBalance.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreditCardBalance.Name = "txtCreditCardBalance";
            this.txtCreditCardBalance.ReadOnly = true;
            this.txtCreditCardBalance.Size = new System.Drawing.Size(110, 20);
            this.txtCreditCardBalance.TabIndex = 29;
            // 
            // txtCreditCardLimit
            // 
            this.txtCreditCardLimit.Location = new System.Drawing.Point(136, 278);
            this.txtCreditCardLimit.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreditCardLimit.Name = "txtCreditCardLimit";
            this.txtCreditCardLimit.ReadOnly = true;
            this.txtCreditCardLimit.Size = new System.Drawing.Size(110, 20);
            this.txtCreditCardLimit.TabIndex = 30;
            // 
            // txtActivationStatus
            // 
            this.txtActivationStatus.Location = new System.Drawing.Point(136, 326);
            this.txtActivationStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtActivationStatus.Name = "txtActivationStatus";
            this.txtActivationStatus.ReadOnly = true;
            this.txtActivationStatus.Size = new System.Drawing.Size(110, 20);
            this.txtActivationStatus.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(413, 480);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 23);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpCardNumberSearch
            // 
            this.grpCardNumberSearch.Controls.Add(this.btnSearch);
            this.grpCardNumberSearch.Controls.Add(this.lblEnter);
            this.grpCardNumberSearch.Controls.Add(this.lblCardNumber);
            this.grpCardNumberSearch.Controls.Add(this.txtCNumber);
            this.grpCardNumberSearch.Location = new System.Drawing.Point(30, 34);
            this.grpCardNumberSearch.Margin = new System.Windows.Forms.Padding(2);
            this.grpCardNumberSearch.Name = "grpCardNumberSearch";
            this.grpCardNumberSearch.Padding = new System.Windows.Forms.Padding(2);
            this.grpCardNumberSearch.Size = new System.Drawing.Size(319, 63);
            this.grpCardNumberSearch.TabIndex = 32;
            this.grpCardNumberSearch.TabStop = false;
            // 
            // grpCCInfo
            // 
            this.grpCCInfo.Controls.Add(this.lblInfo);
            this.grpCCInfo.Controls.Add(this.lblCreditCardNumber);
            this.grpCCInfo.Controls.Add(this.txtCreditCardNumber);
            this.grpCCInfo.Controls.Add(this.lblActivationStatus);
            this.grpCCInfo.Controls.Add(this.txtActivationStatus);
            this.grpCCInfo.Controls.Add(this.lblCardOwner);
            this.grpCCInfo.Controls.Add(this.txtCreditCardLimit);
            this.grpCCInfo.Controls.Add(this.txtCardOwner);
            this.grpCCInfo.Controls.Add(this.txtCreditCardBalance);
            this.grpCCInfo.Controls.Add(this.lblCreditCardLimit);
            this.grpCCInfo.Controls.Add(this.lblCreditCardCompany);
            this.grpCCInfo.Controls.Add(this.txtCountry);
            this.grpCCInfo.Controls.Add(this.txtCreditCardCompany);
            this.grpCCInfo.Controls.Add(this.lblCreditCardBalance);
            this.grpCCInfo.Controls.Add(this.txtZipcode);
            this.grpCCInfo.Controls.Add(this.lblExpDate);
            this.grpCCInfo.Controls.Add(this.txtState);
            this.grpCCInfo.Controls.Add(this.lblCountry);
            this.grpCCInfo.Controls.Add(this.txtExpDate);
            this.grpCCInfo.Controls.Add(this.lblAddressLine1);
            this.grpCCInfo.Controls.Add(this.txtAddressLine1);
            this.grpCCInfo.Controls.Add(this.lblZipCode);
            this.grpCCInfo.Controls.Add(this.lblAddressLine2);
            this.grpCCInfo.Controls.Add(this.txtAddressLine2);
            this.grpCCInfo.Controls.Add(this.lblCity);
            this.grpCCInfo.Controls.Add(this.lblState);
            this.grpCCInfo.Controls.Add(this.txtCity);
            this.grpCCInfo.Location = new System.Drawing.Point(30, 101);
            this.grpCCInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpCCInfo.Name = "grpCCInfo";
            this.grpCCInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpCCInfo.Size = new System.Drawing.Size(319, 358);
            this.grpCCInfo.TabIndex = 33;
            this.grpCCInfo.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(404, 135);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 34;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblPrintCreditCardInfo
            // 
            this.lblPrintCreditCardInfo.AutoSize = true;
            this.lblPrintCreditCardInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintCreditCardInfo.Location = new System.Drawing.Point(356, 115);
            this.lblPrintCreditCardInfo.Name = "lblPrintCreditCardInfo";
            this.lblPrintCreditCardInfo.Size = new System.Drawing.Size(167, 13);
            this.lblPrintCreditCardInfo.TabIndex = 35;
            this.lblPrintCreditCardInfo.Text = "Print Credit Card Information";
            // 
            // frmCreditCardSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 513);
            this.Controls.Add(this.lblPrintCreditCardInfo);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.grpCCInfo);
            this.Controls.Add(this.grpCardNumberSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCreditCardSearchForm";
            this.Text = "Credit Card Search";
            this.grpCardNumberSearch.ResumeLayout(false);
            this.grpCardNumberSearch.PerformLayout();
            this.grpCCInfo.ResumeLayout(false);
            this.grpCCInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox txtCNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblCreditCardNumber;
        private System.Windows.Forms.TextBox txtCreditCardNumber;
        private System.Windows.Forms.Label lblCardOwner;
        private System.Windows.Forms.TextBox txtCardOwner;
        private System.Windows.Forms.Label lblCreditCardCompany;
        private System.Windows.Forms.TextBox txtCreditCardCompany;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.TextBox txtExpDate;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCreditCardBalance;
        private System.Windows.Forms.Label lblCreditCardLimit;
        private System.Windows.Forms.Label lblActivationStatus;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCreditCardBalance;
        private System.Windows.Forms.TextBox txtCreditCardLimit;
        private System.Windows.Forms.TextBox txtActivationStatus;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpCardNumberSearch;
        private System.Windows.Forms.GroupBox grpCCInfo;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblPrintCreditCardInfo;
    }
}