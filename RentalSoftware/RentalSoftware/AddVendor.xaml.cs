
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using RentalSoftware.Logic;
using MessageBox = System.Windows.MessageBox;

namespace RentalSoftware
{
    /// <summary>
    /// Interaction logic for AddVendor.xaml
    /// </summary>
    public partial class AddVendor : MetroWindow
    {
        ErrorWindow errM = new ErrorWindow();
        SuccessWindow sm = new SuccessWindow();
        public AddVendor()
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
            Regex regex = new Regex("[^a-zA-Z0-9@,-.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Cancel_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, System.Windows.RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(FirstName.Text) || string.IsNullOrEmpty(CompanyName.Text) || string.IsNullOrEmpty(Phone.Text))
            {
                errM.Message = "All Feilds mark with asterisk(*) Are Required";
                errM.Show();
            }
            else
            {
                VendorLogic.AddVendor(CompanyName.Text,FirstName.Text, LastName.Text,City.Text, Phone.Text, Address.Text, Email.Text);
                sm.Message = "New Vendor details saved successfully";
                sm.Show();

                Hide();
               
            }
        }

        private void MetroWindow_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            CompanyName.Focus();
        }


        //..............
    }
}
