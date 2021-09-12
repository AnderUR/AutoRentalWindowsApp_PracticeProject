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
    public partial class frmCreditCardDeleteForm : Form
    {
        public frmCreditCardDeleteForm()
        {
            InitializeComponent();
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

            //Use the CreditCard Delete() method to delete a record from database
            bool success = objcCard.Delete(txtCNumber.Text);
            if (success)
            {
                MessageBox.Show("The credit card was deleted successfully");
            }
            else
            {
                MessageBox.Show("The credit card number you entered does not exist.");
            }
        }
    }
}
