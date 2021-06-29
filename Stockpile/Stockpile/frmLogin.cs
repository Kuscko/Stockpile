using System;
using System.Windows.Forms;

namespace Stockpile
{
    public partial class frmLogin : Form
    {
        /*
         * Author: Patrick Kelly
         * Date Created: 11/12/2018
         * Date Updated: --/--/----
         * File name: Database_Connections.class
         * Purpose:
         *      \
         */
         
        
        public Customer stockpile;

        public frmLogin()
        {
            InitializeComponent();
        }
        // Password and Username Events

        private void frmPassword_TextChanged(object sender, EventArgs e)
        {
            Form_Operations.PasswordCasing(tboPassword);
        }

        private void tboLogin_Click(object sender, EventArgs e)
        {
            tboLogin.Text = "";
        }

        private void tboPassword_Click(object sender, EventArgs e)
        {
            tboPassword.Text = "";
        }

        private void clearControls()
        {
            tboLogin.Text = "";
            tboPassword.Text = "";
        }


        // Button Click Events
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                try
                {
                    stockpile = CustomerDB.GetCustomer(tboLogin, tboPassword);
                    if (stockpile == null)
                    {
                        MessageBox.Show("Please enter a valid UserID or Password!", "Entry Error");
                        clearControls();
                        tboLogin.Focus();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        /*
        * -------------------------------------------------------------------------------------------------------
        * 
        * Created: 11/28/2018 - By: Patrick Kelly
        * Updated: 11/29/2018
        * 
        *        This click event for the btnRegister object on the login form opens the Registration form as a
        *   DialogBox. If the DialogResult from the Registration form returns as OK then the Stockpile object on
        *   the registration form is returned and values assigned to the Stockpile object in this form. Then sets
        *   the forms DialogResult to OK to send the information the user entered and the database sent, back to
        *   the Main form.
        *        
        * -------------------------------------------------------------------------------------------------------
        */
        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister registrationFrom = new frmRegister();
            DialogResult result = registrationFrom.ShowDialog();
            if (result == DialogResult.OK)
            {
                stockpile = registrationFrom.stockpile;
                this.DialogResult = DialogResult.OK;
            }
        }

        // validates form data
        private bool IsValidData()
        {
            return Data_Validation.IsPresent(tboLogin) &&
                   Data_Validation.IsPresent(tboPassword);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
