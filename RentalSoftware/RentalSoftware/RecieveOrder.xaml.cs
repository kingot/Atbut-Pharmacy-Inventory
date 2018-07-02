
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

using System.Windows.Input;

using MahApps.Metro.Controls;
using RentalSoftware.Logic;
using Telerik.Windows.Data;

namespace RentalSoftware
{
    /// <summary>
    /// Interaction logic for RecieveOrder.xaml
    /// </summary>
    public partial class RecieveOrder : MetroWindow
    {

        public RecieveOrder()
        {
            InitializeComponent();
            this.Title = new CompanyLogic().GetCompanyInfo().CompanyName;
        }

        private static int quantity;

        public static int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
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

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Item_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Quantity = PurchaseOrderLogic.SelectFields();
            //MessageBox.Show(Quantity.ToString());
            //PurchaseQuantity.Text = PurchaseOrderLogic.Quantity.ToString();
            //TotalCost.Text = PurchaseOrderLogic.TotalCost.ToString();
           // PurchaseQuantity.Text = PurchaseOrderLogic.Purchase.Quantity.ToString();

        }

        private void Item_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Item.IsDropDownOpen = true;
            Item.ItemsSource = new ItemLogic().ItemName();
        }

        private void Vendor_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Vendor.IsDropDownOpen = true;

            Vendor.ItemsSource = new VendorLogic().VendorName();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
