using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using RentalSoftware.Logic;

namespace RentalSoftware
{
    /// <summary>
    /// Interaction logic for UpdateVendor.xaml
    /// </summary>
    public partial class UpdateVendor : MetroWindow
    {
        ErrorWindow errM = new ErrorWindow();
        SuccessWindow sm = new SuccessWindow();
        public UpdateVendor()
        {
            InitializeComponent();
            this.Title = new CompanyLogic().GetCompanyInfo().CompanyName;
            UpdateCompanyName.Text = VendorLisGUI.VendorData.CompanyName;
            UpdateFirstName.Text = VendorLisGUI.VendorData.FirstName;
            UpdateLastName.Text = VendorLisGUI.VendorData.LastName;
            UpdateCity.Text = VendorLisGUI.VendorData.City;
            UpdatePhone.Text = VendorLisGUI.VendorData.Phone;
            UpdateEmail.Text = VendorLisGUI.VendorData.Email;
            UpdateAddress.Text = VendorLisGUI.VendorData.Address;
        }

        //validation rules
        //regular expression for checking validation
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void TextValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void BothNumberAndTextValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z0-9@.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void BothNumberAndTextAndOtherCharatersValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z0-9@,-.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(UpdateFirstName.Text) || string.IsNullOrEmpty(UpdateCompanyName.Text) || string.IsNullOrEmpty(UpdatePhone.Text))
            {
                errM.Message = "All Feilds mark with asterisk(*) Are Required";
                errM.Show();
            }
            else
            {
                VendorLogic.UpdateVendor(UpdateCompanyName.Text, UpdateFirstName.Text, UpdateLastName.Text, UpdateCity.Text, UpdatePhone.Text, UpdateAddress.Text, UpdateEmail.Text, VendorLisGUI.VendorData.Id.ToString());
                sm.Message = "Vendor details updated successfully";
                sm.Show();
              //  MessageBox.Show(VendorLisGUI.VendorData.Id.ToString());
                Hide();

            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
