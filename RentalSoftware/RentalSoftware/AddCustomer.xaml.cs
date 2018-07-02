using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using System.ComponentModel;
using RentalSoftware.Logic;
using System.Text.RegularExpressions;

namespace RentalSoftware
{
    /// <summary>
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : MetroWindow
    {
        ErrorWindow errM = new ErrorWindow();
        SuccessWindow sm= new SuccessWindow();
        public AddCustomer()
        {
            InitializeComponent();
            this.Title = new CompanyLogic().GetCompanyInfo().CompanyName;
        }

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

        //saving data into the customer table
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            
        
            if (string.IsNullOrEmpty(FullName.Text)|| string.IsNullOrEmpty(Phone.Text))
            {
                errM.Message = "All Feilds mark with asterisk(*) Are Required";
                errM.Show();
            }
            else
            {
                CustomerLocgic.AddCustomer(FullName.Text,Phone.Text, Address.Text, Email.Text);
                sm.Message = "New customer details saved successfully";
                sm.Show();
                
               Hide();
                //ShowInTaskbar = false;
                //new AddCustomer().ShowDialog();
            }
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            FullName.Focus();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
