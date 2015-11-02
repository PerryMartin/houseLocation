/*
 * Created by: Perry Martin
 * Created on: 02-11-2015
 * Created for: ICS3U
 * Daily Assignment – Unit#4-03
 * This program displays your address
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace houseLocation
{
    public partial class frmlocationOfHouse : Form
    {
        private void ShowAddress(string aptNumber, string streetAddress, string city, string province, string postalCode)
        {
            MessageBox.Show("Apartment " + aptNumber + ", " + streetAddress + ", " + city + ", " + province + ", " + postalCode);
        }

        private void ShowAddress(string streetAddress, string city, string province, string postalCode)
        {
            MessageBox.Show(streetAddress + ", " + city + ", " + province + ", " + postalCode);
        }

        public frmlocationOfHouse()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string aptNumberInput = this.txtAptNumber.Text;
            string streetAddressInput = this.txtStreetAddress.Text;
            string cityInput = this.txtCity.Text;
            string provinceInput = this.txtProvince.Text;
            string postalCodeInput = this.txtPostalCode.Text;

            if (aptNumberInput == "")
            {
                ShowAddress(streetAddressInput, cityInput, provinceInput, postalCodeInput);
            }
            else
            {
                ShowAddress(aptNumberInput, streetAddressInput, cityInput, provinceInput, postalCodeInput);
            }

        }
    }
}
