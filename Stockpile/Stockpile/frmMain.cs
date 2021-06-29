using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Resources;
using System.Drawing;

namespace Stockpile
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // userID is meant for getting information on load.
        private Customer customer;
        private List<Products> products;
        private List<Wishlists> wishlists;
        private List<BillingInfo> billing;
        private List<ShippingInfo> shipping;
        private List<States> states;
        //private List<string> shoppingCart;


        private decimal itemPrice;
        private decimal tax;
        private decimal total;
        private decimal stateTax;
        private decimal subtotal;

        private string wishlistName;
        private string billingOrShipping;


        private void frmMain_Load(object sender, EventArgs e)
        {
            // log into the program.
            login();
        }

        // populates the Customer field on login.

        /*
         * -------------------------------------------------------------------------------------------------------
         * 
         * Created: 11/28/2018 - By: Patrick Kelly
         * Updated: --/--/----
         * 
         * Login fix:
         *      Load main form as Startup Object. 
         *  In load event hide the main form, load the login form frmLogin and display as a dialog box, validate
         *  login information and then send user data to main form.
         *  updates the UserID ToolStripMenuItem with the userID. Work from here.
         *        
         * -------------------------------------------------------------------------------------------------------
         */
        private void login()
        {
            Hide();
            frmLogin loginForm = new frmLogin();
            DialogResult result = loginForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                // declares a local instance of the list<billing&shipping> objects
                List<BillingInfo> billingInfo = new List<BillingInfo>();
                List<ShippingInfo> shippingInfo = new List<ShippingInfo>();

                this.customer = loginForm.stockpile;
                Show();
                userIDToolStripMenuItem.Text = this.customer.UserName;

                // redirect information between the queries and lists.
                states = BillingAndShippingInfoDB.GetStates();
                billingInfo = BillingAndShippingInfoDB.GetBillingInfo(customer.UserName);
                shippingInfo = BillingAndShippingInfoDB.GetShippingInformation(customer.UserName);
                
                // re-assign information to the list<class objects>
                billing = billingInfo;
                shipping = shippingInfo;

                // populates the billing and shipping information comboboxes
                if (billingInfo.Count != 0)
                {
                    for (int i = 0; i < billingInfo.Count; i++)
                    {
                        BillingInfo billingI = billingInfo[i];
                        cboBillingOptions.Items.Add("Billing option with address.." + billingI.BillingAddr1);
                    }
                }

                if (shippingInfo.Count != 0)
                {
                    for (int i = 0; i < shippingInfo.Count; i++)
                    {
                        ShippingInfo shippingI = shippingInfo[i];
                        cboShippingOptions.Items.Add("Shipping option with address.." + shippingI.ShippingAddr1);
                    }
                }

                // sets categoryies to 0 on load.
                cboCategory.SelectedIndex = 0;
                cboBillingOptions.SelectedIndex = 0;
                cboShippingOptions.SelectedIndex = 0;
                toolStripComboBoxWishList.SelectedIndex = 0;
            }
            else if (result == DialogResult.Cancel)
            {
                Close();
            }
        }  

        // EVENT LISTENER METHODS

        /*
         * -------------------------------------------------------------------------------------------------------
         * 
         * Created: 11/30/2018 - By: Patrick Kelly
         * 
         *        This IndexChanged Event gets the selected value of the cboCategory, then uses if conditional
         *  statements to check which object was selected, when the object selected is determined the method calls
         *  the FilterbyCategory() method that uses the property type that was assigned before. It returns the
         *  Product class object for the mainForm to manipulate.
         *        
         * -------------------------------------------------------------------------------------------------------
         */
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboCategory.SelectedIndex;
            string type;
            if(index == 0)
            {
                clearProducts();
                populateProducts();
            }
            else
            {
                clearProducts();
                if (index == 1)
                {
                    type = "Aluminum";
                    products = ProductsDB.FilterByCategory(type);
                }
                else if (index == 2)
                {
                    type = "Clay";
                    products = ProductsDB.FilterByCategory(type);
                }
                else if (index == 3)
                {
                    type = "Concrete";
                    products = ProductsDB.FilterByCategory(type);
                }
                else if (index == 4)
                {
                    type = "Fiberglass";
                    products = ProductsDB.FilterByCategory(type);
                }
                else if (index == 5)
                {
                    type = "Glass";
                    products = ProductsDB.FilterByCategory(type);
                }
                else if (index == 6)
                {
                    type = "Plaster";
                    products = ProductsDB.FilterByCategory(type);
                }
                repopulateProducts();
            }
            
        }

        /*
         * -------------------------------------------------------------------------------------------------------
         * 
         * Created: 11/29/2018 - By: Patrick Kelly
         * 
         *        This click event handler activates when the user clicks the btnFilter. It filters through the
         * CURRENT LIST, by stepping backwards through the List, removing items that do not meet the requirements
         * of a minimum price and maximum price desired.  
         *    
         * -------------------------------------------------------------------------------------------------------
         */
        private void btnFilter_Click(object sender, EventArgs e)
        {
            lbxProductLists.Items.Clear();
            decimal low = Convert.ToDecimal(tboLowestDesired.Text);
            decimal high = Convert.ToDecimal(tboHighestDesired.Text);
            // start at the end of the list.
            for(int i = products.Count - 1; i >= 0; i--)
            {
                // assign products[index] within the listbox and assigns this to the Product Object, this way the 
                // Products class can define the correct price and run the conditional statement below.
                Products product = products[i];
                if(product.Price < low || product.Price > high)
                {
                    products.RemoveAt(i);
                }
            }
            foreach (Products p in products)
            {
                lbxProductLists.Items.Add(p.productFormat());
            }
            SetListBoxTabs(lbxProductLists, new int[] { 50, 100, 200 });
        }

        /*
         * -------------------------------------------------------------------------------------------------------
         * 
         * Created: 12/31/2018 - By: Patrick Kelly
         * 
         *        This Text Changed event filters the databse by item name, based on user's imput.
         *  This is done by first cleareing the listbox of any items so that there are no duplicates when
         *  this event executes. Then we assign the Products object products the method of SearchFilter from
         *  ProductsDB class, with the parameter of the tboSearch object.
         *  
         *  On return a foreach loop activates and ouputs and formats the information in the listBox.
         *        
         * -------------------------------------------------------------------------------------------------------
         */
        private void tboSearch_TextChanged(object sender, EventArgs e)
        {
            lbxProductLists.Items.Clear();
            products = ProductsDB.SearchFilter(tboSearch);
            foreach (Products p in products)
            {
                lbxProductLists.Items.Add(p.productFormat());
            }
            SetListBoxTabs(lbxProductLists, new int[] { 50, 100, 200 });
        }

        /*
         * -------------------------------------------------------------------------------------------------------
         * 
         * Created: 12/1/2018 - By: Patrick Kelly
         *
         *        This method displays both the product description and the product photo.
         *        First I had to find a way to display the images of each product, this was difficult considering
         *  access doesn't pass the actual photo but just it's name. So I had to import all the photos I use to the
         *  Resources.resx file/folder. I did this by clicking on Properties, then doubleclicking Resources.resx to
         *  open its manager. I then inserted everysingle image into the resx file/resource folder. 
         *  
         *       Then in order to access this file I had to use a localization string for my file path(wherever 
         *  this method is executing from), then we declare a Product product object and assign the index product[index].
         *  This allows us to pull whatever ifnormation we want from the selected product in the listBox using the
         *  Product class properties. We then substring the product.Picture() to rememove the file extension and we're
         *  only left with the file name. 
         *  
         *  Finally declaring where this resourcefile is by using ResourceSet() we can set the image of the picProduct
         *  object by using the resxSet.GetObject() method that takes the productName variable we parsed.
         *        
         * -------------------------------------------------------------------------------------------------------
         */
        private void lbxProductLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string resxFile = @".\Properties\Resources.resx";
                int index = lbxProductLists.SelectedIndex;
                Products product = products[index];
                string productName = product.Picture.Substring(0, product.Picture.Length - 4);
                using (ResXResourceSet resxSet = new ResXResourceSet(resxFile))
                {
                    picProduct.Image = (Image)resxSet.GetObject(productName);
                }
                tboDescription.Text = "\t" + product.Description;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // This selectedIndexChanged Event gets the state from the billing information and assigns  a state tax based off that state.
        // It also clears out the shopping cart and output.
        private void cboBillingOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int index = cboBillingOptions.SelectedIndex;
            if(index != 0)
            {
                lbxOrderAmount.Items.Clear();
                lbxShoppingList.Items.Clear();
                itemPrice = 0m;
                tax = 0m;
                total = 0m;
                stateTax = 0m;
                subtotal = 0m;
                BillingInfo billingInfo = billing[index-1];
                foreach (States state in states)
                {
                    if (billingInfo.State == state.StateID)
                    {
                        stateTax = Convert.ToDecimal(state.StateTax);
                        break;
                    }
                }
                lbxOrderAmount.Items.Add("Subtotal: " + subtotal.ToString("C"));
                lbxOrderAmount.Items.Add("Tax: " + tax.ToString("C"));
                lbxOrderAmount.Items.Add("Total: " + total.ToString("C"));
            }
            
        }

        /*
         * -------------------------------------------------------------------------------------------------------
         * 
         * Created: 12/02/2018 - By: Patrick Kelly
         *
         *        This click event gets the index of the product selected in the lbxProductList object and assigns
         *  it to a Product class object. It then calculates the subtotal, tax (based on user's billing state), and
         *  total. It then looks at the length of the product name that's selected and depending on that length it
         *  sets an appropriate SpacingBoxtabs for that item in the ListBox Object.
         *  
         *  Then it clears the orderamount listbox and outputs the subtotal, tax, and total.
         *        
         * -------------------------------------------------------------------------------------------------------
         */
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if(cboBillingOptions.SelectedIndex != 0 || cboShippingOptions.SelectedIndex != 0)
            {
                int index = lbxProductLists.SelectedIndex;
                int count = lbxShoppingList.Items.Count;
                int ordered = (int)numUDItemAmount.Value;
                Products product = products[index];

                // Calculations for Total
                itemPrice = product.Price * ordered;
                subtotal = subtotal + itemPrice;
                tax = subtotal * stateTax;
                total = subtotal + tax;

                if (product.Name.Length < 11)
                {
                    lbxShoppingList.Items.Add(product.Name + "\t" + ordered.ToString() + "\t" + product.Price.ToString("C"));
                    SetListBoxTabs(lbxShoppingList, new int[] { 100, 10 });
                }
                else if (product.Name.Length > 11)
                {
                    lbxShoppingList.Items.Add(product.Name + "\t" + ordered.ToString() + "\t" + product.Price.ToString("C"));
                    SetListBoxTabs(lbxShoppingList, new int[] { 0, 1 });
                }
                else
                {
                    lbxShoppingList.Items.Add(product.Name + "\t" + ordered.ToString() + "\t" + product.Price.ToString("C"));
                    SetListBoxTabs(lbxShoppingList, new int[] { 100, 10 });
                }


                lbxOrderAmount.Items.Clear();
                lbxOrderAmount.Items.Add("Subtotal: " + subtotal.ToString("C"));
                lbxOrderAmount.Items.Add("Tax: " + tax.ToString("C"));
                lbxOrderAmount.Items.Add("Total: " + total.ToString("C"));
            }
            else
            {
                MessageBox.Show("Please select a billing and shipping option!", "Entry Error");
            }
            
            
        }

        // Recurring Methods - Ones I use often.
        /*
         * -------------------------------------------------------------------------------------------------------
         * 
         * Created: 12/1/2018 - By: Patrick Kelly
         *
         *        When the user signs out of the program all the controls are reset to their native values.
         *        
         * -------------------------------------------------------------------------------------------------------
         */
        private void resetControls()
        {
            cboCategory.SelectedIndex = 0;
            toolStripComboBoxWishList.SelectedIndex = 0;
            itemPrice = 0m;
            tax = 0m;
            total = 0m;
            stateTax = 0m;
            subtotal = 0m;
            tboDescription.Text = "";
            tboHighestDesired.Text = "";
            tboLowestDesired.Text = "";
            tboSearch.Text = "";
            numUDItemAmount.Value = 1;
            chkSameAs.Checked = false;
            lblCartCount.Visible = false;
            lblCartCount.Text = "#";
            lbxShoppingList.Items.Clear();
            lbxOrderAmount.Items.Clear();
            cboBillingOptions.Items.Clear();
            cboShippingOptions.Items.Clear();
            cboBillingOptions.Items.Add("Select Billing Option...");
            cboShippingOptions.Items.Add("Select Shipping Option...");
            picProduct.Image = null;
        }

        /*
         * -------------------------------------------------------------------------------------------------------
         * 
         * Created: 12/1/2018 - By: Patrick Kelly
         *
         *        When the user signs out of the program all the controls are reset to their native values.
         * 
         * -------------------------------------------------------------------------------------------------------
         */
        private void clearProducts()
        {
            lbxProductLists.Items.Clear();
            tboDescription.Text = "";
            picProduct.InitialImage = null;
        }

        /*
         * -------------------------------------------------------------------------------------------------------
         * 
         * Created: 11/28/2018 - By: Patrick Kelly
         * Updated: --/--/----
         * 
         *        Populate each control with corresponding information (required).
         *        
         * -------------------------------------------------------------------------------------------------------
         */
        private void populateProducts()
        {
            products = ProductsDB.GetProducts();
            repopulateProducts();
        }

        /*
         * -------------------------------------------------------------------------------------------------------
         * 
         * Created: 12/1/2018 - By: Patrick Kelly
         *
         *      Outputs all products inside the Products List Object.           
         *  
         * -------------------------------------------------------------------------------------------------------
         */
        private void repopulateProducts()
        {
            foreach (Products p in products)
            {
                lbxProductLists.Items.Add(p.productFormat());
            }
            SetListBoxTabs(lbxProductLists, new int[] { 50, 100, 200 });
        }

        /*
         * -------------------------------------------------------------------------------------------------------
         * 
         * Created: 11/29/2018 - By: Patrick Kelly
         * Updated: --/--/----
         * 
         *        formats the products listbox with custom tab stops    
         *           
         * -------------------------------------------------------------------------------------------------------
         */
        private void SetListBoxTabs(ListBox listBox, IEnumerable<int> tabs)
        {
            // Make sure the controls will use the tabstops
            listBox.UseTabStops = true;
            listBox.UseCustomTabOffsets = true;

            // Get a collection fo TabOffsets (\t) within each object.
            ListBox.IntegerCollection offsets = listBox.CustomTabOffsets;

            // Defines the tabs for each item in the list.
            foreach (int tab in tabs)
            {
                offsets.Add(tab);
            }
        }

        // Tool Strip Methods()

        /*
         * -------------------------------------------------------------------------------------------------------
         * 
         * Created: 11/18/2018 - By: Patrick Kelly
         * Updated: 12/1/2018
         *
         *        Displays a messagebox with a yes or no statement, returns the dialog results YES/NO on click.
         *  If the user clicks YES, the form closes, if the user clicks NO nothing happens.
         *  
         *  Update Notes: 12/1/2018
         *      Created a messagebox that returns a Dialogresult that returns Yes if the user wants to logout.
         *      It does nothing otherwise.
         * -------------------------------------------------------------------------------------------------------
         */
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                resetControls();
                login();
            } 
        }

        // Save the shopping list as a wishlist.
        // THIS METHOD IS DISABLED
        private void btnSave_Click(object sender, EventArgs e)
        {
            frmWishListNameDialog name = new frmWishListNameDialog();
            DialogResult result = name.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.wishlistName = name.wishlistName;
                this.wishlists = WishlistsDB.CreateWishlistItem(customer.UserName, wishlistName);
                foreach(var item in wishlists)
                {
                    toolStripComboBoxWishList.Items.Add(item.ListName);
                    toolStripComboBoxWishList.SelectedIndex = 0;
                }
            }
            else if (result == DialogResult.Cancel)
            {
                toolStripComboBoxWishList.SelectedIndex = 0;
            }
        }

        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfile profile = new frmProfile(customer.UserName);
            DialogResult result = profile.ShowDialog();
            if (result == DialogResult.OK)
            {
                customer = profile.customer;
                userIDToolStripMenuItem.Text = customer.UserName;
            }
            else if (result == DialogResult.Cancel)
            {
                userIDToolStripMenuItem.Text = customer.UserName;
            }
        }
        
        // Clears the shopping list and order amount listboxes.
        private void btnClear_Click(object sender, EventArgs e)
        {
            lbxOrderAmount.Items.Clear();
            lbxShoppingList.Items.Clear();
        }

        // Billing and shipping methods
        private void viewBillingInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<BillingInfo> billingInfo = new List<BillingInfo>();
            List<ShippingInfo> shippingInfo = new List<ShippingInfo>();
            billingOrShipping = "billing";
            frmBillingANDShippingInfo name = new frmBillingANDShippingInfo(billingOrShipping, customer.UserName);
            DialogResult result = name.ShowDialog();
            if (result == DialogResult.OK)
            {
                billingInfo = name.billing;
                shippingInfo = name.shipping;
                billing = billingInfo;
                shipping = shippingInfo;

                cboBillingOptions.Items.Clear();
                cboShippingOptions.Items.Clear();
                cboBillingOptions.Items.Add("Select Billing Option...");
                cboShippingOptions.Items.Add("Select Shipping Option...");

                if (billingInfo.Count != 0)
                {
                    for (int i = 0; i < billingInfo.Count; i++)
                    {
                        BillingInfo billingI = billingInfo[i];
                        cboBillingOptions.Items.Add("Billing option with address.." + billingI.BillingAddr1);
                    }
                }

                if (shippingInfo.Count != 0)
                {
                    for (int i = 0; i < shippingInfo.Count; i++)
                    {
                        ShippingInfo shippingI = shippingInfo[i];
                        cboShippingOptions.Items.Add("Shipping option with address.." + shippingI.ShippingAddr1);
                    }
                }
            }
        }

        private void viewShippingInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<BillingInfo> billingInfo = new List<BillingInfo>();
            List<ShippingInfo> shippingInfo = new List<ShippingInfo>();
            billingOrShipping = "shipping";
            frmBillingANDShippingInfo name = new frmBillingANDShippingInfo(billingOrShipping, customer.UserName);
            DialogResult result = name.ShowDialog();
            if (result == DialogResult.OK)
            {
                billingInfo = name.billing;
                shippingInfo = name.shipping;
                billing = billingInfo;
                shipping = shippingInfo;

                cboBillingOptions.Items.Clear();
                cboShippingOptions.Items.Clear();
                cboBillingOptions.Items.Add("Select Billing Option...");
                cboShippingOptions.Items.Add("Select Shipping Option...");

                if (billingInfo.Count != 0)
                {
                    for (int i = 0; i < billingInfo.Count; i++)
                    {
                        BillingInfo billingI = billingInfo[i];
                        cboBillingOptions.Items.Add("Billing option with address.." + billingI.BillingAddr1);
                    }
                }

                if (shippingInfo.Count != 0)
                {
                    for (int i = 0; i < shippingInfo.Count; i++)
                    {
                        ShippingInfo shippingI = shippingInfo[i];
                        cboShippingOptions.Items.Add("Shipping option with address.." + shippingI.ShippingAddr1);
                    }
                }
            }
        }

        // checkout method (not complete)
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if(lbxShoppingList.Items.Count == 0)
            {
                MessageBox.Show("You cannot checkout with an empty shopping list!", "Entry Error");
            } else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to check out?", "Confirmation", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    MessageBox.Show("Your items have been sent!", "Logging out");
                    resetControls();
                    login();
                }
            }
            
        }
    }
}
