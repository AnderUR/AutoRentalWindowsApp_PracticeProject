using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZRentalBOLayer;

namespace EZRentalWindowsFormsApp
{
    public partial class frmCreditCardListForm : Form
    {
        public frmCreditCardListForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Return control to Credit Card management System form
            this.Close();
        }

        private void btnGetAllCreditCards_Click(object sender, EventArgs e)
        {
            //Set a list of CreditCard objects as the source for the DataGridView that will show a list of credit cards
            dgvCreditCardList.DataSource = CreditCard.GetAllCreditCards();
        }
    }
}
