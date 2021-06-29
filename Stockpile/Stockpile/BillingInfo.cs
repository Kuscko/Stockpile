using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stockpile
{
    public class BillingInfo
    {
        private string cardNumber;
        private string cardType;
        private string expirationDate;
        private string securityCode;
        private string billingAddr1;
        private string billingAddr2;
        private string city;
        private string state;
        private string zipCode;
        private string stateTax;
        
        public string CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }

        public string CardType
        {
            get { return cardType; }
            set { cardType = value; }
        }


        public string ExpirationDate
        {
            get { return expirationDate; }
            set { expirationDate = value; }
        }

        public string SecurityCode
        {
            get { return securityCode; }
            set { securityCode = value; }
        }

        public string BillingAddr1
        {
            get { return billingAddr1; }
            set { billingAddr1 = value; }
        }

        public string BillingAddr2
        {
            get { return billingAddr2; }
            set { billingAddr2 = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        public string StateTax
        {
            get { return stateTax; }
            set { stateTax = value; }
        }
    }
}
