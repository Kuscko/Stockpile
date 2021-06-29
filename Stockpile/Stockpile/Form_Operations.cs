using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stockpile
{
    /*
     * Author: Patrick Kelly
     * Date Created: 11/14/2018
     * Date Updated: --/--/----
     * File name: Database_Connections.class
     * Purpose:
     *      The purpose of this class is to perform tasks that each form requires that is repeatable.
     */
    public class Form_Operations
    {
        public static void PasswordCasing(TextBox textbox)
        {
            // Sets the maximum length of text in the control to 12
            textbox.MaxLength = 12;

            // Assins the asterisk to be the password character to hide the information
            textbox.PasswordChar = '*';

            //Change all text entered to be lowercase.
            textbox.CharacterCasing = CharacterCasing.Lower;

            // Align the text in the center of the Textbox Control
            textbox.TextAlign = HorizontalAlignment.Center;
        }
    }
}
