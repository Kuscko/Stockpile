using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stockpile
{
    /*
     * Author: Patrick Kelly
     * Date Created: 11/18/2018
     * File name: frmRegister.class : form
     * Purpose:
     *      The purpose of this form is to provide the user with the means of creating a new account within our database and
     *      returns the dialog result OK, and opens the main form. Null otherwise and returns to the login form.
     */
    public partial class frmRegister : Form
    {

        public frmRegister()
        {
            InitializeComponent();
        }

        public Customer stockpile;

        /*
         * If True then calls the CreateUser Method and passes the textbox arguments.
         * If stockpile is returned as null then there is an issue with the database and the user is asked to contact an administrator using provided information.
         *          If it is not null however the dialog result is returned as OK and sends the information from the public Object stockpile to the private Object Stockpile on the main form.
         */
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                stockpile = CustomerDB.CreateUser(tboUserID, tboFirstName, tboLastName, tboEmail, tboPassword);
                if (stockpile == null)
                {
                    MessageBox.Show("Error on registration, please contact an administrator at (727) 364-4111 or patrick.kellyse@gmail.com.");
                    tboUserID.Focus();
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        // Terms of Service(tos) linked to form.
        private void linkTOS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegisterTOS tosForm = new frmRegisterTOS();
            DialogResult result = tosForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                chkTOS.Checked = true;
            }
        }

        // closes form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        // validates all objects.
        private bool isValidData()
        {
            return Data_Validation.IsPresent(tboEmail) &&
                   Data_Validation.isEmail(tboEmail) &&
                   Data_Validation.IsPresent(tboEmailConfirm) &&
                   Data_Validation.isEmail(tboEmailConfirm) &&
                   Data_Validation.isSame(tboEmail, tboEmailConfirm) &&
                   Data_Validation.IsPresent(tboFirstName) &&
                   Data_Validation.IsPresent(tboLastName) &&
                   Data_Validation.IsPresent(tboUserID) &&
                   Data_Validation.isUserID(tboUserID) &&
                   Data_Validation.IsPresent(tboPassword) &&
                   Data_Validation.IsPresent(tboPasswordConfirm) &&
                   Data_Validation.passwordComplexity(tboPassword) &&
                   Data_Validation.isSame(tboPassword, tboPasswordConfirm) &&
                   Data_Validation.tosAgreement(chkTOS);
        }

    }
}
