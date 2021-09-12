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
    public partial class frmCreditCardRegistrationForm : Form
    {
        public frmCreditCardRegistrationForm()
        {
            InitializeComponent();
        }

        private void frmCreditCardRegistrationForm_Load(object sender, EventArgs e)
        {
            //Bind list of Country objects to combobox 
            List<Country> listCountry = Country.GetAllCountries();

            cbCountry.DataSource = listCountry;
            cbCountry.DisplayMember = "CountryName";

            //Bind list of USState objects to combobox
            List<USState> listUSState = USState.GetAllUSStates();

            cbStateCode.DataSource = listUSState;
            cbStateCode.DisplayMember = "StateCode";

            //set credit card default vlaue sfor balance and limit
            CreditCard objcCard = new CreditCard();

            txtCreditCardBalance.Text = objcCard.CreditCardBalance.ToString();
            txtCreditCardLimit.Text = objcCard.CreditCardLimit.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close this form
            //program flow automatically goes back to CreditCardMS Form
            //which opened this form aa a dialog form.
            this.Close();
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
            objcCard.CreditCardLimit = Convert.ToDecimal(txtCreditCardLimit.Text);
            objcCard.CreditCardBalance = Convert.ToDecimal(txtCreditCardBalance.Text);

            //Call Insert() to add data to database
            
            try
            {
                bool success = objcCard.Insert();

                if (success)
                {
                    MessageBox.Show("The credit card was added successfully");
                }
                else
                {
                    MessageBox.Show("Invalid Entry");
                }
            } catch(Exception objE)
            {
                Console.WriteLine("Unexpected Error is DALayer_Insert() Method: {0} " + objE.Message);
                MessageBox.Show("Failed to insert the new credit card. Please check your card information again. Make sure the card does not already exist.");
            }

        }

    }
}