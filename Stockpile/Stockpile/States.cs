using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stockpile
{
    public class States
    {
        private string stateID;
        private string stateName;
        private string stateTax;

        public string StateID
        {
            get { return stateID; }
            set { stateID = value; }
        }

        public string StateName
        {
            get { return stateName; }
            set { stateName = value; }
        }

        public string StateTax
        {
            get { return stateTax; }
            set { stateTax = value; }
        }
    }
}
