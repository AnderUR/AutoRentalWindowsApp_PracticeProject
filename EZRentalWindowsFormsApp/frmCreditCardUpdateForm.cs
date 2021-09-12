using EZRentalBOLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZRentalWindowsFormsApp
{
    public partial class frmCreditCardUpdateForm : Form
    {

        public frmCreditCardUpdateForm()
        {
            InitializeComponent();
        }

        private void frmCreditCardUpdateForm_Load(object sender, EventArgs e)
        {
            //Bind list of Country objects to combobox 
            List<Country> listCountry = Country.GetAllCountries();

            cbCountry.DataSource = listCountry;
            cbCountry.DisplayMember = "CountryName";

            //Bind list of USState objects to combobox
            List<USState> listUSState = USState.GetAllUSStates();

            cbStateCode.DataSource = listUSState;
            cbStateCode.DisplayMember = "StateCode";

            //Fill activation status combobox. 
            cbActivationStatus.Items.Add("Deactivate");
            cbActivationStatus.Items.Add("Activate");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close this form
            //program flow automatically goes back to CreditCardMS Form
            //which opened this form aa a dialog form.
            this.Close();
        }
           
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Create CreditCard Object
            CreditCard objcCard = new CreditCard();

            //Use Object to call the Load method passing the textbox value as parameter
            objcCard.Load(txtCNumber.Text.Trim());

            //Validate if customer is found
            if (objcCard.CreditCardNumber != "")
            {
                //Retrieve data from populated Credit Card Object 
                //Display the data to the user
                txtCreditCardNumber.Text = objcCard.CreditCardNumber;
                txtCardOwner.Text = objcCard.CreditCardOwnerName;
                txtCreditCardCompany.Text = objcCard.MerchantName;
                dtpExpDate.Text = objcCard.ExpDate.ToString();
                txtAddressLine1.Text = objcCard.AddressLine1;
                txtAddressLine2.Text = objcCard.AddressLine2;
                txtCity.Text = objcCard.City;
                cbStateCode.Text = objcCard.StateCode;
                txtZipCode.Text = objcCard.ZipCode;
                cbCountry.Text = objcCard.Country;
                txtCreditCardBalance.Text = objcCard.CreditCardBalance.ToString();
                txtCreditCardLimit.Text = objcCard.CreditCardLimit.ToString();

                if (objcCard.ActivationStatus)
                {
                    cbActivationStatus.SelectedIndex = 1;
                } 
                else
                {
                    cbActivationStatus.SelectedIndex = 0;
                }
            } else
            {
                MessageBox.Show("No credit card was found for the given credit card number.");
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //Create CreditCard Object
            CreditCard objcCard = new CreditCard();

            //Set Credit Card Object with Data from form
            objcCard.CreditCardNumber = txtCreditCardNumber.Text;
            objcCard.CreditCardOwnerName = txtCardOwner.Text;
            objcCard.MerchantName = txtCreditCardCompany.Text;
            objcCard.ExpDate = Convert.ToDateTime(dtpExpDate.Text);
            objcCard.AddressLine1 = txtAddressLine1.Text;
            objcCard.AddressLine2 = txtAddressLine2.Text;
            objcCard.City = txtCity.Text;
            objcCard.StateCode = cbStateCode.Text;
            objcCard.ZipCode = txtZipCode.Text;
            objcCard.Country = cbCountry.Text;
            objcCard.CreditCardBalance = Convert.ToDecimal(txtCreditCardBalance.Text);
            objcCard.CreditCardLimit = Convert.ToDecimal(txtCreditCardLimit.Text);

            bool success = objcCard.Update();

            if (success)
            {
                MessageBox.Show("The credit card was updated successfully");
            }
            else
            {
                MessageBox.Show("Invalid Entry");
            }
        }
    }
}
