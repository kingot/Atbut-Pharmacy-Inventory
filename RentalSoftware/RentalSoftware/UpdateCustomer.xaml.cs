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
    /// Interaction logic for UpdateCustomer.xaml
    /// </summary>
    public partial class UpdateCustomer : MetroWindow
    {
      
        ErrorWindow errM = new ErrorWindow();
        SuccessWindow sm = new SuccessWindow();
        public UpdateCustomer()
        {
            InitializeComponent();
            this.Title = new CompanyLogic().GetCompanyInfo().CompanyName;
            //getting values from the datagrid view rows
            UpdateFullName.Text = CustomerListGUI.CustomerData.FullName;
                UpdatePhone.Text = CustomerListGUI.CustomerData.Phone;
                UpdateEmail.Text = CustomerListGUI.CustomerData.Email;
                UpdateAddress.Text = CustomerListGUI.CustomerData.Address;
            
        }

        //validation rules
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

        private void TextValidationTextBox1(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void BothNumberAndTextValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z0-9@.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void UpdateCustomer_Loaded(object sender, RoutedEventArgs e)
        {

           
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(UpdateFullName.Text) || string.IsNullOrEmpty(UpdatePhone.Text))
            {
                errM.Message = "All Feilds mark with asterisk(*) Are Required";
                errM.Show();
            }
            else
            {
                CustomerLocgic.UpdateCustomer(UpdateFullName.Text,UpdatePhone.Text, UpdateAddress.Text, UpdateEmail.Text, CustomerListGUI.CustomerData.Id.ToString());
                sm.Message = "Customer details saved successfully";
                sm.Show();
               // MessageBox.Show(CustomerListGUI.CustomerData.Id.ToString());

                Hide();
               
            }
        }
    }
}
