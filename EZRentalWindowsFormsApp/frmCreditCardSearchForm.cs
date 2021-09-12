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
    public partial class frmCreditCardSearchForm : Form
    {
        private bool canPrint = false;

        public frmCreditCardSearchForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Create CreditCard Object
            CreditCard objcCard = new CreditCard();

            //Use Object to call the Load method passing the textbox value as parameter
            objcCard.Load(txtCNumber.Text.Trim());

            //Validate if credit card is found
            if(objcCard.CreditCardNumber != "")
            {
                //Retrieve data from populated Credit Card Object 
                //Display the data to the user
                txtCreditCardNumber.Text = objcCard.CreditCardNumber;
                txtCardOwner.Text = objcCard.CreditCardOwnerName;
                txtCreditCardCompany.Text = objcCard.MerchantName;
                txtExpDate.Text = objcCard.ExpDate.ToString();
                txtAddressLine1.Text = objcCard.AddressLine1;
                txtAddressLine2.Text = objcCard.AddressLine2;
                txtCity.Text = objcCard.City;
                txtState.Text = objcCard.StateCode;
                txtZipcode.Text = objcCard.ZipCode;
                txtCountry.Text = objcCard.Country;
                txtCreditCardLimit.Text = objcCard.CreditCardLimit.ToString();
                txtCreditCardBalance.Text = objcCard.CreditCardBalance.ToString();
                txtActivationStatus.Text = objcCard.ActivationStatus.ToString();

                //Allow print after textboxes have been populated
                this.canPrint = true;

            }//End of If
            else
            {
                //Prompt user credit card not found
                MessageBox.Show("Credit Card Not Found ");

                //Clear all controls
                txtCNumber.Text = "";
                txtCreditCardNumber.Text = "";
                txtCardOwner.Text = "";
                txtCreditCardCompany.Text = "";
                txtExpDate.Text = "";
                txtAddressLine1.Text = "";
                txtAddressLine2.Text = "";
                txtCity.Text = "";
                txtState.Text = "";
                txtZipcode.Text = "";
                txtCountry.Text = "";
                txtCreditCardLimit.Text = "";
                txtCreditCardBalance.Text = "";
                txtActivationStatus.Text = "";
            }//end of else

        }//end of Search

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(this.canPrint == true)
            {
                CreditCard objcCard = new CreditCard();

                objcCard.CreditCardNumber = txtCreditCardNumber.Text;
                objcCard.CreditCardOwnerName = txtCardOwner.Text;
                objcCard.MerchantName = txtCreditCardCompany.Text;
                objcCard.ExpDate = Convert.ToDateTime(txtExpDate.Text);
                objcCard.AddressLine1 = txtAddressLine1.Text;
                objcCard.AddressLine2 = txtAddressLine2.Text;
                objcCard.City = txtCity.Text;
                objcCard.StateCode = txtState.Text;
                objcCard.ZipCode = txtZipcode.Text;
                objcCard.Country = txtCountry.Text;
                objcCard.CreditCardLimit = Convert.ToDecimal(txtCreditCardLimit.Text);
                objcCard.CreditCardBalance = Convert.ToDecimal(txtCreditCardBalance.Text);

                //Setting activation status in object
                bool activationStatus = Convert.ToBoolean(txtActivationStatus.Text);

                if (activationStatus == false)
                    objcCard.Deactivate();
                
                //Set Network_Printer.txt file with the CreditCard object data
                objcCard.Print();
                MessageBox.Show("The credit card has been sent to print successfully.");
            }
            else
            {
                MessageBox.Show("You must search for an existing credit card before printing.");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close this form
            //program flow automatically goes back to CreditCardMS Form
            //which opened this form aa a dialog form.
            this.Close();
        }
    }
}
