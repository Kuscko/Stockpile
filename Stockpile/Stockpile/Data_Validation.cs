using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stockpile
{
    /*
     * Author: Patrick Kelly
     * Date Created: 11/14/2018
     * Date Updated: 11/29/2018
     * File name: Database_Connections.class
     * Purpose:
     *      The purpose of this class is to validate data that the user enters on each form.
     *      
     * Notes: Figure out how to catch wether or not a value such as home phone, mobile phone are the same and display
     * an error. Also Validate user and passworod to have simpliciity in a username (only letters and numbers) and complexity
     * in the password (one uppercase, one lowercase, one digit, one symbole # $ % @. COMPLETED 11/30/2018
     */
    public static class Data_Validation
    {
        private static string title = "Entry Error";

        public static string Title
        {
            get { return title; }
            set { title = value; }
        }

        // checks if the textbox is populated.
        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " is a required field.", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        // checks if the textbox is populated.
        public static bool IsPresentMaskBox(MaskedTextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " is a required field.", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        // checks whether or not the provided email on the registration form is an email.
        public static bool isEmail(TextBox textBox)
        {
            string email = textBox.Text.Trim();
            int atSign = email.IndexOf("@");
            int period = email.LastIndexOf(".");
            if(atSign == -1 || period == -1 || atSign > period)
            {
                MessageBox.Show("You need a valid " + textBox.Tag, "Format Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        // checks whether or not the user name provided has only lowercase and uppercase letters and numbers.
        // and atleast 6 characters long at most 25 characters long.
        public static bool isUserID(TextBox textBox)
        {
            string patern = "^([a-zA-Z0-9].{6,25})+$";
            Regex defaultRegex = new Regex(patern);
            if (defaultRegex.IsMatch(textBox.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + "must have a uppercase and lowercase digit, with atleast one number. \n and must be atleast 6 characters long and at most 25 characters long.");
                textBox.Focus();
                return false;
            }
        }

        // checks if the password is complex enough for the user to enter.
        public static bool passwordComplexity(TextBox textbox)
        {
            string patern = "^((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})+$";
            Regex defaultRegex = new Regex(patern);
            if (defaultRegex.IsMatch(textbox.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textbox.Tag + " must have at least: \n - one Uppercase letter \n - one lowercase letter \n - and one symbole(@ # $ %) \n - and one digit. \n It also must be between 6 to 20 Characters long.");
                textbox.Focus();
                return false;
            }
        }

        // checks whether or not that the given Textboxes both hold the same values.
        public static bool isSame(TextBox textBox_One, TextBox TextBox_Two)
        {
            if(textBox_One.Text.Trim() == TextBox_Two.Text.Trim())
            {
                return true;
            }
            else
            {
                MessageBox.Show("" + textBox_One.Tag + " & " + TextBox_Two.Tag + " must be the same.");
                textBox_One.Focus();
                return false;
            }
        }

        public static bool selectedComboBoxIndex(ComboBox combobox)
        {
            if(combobox.SelectedIndex != -1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please select a " + combobox.Tag);
                return false;
            }
        }


        public static bool selectedProductIndex(int i)
        {
            if (i != -1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please select a product.");
                return false;
            }
        }

        // checks if a textbox is checked.
        public static bool tosAgreement(CheckBox tos)
        {
            if (tos.Checked == true)
            {
                return true;
            } else
            {
                MessageBox.Show("Please check the " + tos.Tag, Title + " checkbox.");
                tos.Focus();
                return false;
            }
        }


    }
}
