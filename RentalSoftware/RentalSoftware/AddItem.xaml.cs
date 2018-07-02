
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

using System.Windows.Input;

using MahApps.Metro.Controls;
using RentalSoftware.Logic;

namespace RentalSoftware
{
    /// <summary>
    /// Interaction logic for AddItem.xaml
    /// </summary>
    public partial class AddItem : MetroWindow
    {
        ErrorWindow errM = new ErrorWindow();
        SuccessWindow sm = new SuccessWindow();
        public AddItem()
        {
            InitializeComponent();
            this.Title = new CompanyLogic().GetCompanyInfo().CompanyName;
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
            Regex regex = new Regex("[^a-zA-Z0-9@,&()'-.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Category_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        //getting the autocomplete category name
        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Category.ItemsSource = new ItemLogic().CategoryName();
            Vendor.ItemsSource = new VendorLogic().VendorName();

        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Category.Text) || string.IsNullOrEmpty(ItemName.Text) 
                   || string.IsNullOrEmpty(UnitPrice.Value.ToString()))
            {
                errM.Message = "All Feilds mark with asterisk(*) Are Required";
                errM.Show();
            }
            else
            {
               
               ItemLogic.AddNewItem(Category.Text, Vendor.Text, ItemName.Text,ItemDescription.Text, UnitPrice.Value.ToString(),ItemQuantity.Value.ToString());
                //errM.Message = "New item details saved successfully";
                //errM.Show();

                Hide();
            }
        }
    }
}
