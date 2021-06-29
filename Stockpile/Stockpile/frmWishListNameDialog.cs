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
    public partial class frmWishListNameDialog : Form
    {
        public string wishlistName;

        public frmWishListNameDialog()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                try
                {
                    wishlistName = tboWishListName.Text;
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private bool IsValidData()
        {
            return Data_Validation.IsPresent(tboWishListName);
        }
    }
}
