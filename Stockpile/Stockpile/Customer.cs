using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stockpile
{
    public class Customer
    {
        /*
         * Author: Patrick Kelly
         * Date: 10/23/2018
         */
        
        // These local variables hold information for the database.
        private string userName;
        private string password;
        private string email;
        private string fName;
        private string lName;
        private string hphone;
        private string mphone;

        // Properties that get or sets a data value that contains the item's attribute.
        
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }


        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        
        public string Fname
        {
            get { return fName; }
            set { fName = value; }
        }
        
        public string Lname
        {
            get { return lName; }
            set { lName = value; }
        }

        public string HomePhone
        {
            get { return hphone; }
            set { hphone = value; }
        }
        
        public string MobilePhone
        {
            get { return mphone; }
            set { mphone = value; }
        }

        // Returns a string that contains the item's number, description and price formated like this:
        // 1234657    Agapanthus ($7.95)
        //public string GetDisplayText() => itemNo.ToString() + "    " + description + " (" + price.ToString("C") + ")";

        public Customer()
        {

        }
    }
}
