
namespace EZRentalWindowsFormsApp
{
    partial class frmCreditCardRegistrationForm
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
            this.lblCreditCardNumber = new System.Windows.Forms.Label();
            this.txtCreditCardNumber = new System.Windows.Forms.TextBox();
            this.grpEnterCCInfo = new System.Windows.Forms.GroupBox();
            this.cbStateCode = new System.Windows.Forms.ComboBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.dtpExpDate = new System.Windows.Forms.DateTimePicker();
            this.txtActivationStatus = new System.Windows.Forms.TextBox();
            this.lblActivationStatus = new System.Windows.Forms.Label();
            this.txtCreditCardLimit = new System.Windows.Forms.TextBox();
            this.txtCreditCardBalance = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.txtCreditCardCompany = new System.Windows.Forms.TextBox();
            this.txtCardOwner = new System.Windows.Forms.TextBox();
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
            this.btnApply = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpEnterCCInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(61, 8);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(203, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Credit Card Registration";
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.Location = new System.Drawing.Point(14, 14);
            this.lblEnter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(145, 13);
            this.lblEnter.TabIndex = 1;
            this.lblEnter.Text = "Enter Credit Card Information:";
            // 
            // lblCreditCardNumber
            // 
            this.lblCreditCardNumber.AutoSize = true;
            this.lblCreditCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardNumber.Location = new System.Drawing.Point(14, 45);
            this.lblCreditCardNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreditCardNumber.Name = "lblCreditCardNumber";
            this.lblCreditCardNumber.Size = new System.Drawing.Size(117, 13);
            this.lblCreditCardNumber.TabIndex = 2;
            this.lblCreditCardNumber.Text = "Credit Card Number";
            // 
            // txtCreditCardNumber
            // 
            this.txtCreditCardNumber.Location = new System.Drawing.Point(144, 38);
            this.txtCreditCardNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreditCardNumber.Name = "txtCreditCardNumber";
            this.txtCreditCardNumber.Size = new System.Drawing.Size(123, 20);
            this.txtCreditCardNumber.TabIndex = 3;
            // 
            // grpEnterCCInfo
            // 
            this.grpEnterCCInfo.Controls.Add(this.cbStateCode);
            this.grpEnterCCInfo.Controls.Add(this.cbCountry);
            this.grpEnterCCInfo.Controls.Add(this.dtpExpDate);
            this.grpEnterCCInfo.Controls.Add(this.txtActivationStatus);
            this.grpEnterCCInfo.Controls.Add(this.lblActivationStatus);
            this.grpEnterCCInfo.Controls.Add(this.txtCreditCardLimit);
            this.grpEnterCCInfo.Controls.Add(this.txtCreditCardBalance);
            this.grpEnterCCInfo.Controls.Add(this.txtZipCode);
            this.grpEnterCCInfo.Controls.Add(this.txtCity);
            this.grpEnterCCInfo.Controls.Add(this.txtAddressLine2);
            this.grpEnterCCInfo.Controls.Add(this.txtAddressLine1);
            this.grpEnterCCInfo.Controls.Add(this.txtCreditCardCompany);
            this.grpEnterCCInfo.Controls.Add(this.txtCardOwner);
            this.grpEnterCCInfo.Controls.Add(this.lblCreditCardLimit);
            this.grpEnterCCInfo.Controls.Add(this.lblCreditCardBalance);
            this.grpEnterCCInfo.Controls.Add(this.lblCountry);
            this.grpEnterCCInfo.Controls.Add(this.lblZipCode);
            this.grpEnterCCInfo.Controls.Add(this.lblState);
            this.grpEnterCCInfo.Controls.Add(this.lblCity);
            this.grpEnterCCInfo.Controls.Add(this.lblAddressLine2);
            this.grpEnterCCInfo.Controls.Add(this.lblAddressLine1);
            this.grpEnterCCInfo.Controls.Add(this.lblExpDate);
            this.grpEnterCCInfo.Controls.Add(this.lblCreditCardCompany);
            this.grpEnterCCInfo.Controls.Add(this.lblCardOwner);
            this.grpEnterCCInfo.Controls.Add(this.lblEnter);
            this.grpEnterCCInfo.Controls.Add(this.txtCreditCardNumber);
            this.grpEnterCCInfo.Controls.Add(this.lblCreditCardNumber);
            this.grpEnterCCInfo.Location = new System.Drawing.Point(20, 40);
            this.grpEnterCCInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpEnterCCInfo.Name = "grpEnterCCInfo";
            this.grpEnterCCInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpEnterCCInfo.Size = new System.Drawing.Size(296, 428);
            this.grpEnterCCInfo.TabIndex = 4;
            this.grpEnterCCInfo.TabStop = false;
            // 
            // cbStateCode
            // 
            this.cbStateCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStateCode.FormattingEnabled = true;
            this.cbStateCode.Location = new System.Drawing.Point(144, 242);
            this.cbStateCode.Name = "cbStateCode";
            this.cbStateCode.Size = new System.Drawing.Size(58, 21);
            this.cbStateCode.TabIndex = 30;
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(144, 300);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(123, 21);
            this.cbCountry.TabIndex = 29;
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.CustomFormat = "yyyy-MM-dd";
            this.dtpExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpDate.Location = new System.Drawing.Point(144, 126);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(95, 20);
            this.dtpExpDate.TabIndex = 28;
            // 
            // txtActivationStatus
            // 
            this.txtActivationStatus.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtActivationStatus.Location = new System.Drawing.Point(144, 392);
            this.txtActivationStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtActivationStatus.Name = "txtActivationStatus";
            this.txtActivationStatus.ReadOnly = true;
            this.txtActivationStatus.Size = new System.Drawing.Size(95, 20);
            this.txtActivationStatus.TabIndex = 27;
            // 
            // lblActivationStatus
            // 
            this.lblActivationStatus.AutoSize = true;
            this.lblActivationStatus.Location = new System.Drawing.Point(14, 399);
            this.lblActivationStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActivationStatus.Name = "lblActivationStatus";
            this.lblActivationStatus.Size = new System.Drawing.Size(87, 13);
            this.lblActivationStatus.TabIndex = 26;
            this.lblActivationStatus.Text = "Activation Status";
            // 
            // txtCreditCardLimit
            // 
            this.txtCreditCardLimit.Location = new System.Drawing.Point(144, 332);
            this.txtCreditCardLimit.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreditCardLimit.Name = "txtCreditCardLimit";
            this.txtCreditCardLimit.Size = new System.Drawing.Size(95, 20);
            this.txtCreditCardLimit.TabIndex = 25;
            // 
            // txtCreditCardBalance
            // 
            this.txtCreditCardBalance.Location = new System.Drawing.Point(144, 362);
            this.txtCreditCardBalance.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreditCardBalance.Name = "txtCreditCardBalance";
            this.txtCreditCardBalance.Size = new System.Drawing.Size(95, 20);
            this.txtCreditCardBalance.TabIndex = 24;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(144, 271);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(95, 20);
            this.txtZipCode.TabIndex = 22;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(144, 214);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(95, 20);
            this.txtCity.TabIndex = 20;
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Location = new System.Drawing.Point(144, 186);
            this.txtAddressLine2.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(123, 20);
            this.txtAddressLine2.TabIndex = 19;
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Location = new System.Drawing.Point(144, 156);
            this.txtAddressLine1.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(123, 20);
            this.txtAddressLine1.TabIndex = 18;
            // 
            // txtCreditCardCompany
            // 
            this.txtCreditCardCompany.Location = new System.Drawing.Point(144, 94);
            this.txtCreditCardCompany.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreditCardCompany.Name = "txtCreditCardCompany";
            this.txtCreditCardCompany.Size = new System.Drawing.Size(95, 20);
            this.txtCreditCardCompany.TabIndex = 16;
            // 
            // txtCardOwner
            // 
            this.txtCardOwner.Location = new System.Drawing.Point(144, 67);
            this.txtCardOwner.Margin = new System.Windows.Forms.Padding(2);
            this.txtCardOwner.Name = "txtCardOwner";
            this.txtCardOwner.Size = new System.Drawing.Size(95, 20);
            this.txtCardOwner.TabIndex = 15;
            // 
            // lblCreditCardLimit
            // 
            this.lblCreditCardLimit.AutoSize = true;
            this.lblCreditCardLimit.Location = new System.Drawing.Point(14, 335);
            this.lblCreditCardLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreditCardLimit.Name = "lblCreditCardLimit";
            this.lblCreditCardLimit.Size = new System.Drawing.Size(83, 13);
            this.lblCreditCardLimit.TabIndex = 14;
            this.lblCreditCardLimit.Text = "Credit Card Limit";
            // 
            // lblCreditCardBalance
            // 
            this.lblCreditCardBalance.AutoSize = true;
            this.lblCreditCardBalance.Location = new System.Drawing.Point(14, 369);
            this.lblCreditCardBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreditCardBalance.Name = "lblCreditCardBalance";
            this.lblCreditCardBalance.Size = new System.Drawing.Size(101, 13);
            this.lblCreditCardBalance.TabIndex = 13;
            this.lblCreditCardBalance.Text = "Credit Card Balance";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(14, 308);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 12;
            this.lblCountry.Text = "Country";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(14, 278);
            this.lblZipCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(50, 13);
            this.lblZipCode.TabIndex = 11;
            this.lblZipCode.Text = "Zip Code";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(14, 250);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "State";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(14, 221);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = "City";
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Location = new System.Drawing.Point(14, 193);
            this.lblAddressLine2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine2.TabIndex = 8;
            this.lblAddressLine2.Text = "Address Line 2";
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Location = new System.Drawing.Point(14, 163);
            this.lblAddressLine1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine1.TabIndex = 7;
            this.lblAddressLine1.Text = "Address Line 1";
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Location = new System.Drawing.Point(14, 132);
            this.lblExpDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(79, 13);
            this.lblExpDate.TabIndex = 6;
            this.lblExpDate.Text = "Expiration Date";
            // 
            // lblCreditCardCompany
            // 
            this.lblCreditCardCompany.AutoSize = true;
            this.lblCreditCardCompany.Location = new System.Drawing.Point(14, 101);
            this.lblCreditCardCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreditCardCompany.Name = "lblCreditCardCompany";
            this.lblCreditCardCompany.Size = new System.Drawing.Size(106, 13);
            this.lblCreditCardCompany.TabIndex = 5;
            this.lblCreditCardCompany.Text = "Credit Card Company";
            // 
            // lblCardOwner
            // 
            this.lblCardOwner.AutoSize = true;
            this.lblCardOwner.Location = new System.Drawing.Point(14, 74);
            this.lblCardOwner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCardOwner.Name = "lblCardOwner";
            this.lblCardOwner.Size = new System.Drawing.Size(94, 13);
            this.lblCardOwner.TabIndex = 4;
            this.lblCardOwner.Text = "Card Owner Name";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(164, 483);
            this.btnApply.Margin = new System.Windows.Forms.Padding(2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(58, 24);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(259, 484);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 24);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCreditCardRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 519);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.grpEnterCCInfo);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCreditCardRegistrationForm";
            this.Text = "Credit Card Registration";
            this.Load += new System.EventHandler(this.frmCreditCardRegistrationForm_Load);
            this.grpEnterCCInfo.ResumeLayout(false);
            this.grpEnterCCInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label lblCreditCardNumber;
        private System.Windows.Forms.TextBox txtCreditCardNumber;
        private System.Windows.Forms.GroupBox grpEnterCCInfo;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.TextBox txtCreditCardCompany;
        private System.Windows.Forms.TextBox txtCardOwner;
        private System.Windows.Forms.Label lblCreditCardLimit;
        private System.Windows.Forms.Label lblCreditCardBalance;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.Label lblCreditCardCompany;
        private System.Windows.Forms.Label lblCardOwner;
        private System.Windows.Forms.TextBox txtCreditCardLimit;
        private System.Windows.Forms.TextBox txtCreditCardBalance;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.TextBox txtActivationStatus;
        private System.Windows.Forms.Label lblActivationStatus;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dtpExpDate;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.ComboBox cbStateCode;
    }
}