using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stockpile
{
    public class ShippingInfo
    {
        private string shippingAddr1;
        private string shippingAddr2;
        private string city;
        private string state;
        private string zipCode;
        
        public string ShippingAddr1
        {
            get { return shippingAddr1; }
            set { shippingAddr1 = value; }
        }

        public string ShippingAddr2
        {
            get { return shippingAddr2; }
            set { shippingAddr2 = value; }
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
    }
}
