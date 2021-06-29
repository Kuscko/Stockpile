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
     * Date Created: 11/30/2018
     * File name: frmRegisterTOS.class : form
     * Purpose:
     *      The purpose of this form is to provide the user with our Terms of Service(TOS). 
     *      If the user does accept then the form returns the dialog result.OK, nothing otherwise on
     *      cancel.
     */

    public partial class frmRegisterTOS : Form
    {
        public frmRegisterTOS()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
