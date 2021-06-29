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
    public partial class frmProfile : Form
    {
        public Customer customer;
        private string userName;

        public frmProfile(string user)
        {
            InitializeComponent();
            userName = user;
        }

        private void backToMainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        // loads the user's information
        private void frmProfile_Load(object sender, EventArgs e)
        {
            try
            {
                customer = CustomerDB.GetCustomerInformation(userName);
                tboFullName.Text = customer.Fname + " " + customer.Lname;
                tboUserName.Text = customer.UserName;
                tboEmail.Text = customer.Email;
                if (customer.HomePhone != null)
                {
                    tboHomePhone.Text = customer.HomePhone;
                }
                if(customer.MobilePhone != null)
                {

                    tboMobilePhone.Text = customer.MobilePhone;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            
        }

        // Begins the editing of the user's information
        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You will not be able to change your password.", "Update Warning.", MessageBoxButtons.OK);
            btnSave.Visible = true;
            tboUserName.ReadOnly = false;
            tboFullName.ReadOnly = false;
            tboEmail.ReadOnly = false;
            tboHomePhone.ReadOnly = false;
            tboMobilePhone.ReadOnly = false;
            tboUserName.TabStop = true;
            tboFullName.TabStop = true;
            tboEmail.TabStop = true;
            tboHomePhone.TabStop = true;
            tboMobilePhone.TabStop = true;
        }

        // saves the edited profile information
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValidData())
                {
                    string fullName = tboFullName.Text.Trim();
                    string[] names = fullName.Split(' ');
                    string fName = names[0];
                    string lName = names[1];
                    customer = CustomerDB.EditCustomer(tboUserName, userName, fName, lName, tboEmail, tboHomePhone, tboMobilePhone);
                    btnSave.Visible = false;
                    tboUserName.ReadOnly = true;
                    tboFullName.ReadOnly = true;
                    tboEmail.ReadOnly = true;
                    tboHomePhone.ReadOnly = true;
                    tboMobilePhone.ReadOnly = true;
                    tboUserName.TabStop = false;
                    tboFullName.TabStop = false;
                    tboEmail.TabStop = false;
                    tboHomePhone.TabStop = false;
                    tboMobilePhone.TabStop = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        // validates form data
        private bool isValidData()
        {
            return Data_Validation.IsPresent(tboEmail) &&
                   Data_Validation.isEmail(tboEmail) &&
                   Data_Validation.IsPresent(tboEmail) &&
                   Data_Validation.IsPresent(tboFullName) &&
                   Data_Validation.IsPresent(tboHomePhone) &&
                   Data_Validation.IsPresent(tboMobilePhone);
        }
    }
}
