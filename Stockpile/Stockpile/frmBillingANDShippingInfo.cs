using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stockpile
{
    public partial class frmBillingANDShippingInfo : Form
    {
        public List<BillingInfo> billing;
        public List<ShippingInfo> shipping;
        public List<States> states;

        // Global Variables for Billing Options
        private string choice;
        private string date;
        private string cardNum;
        private string tax;
        private string[] cardTypes = {"American Express", "Discover Card", "MasterCard", "Visa"};
        
        // Global variables for both
        private string userID;
        private string newOrEdit;
        private string selectedState;

        public frmBillingANDShippingInfo(string formChoice, string user)
        {
            choice = formChoice;
            userID = user;
            InitializeComponent();
        }

        // loads all the information for the billing/shipping form.
        
        private void frmBillingANDShippingInfo_Load(object sender, EventArgs e)
        {
            List<States> statesIds = new List<States>();
            List<BillingInfo> billingInfo = new List<BillingInfo>();
            List<ShippingInfo> shippingInfo = new List<ShippingInfo>();
            // sets the default tab to whichever option the user selcted from the profile dropdown.
            try
            {
                if (choice == "billing")
                    {
                        tabControlBilling.SelectedTab = tabBilling;
                    }
                    else if (choice == "shipping")
                    {
                        tabControlBilling.SelectedTab = tabShipping;
                }

                // Line 58 to 94 populates each textbox with existing information.
                statesIds = BillingAndShippingInfoDB.GetStates();
                billingInfo = BillingAndShippingInfoDB.GetBillingInfo(userID);
                shippingInfo = BillingAndShippingInfoDB.GetShippingInformation(userID);

                if(statesIds.Count() != 0)
                {
                    for (int i = 0; i < statesIds.Count; i++)
                    {
                        States state = statesIds[i];
                        cboBillingStates.Items.Add(state.StateName);
                        cboShippingStates.Items.Add(state.StateName);
                    }
                }
                
                if(billingInfo.Count != 0)
                {
                    for (int i = 0; i < billingInfo.Count; i++)
                    {
                        BillingInfo billingI = billingInfo[i];
                        cboBillingOptions.Items.Add("Billing option with address.." + billingI.BillingAddr1);
                    }
                }
            
                if(shippingInfo.Count != 0)
                {
                    for (int i = 0; i < shippingInfo.Count; i++)
                    {
                        ShippingInfo shippingI = shippingInfo[i];
                        cboShippingOptions.Items.Add("Shipping option with address.." + shippingI.ShippingAddr1);
                    }
                }

                foreach(string item in cardTypes)
                {
                    cboCardType.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            billing = billingInfo;
            shipping = shippingInfo;
            states = statesIds;

            cboBillingOptions.SelectedIndex = 0;
            cboBillingStates.SelectedIndex = 0;
            cboShippingStates.SelectedIndex = 0;
            cboShippingOptions.SelectedIndex = 0;
        }
        
        // Billing Information Methods
        
        // New Billing information
        private void btnNewBilling_Click(object sender, EventArgs e)
        {
            // sets the newOrEdit variable to new
            newOrEdit = "new";

            // modifies the form controls for the purpose of creating a new billing method.
            btnSaveBilling.Visible = true;
            btnEditBilling.Enabled = false;
            cboBillingOptions.Enabled = false;
            cboCardType.Visible = true;
            cboBillingStates.Visible = true;
            tboBillingState.Visible = false;
            tboCardType.Visible = false;

            tboCardNumber.ReadOnly = false;
            tboExpirationDate.ReadOnly = false;
            tboSecurityCard.ReadOnly = false;
            tboBillingAddr.ReadOnly = false;
            tboBillingAddrO.ReadOnly = false;
            tboBillingCity.ReadOnly = false;
            tboBillingZipcode.ReadOnly = false;

            tboCardNumber.Text = "";
            tboExpirationDate.Text = "";
            tboSecurityCard.Text = "";
            tboCardType.Text = "";
            tboBillingAddr.Text = "";
            tboBillingAddrO.Text = "";
            tboBillingCity.Text = "";
            tboBillingZipcode.Text = "";

            btnSaveBilling.TabStop = true;
            cboCardType.TabStop = true;
            cboBillingStates.TabStop = true;
            tboCardNumber.TabStop = true;
            tboExpirationDate.TabStop = true;
            tboSecurityCard.TabStop = true;
            tboBillingAddr.TabStop = true;
            tboBillingAddrO.TabStop = true;
            tboBillingCity.TabStop = true;
            tboBillingZipcode.TabStop = true;
        }
        
        // Edit billing information
        private void btnEditBilling_Click(object sender, EventArgs e)
        {
            // checks to see if the user has selected a billing option to edit.
            if(cboBillingOptions.SelectedIndex != 0)
            {
                // sets the newOrEdit variable to edit
                newOrEdit = "edit";

                // modifies the form controls for the purpose of creating a editing the selected billing method.
                btnNewBilling.Enabled = false;
                btnSaveBilling.Visible = true;
                cboBillingOptions.Enabled = false;
                cboBillingStates.Visible = true;
                tboBillingState.Visible = false;
                
                tboBillingAddr.ReadOnly = false;
                tboBillingAddrO.ReadOnly = false;
                tboBillingCity.ReadOnly = false;
                tboBillingZipcode.ReadOnly = false;

                btnSaveBilling.TabStop = true;
                cboBillingStates.TabStop = true;
                tboBillingAddr.TabStop = true;
                tboBillingAddrO.TabStop = true;
                tboBillingCity.TabStop = true;
                tboBillingZipcode.TabStop = true;
            }
            else
            {
                // if the user didn't select a method then this messagebox appears.
                MessageBox.Show("Please select a billing option to edit.", "Entry Error");
                cboBillingOptions.Focus();
            }
        }

        // Save billing INformation
        private void btnSaveBilling_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (newOrEdit == "new")
                {
                    // validates each form control
                    if (IsNewBillingValidData())
                    {
                        // declares the BillingInfo object so that the form can populate controls after the user creates a new billing option.
                        List<BillingInfo> billingInfo = new List<BillingInfo>();

                        // replaces the / and - characters from the date variable and cardnumber
                        date = expiredReplaceString();
                        cardNum = cardNumReplaceString();

                        // creates the billing inforramtion.
                        BillingAndShippingInfoDB.CreatBillingInfo(cboCardType.SelectedItem.ToString(), tax, userID, selectedState, cardNum, date, tboSecurityCard, tboBillingAddr, tboBillingAddrO, tboBillingCity, tboBillingZipcode);

                        // gets all the user's billing information options and populates a combobox with the necessary information
                        billingInfo = BillingAndShippingInfoDB.GetBillingInfo(userID);
                        cboBillingOptions.Items.Clear();
                        cboBillingOptions.Items.Add("Select Billing Option...");
                        if (billingInfo.Count != 0)
                        {
                            for (int i = 0; i < billingInfo.Count; i++)
                            {
                                BillingInfo billingI = billingInfo[i];
                                cboBillingOptions.Items.Add("Billing option with address.." + billingI.BillingAddr1);
                            }
                        }
                        billing = billingInfo;
                        resetNewBillingControls();
                    }
                }
                else if (newOrEdit == "edit")
                {
                    // Validates form objects
                    if (IsEditBillingValidData())
                    {
                        // declares the BillingInfo object so that the form can populate controls after the user creates a new billing option.
                        List<BillingInfo> billingInfo = new List<BillingInfo>();

                        // replaces the / and - characters from the date variable and cardnumber
                        date = expiredReplaceString();
                        cardNum = cardNumReplaceString();

                        // updates the billing inforramtion.
                        BillingAndShippingInfoDB.UpdateBillingInfo(tboCardType, tax, userID, selectedState, cardNum, date, tboSecurityCard, tboBillingAddr, tboBillingAddrO, tboBillingCity, tboBillingZipcode);

                        // gets all the user's billing information options and populates a combobox with the necessary information
                        billingInfo = BillingAndShippingInfoDB.GetBillingInfo(userID);
                        cboBillingOptions.Items.Clear();
                        cboBillingOptions.Items.Add("Select Billing Option...");
                        if (billingInfo.Count != 0)
                        {
                            for (int i = 0; i < billingInfo.Count; i++)
                            {
                                BillingInfo billingI = billingInfo[i];
                                cboBillingOptions.Items.Add("Billing option with address.." + billingI.BillingAddr1);
                            }
                        }
                        billing = billingInfo;
                        resetEditBillingControls();
                    }
                }
                
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
        }
       
        // populates the billing form controls when the user selects a different object in the billingInformation combobox
        private void cboBillingOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get the index of the combobox
            int index = cboBillingOptions.SelectedIndex;

            // if the user selected somthing then populate the form controls
            if(index != 0)
            {
                BillingInfo billingInfo = billing[index-1];
                tboCardType.Text = billingInfo.CardType;
                tboCardNumber.Text = billingInfo.CardNumber;
                tboExpirationDate.Text = billingInfo.ExpirationDate;
                tboSecurityCard.Text = billingInfo.SecurityCode;
                tboBillingAddr.Text = billingInfo.BillingAddr1;
                tboBillingAddrO.Text = billingInfo.BillingAddr2;
                tboBillingCity.Text = billingInfo.City;
                foreach (States state in states)
                {
                    if (billingInfo.State == state.StateID)
                    {
                        tboBillingState.Text = state.StateName;
                        break;
                    }
                }
                tboBillingZipcode.Text = billingInfo.ZipCode;
            } // Otherwise clear the controls if the user selected the default value(no option)
            else
            {
                tboCardType.Text = "";
                tboCardNumber.Text = "";
                tboExpirationDate.Text = "";
                tboSecurityCard.Text = "";
                tboBillingAddr.Text = "";
                tboBillingAddrO.Text = "";
                tboBillingCity.Text = "";
                tboBillingState.Text = "";
                tboBillingZipcode.Text = "";
            }
        }

        private void cboBillingStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            // sets the global tax variable and selected state variable 
            int index = cboBillingStates.SelectedIndex;
            States state = states[index];
            tax = state.StateTax;
            selectedState = state.StateID;
        }

        // changes the maximum amount of characters that can go in the security box information based on the card selection
        private void cboCardType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboCardType.SelectedIndex;
            if (index == 0)
            {
                tboSecurityCard.MaxLength = 4;
            }
            else
            {
                tboSecurityCard.MaxLength = 3;

            }
        }

        // changes the cardtype combobox based on the first character of the card number
        private void tboCardNumber_KeyDown(object sender, KeyEventArgs e)
        {
            string firstChar = tboCardNumber.Text.Substring(0, 1);
            if (firstChar == "3")
            {
                cboCardType.SelectedIndex = 0;
            }
            else if (firstChar == "6")
            {
                cboCardType.SelectedIndex = 1;
            }
            else if (firstChar == "5")
            {
                cboCardType.SelectedIndex = 2;
            }
            else if (firstChar == "4")
            {
                cboCardType.SelectedIndex = 3;
            }
        }

        // replaces the / character in the expiration date.
        private string expiredReplaceString()
        {
            string datestring = tboExpirationDate.Text.Replace("/", "");
            return datestring;
        }

        // replaces the - cahractesr in the card numbers
        private string cardNumReplaceString()
        {
            string cardNum = tboCardNumber.Text.Replace("-", "");
            return cardNum;
        }

        // reset the forms to their native settings
        private void resetNewBillingControls()
        {
            cboBillingOptions.SelectedIndex = 0;

            btnEditBilling.Enabled = true;
            btnSaveBilling.Visible = false;
            cboBillingOptions.Enabled = true;
            cboBillingStates.Visible = false;
            tboBillingState.Visible = true;
            cboCardType.Visible = false;
            tboCardType.Visible = true;

            tboExpirationDate.ReadOnly = true;
            tboSecurityCard.ReadOnly = true;
            tboCardNumber.ReadOnly = true;
            tboBillingAddr.ReadOnly = true;
            tboBillingAddrO.ReadOnly = true;
            tboBillingCity.ReadOnly = true;
            tboBillingZipcode.ReadOnly = true;

            btnSaveBilling.TabStop = false;
            cboBillingStates.TabStop = false;
            tboBillingAddr.TabStop = false;
            tboBillingAddrO.TabStop = false;
            tboBillingCity.TabStop = false;
            tboBillingZipcode.TabStop = false;

            tboBillingAddr.Text = "";
            tboBillingAddrO.Text = "";
            tboBillingCity.Text = "";
            tboBillingZipcode.Text = "";
            tboCardNumber.Text = "";
            tboExpirationDate.Text = "";
            tboSecurityCard.Text = "";

        }

        private void resetEditBillingControls()
        {
            cboBillingOptions.SelectedIndex = 0;

            btnSaveBilling.Visible = false;
            cboBillingOptions.Enabled = true;
            cboCardType.Visible = false;
            cboBillingStates.Visible = false;
            tboBillingState.Visible = true;

            tboCardNumber.ReadOnly = true;
            tboExpirationDate.ReadOnly = true;
            tboSecurityCard.ReadOnly = true;
            tboBillingAddr.ReadOnly = true;
            tboBillingAddrO.ReadOnly = true;
            tboBillingCity.ReadOnly = true;
            tboBillingZipcode.ReadOnly = true;

            tboCardNumber.Text = "";
            tboExpirationDate.Text = "";
            tboSecurityCard.Text = "";
            tboBillingAddr.Text = "";
            tboBillingAddrO.Text = "";
            tboBillingCity.Text = "";
            tboBillingZipcode.Text = "";

            btnSaveBilling.TabStop = false;
            cboCardType.TabStop = false;
            cboBillingStates.TabStop = false;
            tboCardNumber.TabStop = false;
            tboExpirationDate.TabStop = false;
            tboSecurityCard.TabStop = false;
            tboBillingAddr.TabStop = false;
            tboBillingAddrO.TabStop = false;
            tboBillingCity.TabStop = false;
            tboBillingZipcode.TabStop = false;
        }

        // billing control form validations
        private bool IsNewBillingValidData()
        {
            return Data_Validation.selectedComboBoxIndex(cboBillingStates) &&
                   Data_Validation.selectedComboBoxIndex(cboCardType) &&
                   Data_Validation.IsPresent(tboSecurityCard) &&
                   Data_Validation.IsPresent(tboBillingAddr) &&
                   Data_Validation.IsPresent(tboBillingCity) &&
                   Data_Validation.IsPresentMaskBox(tboBillingZipcode) &&
                   Data_Validation.IsPresentMaskBox(tboCardNumber) &&
                   Data_Validation.IsPresentMaskBox(tboExpirationDate);
        }

        private bool IsEditBillingValidData()
        {
            return Data_Validation.selectedComboBoxIndex(cboBillingStates) &&
                   Data_Validation.IsPresent(tboBillingAddr) &&
                   Data_Validation.IsPresent(tboBillingCity) &&
                   Data_Validation.IsPresentMaskBox(tboBillingZipcode);
        }


        // Shipping Information Methods
        private void cboShippingOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboShippingOptions.SelectedIndex;
            if (index != 0)
            {
                ShippingInfo shippingInfo = shipping[index - 1];
                tboShippingAdr.Text = shippingInfo.ShippingAddr1;
                tboShippingAddrO.Text = shippingInfo.ShippingAddr2;
                tboCityShipping.Text = shippingInfo.City;
                foreach (States state in states)
                {
                    if (shippingInfo.State == state.StateID)
                    {
                        tboStateShipping.Text = state.StateName;
                        break;
                    }
                }
                tboShippingZipcode.Text = shippingInfo.ZipCode;
            }
            else
            {
                tboShippingAdr.Text = "";
                tboShippingAddrO.Text = "";
                tboCityShipping.Text = "";
                tboStateShipping.Text = "";
                tboShippingZipcode.Text = "";
            }
        }

        // sets the state id based on use selection of the state selected combobox in shipping.
        private void cboShippingStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboShippingStates.SelectedIndex;
            States state = states[index];
            selectedState = state.StateID;
        }

        // new shipping information
        private void btnNewShipping_Click(object sender, EventArgs e)
        {
            // sets the newOrEdit variable to new
            newOrEdit = "new";

            // modifies the form controls for the purpose of creating a new shipping method.

            btnSaveShipping.Visible = true;
            btnEditShipping.Enabled = false;
            cboShippingOptions.Enabled = false;
            cboShippingStates.Visible = true;
            tboStateShipping.Visible = false;

            tboShippingAdr.ReadOnly = false;
            tboShippingAddrO.ReadOnly = false;
            tboCityShipping.ReadOnly = false;
            tboShippingZipcode.ReadOnly = false;

            tboShippingAdr.Text = "";
            tboShippingAddrO.Text = "";
            tboShippingZipcode.Text = "";
            tboCityShipping.Text = "";
            tboStateShipping.Text = "";

            btnSaveShipping.TabStop = true;
            cboShippingStates.TabStop = true;
            tboShippingAdr.TabStop = true;
            tboShippingAddrO.TabStop = true;
            tboCityShipping.TabStop = true;
            tboShippingZipcode.TabStop = true;
        }

        // edit shipping information
        private void btnEditShipping_Click(object sender, EventArgs e)
        {
            // checks to see if the user has selected a billing option to edit.
            if (cboShippingOptions.SelectedIndex != 0)
            {
                // sets the newOrEdit variable to edit
                newOrEdit = "edit";

                // modifies the form controls for the purpose of creating a editing the selected shipping method.

                btnNewShipping.Enabled = false;
                btnSaveShipping.Visible = true;
                cboShippingOptions.Enabled = false;
                cboShippingStates.Visible = true;
                tboStateShipping.Visible = false;

                tboShippingAdr.ReadOnly = false;
                tboShippingAddrO.ReadOnly = false;
                tboCityShipping.ReadOnly = false;
                tboShippingZipcode.ReadOnly = false;

                btnSaveShipping.TabStop = true;
                cboShippingStates.TabStop = true;
                tboShippingAdr.TabStop = true;
                tboShippingAddrO.TabStop = true;
                tboCityShipping.TabStop = true;
                tboShippingZipcode.TabStop = true;
            } 
            else
            {
                MessageBox.Show("Please select a shipping option to edit.");
                cboShippingOptions.Focus();
            }
        }

        // This is the same as the btnSaveBilling_Click Method
        private void btnSaveShipping_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (newOrEdit == "new")
                {
                    if (IsShippingValidData())
                    {
                        List<ShippingInfo> shippingInfo = new List<ShippingInfo>();
                        BillingAndShippingInfoDB.CreateShippingInfo(userID, selectedState, tboShippingAdr, tboShippingAddrO, tboCityShipping, tboShippingZipcode);
                        shippingInfo = BillingAndShippingInfoDB.GetShippingInformation(userID);
                        shipping = shippingInfo;
                        cboShippingOptions.Items.Clear();
                        cboShippingOptions.Items.Add("Select Shipping Option...");
                        if (shippingInfo.Count != 0)
                        {
                            for (int i = 0; i < shippingInfo.Count; i++)
                            {
                                ShippingInfo shippingI = shippingInfo[i];
                                cboShippingOptions.Items.Add("Shipping option with address.." + shippingI.ShippingAddr1);
                            }
                        }
                        resetNewShippingControls();
                    }
                }
                else if (newOrEdit == "edit")
                {
                    if (IsShippingValidData())
                    {
                        List<ShippingInfo> shippingInfo = new List<ShippingInfo>();

                        // get the index of the selcted item in the Shipping options combo box to assign a seperate string  variable of the ShippingAddr1
                        int index = cboShippingOptions.SelectedIndex;
                        ShippingInfo sInfo = shipping[index-1];
                        string addr = sInfo.ShippingAddr1;

                        // using the string variable addr above we then call the UpdateShippingInfo method fo the BillingAndShippingDB.class document.
                        // It allows us to change the shipping address by filtering through the tables and getting the unique shipping address that was there
                        // before the change.

                        BillingAndShippingInfoDB.UpdateShippingInfo(selectedState, addr, tboShippingAdr, tboShippingAddrO, tboCityShipping, tboShippingZipcode);

                        // This code bellow repopulates the combobox with the updated Shipping Information.
                        shippingInfo = BillingAndShippingInfoDB.GetShippingInformation(userID);
                        shipping = shippingInfo;
                        cboShippingOptions.Items.Clear();
                        cboShippingOptions.Items.Add("Select Shipping Option...");
                        if (shippingInfo.Count != 0)
                        {
                            for (int i = 0; i < shippingInfo.Count; i++)
                            {
                                ShippingInfo shippingI = shippingInfo[i];
                                cboShippingOptions.Items.Add("Shipping option with address.." + shippingI.ShippingAddr1);
                            }
                        }

                        resetEditShippingControls();
                    }
                }
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
        }


        // Shipping Data validation
        private bool IsShippingValidData()
        {
            return Data_Validation.IsPresent(tboShippingAdr) &&
                   Data_Validation.IsPresent(tboCityShipping) &&
                   Data_Validation.selectedComboBoxIndex(cboShippingStates) &&
                   Data_Validation.IsPresentMaskBox(tboShippingZipcode);
        }

        // Methods to call so that the program resets each control to their native values, before the edit button or save button was pressed.
        private void resetNewShippingControls()
        {
            cboShippingOptions.SelectedIndex = 0;

            btnSaveShipping.Visible = false;
            btnEditShipping.Enabled = true;
            cboShippingOptions.Enabled = true;
            cboShippingStates.Visible = false;
            tboStateShipping.Visible = true;

            tboShippingAdr.ReadOnly = true;
            tboShippingAddrO.ReadOnly = true;
            tboCityShipping.ReadOnly = true;
            tboShippingZipcode.ReadOnly = true;

            tboShippingAdr.Text = "";
            tboShippingAddrO.Text = "";
            tboShippingZipcode.Text = "";
            tboCityShipping.Text = "";
            tboStateShipping.Text = "";

            btnSaveShipping.TabStop = false;
            cboShippingStates.TabStop = false;
            tboShippingAdr.TabStop = false;
            tboShippingAddrO.TabStop = false;
            tboCityShipping.TabStop = false;
            tboShippingZipcode.TabStop = false;
        }

        private void resetEditShippingControls()
        {
            cboShippingOptions.SelectedIndex = 0;

            btnNewShipping.Enabled = true;
            btnSaveShipping.Visible = false;
            btnNewShipping.Enabled = true;
            cboShippingOptions.Enabled = true;
            cboShippingStates.Visible = false;
            tboStateShipping.Visible = true;

            tboShippingAdr.ReadOnly = true;
            tboShippingAddrO.ReadOnly = true;
            tboCityShipping.ReadOnly = true;
            tboShippingZipcode.ReadOnly = true;

            tboShippingAdr.Text = "";
            tboShippingAddrO.Text = "";
            tboCityShipping.Text = "";
            tboBillingZipcode.Text = "";

            btnSaveShipping.TabStop = false;
            cboShippingStates.TabStop = false;
            tboShippingAdr.TabStop = false;
            tboShippingAddrO.TabStop = false;
            tboCityShipping.TabStop = false;
            tboShippingZipcode.TabStop = false;
        }

        // closes the form and returns dialog result OK
        private void backToMainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            this.DialogResult = DialogResult.OK;
        }

        
    }
 }
