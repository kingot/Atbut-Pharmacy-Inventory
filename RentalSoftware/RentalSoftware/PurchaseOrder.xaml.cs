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
    /// Interaction logic for PurchaseOrder.xaml
    /// </summary>
    public partial class PurchaseOrder : MetroWindow
    {
        private ErrorWindow errM = new ErrorWindow();
        public PurchaseOrder()
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

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //private void MetroWindow_PreviewTextInput(object sender, TextCompositionEventArgs e)
        //{
           
        //}

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //
            //
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
            if (string.IsNullOrEmpty(Item.Text) || string.IsNullOrEmpty(Vendor.Text)
                   || string.IsNullOrEmpty(UnitPrice.Value.ToString()) ||
                string.IsNullOrEmpty(ItemQuantity.Value.ToString()))
            {
                errM.Message = "All Feilds mark with asterisk(*) Are Required";
                errM.Show();
            }
            else
            {

               PurchaseOrderLogic.PurchaseOrder(Item.Text,Vendor.Text,UnitPrice.Value.ToString(),ItemQuantity.Value.ToString(),TotalCost.Text);
                
                //errM.Message = "New item details saved successfully";
                //errM.Show();

                Hide();
            }
        }

        private void ItemQuantity_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            double num;
            if (string.IsNullOrEmpty(ItemQuantity.Value.ToString()) == false)
            {
                if (double.TryParse(ItemQuantity.Value.ToString(), out num))
                {
                    var value = Convert.ToDouble(ItemQuantity.Value) * Convert.ToDouble(UnitPrice.Value) + "";
                    TotalCost.Text =  value ;
                        //Convert.ToDouble(ItemQuantity.Value)*Convert.ToDouble(UnitPrice.Value) + "";
                }
                else
                {
                    errM.Message = "Cant have letters";
                    errM.Show();
                    //MessageBox.Show("Cant have letters", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private void UnitPrice_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            double num;
            if (string.IsNullOrEmpty(UnitPrice.Value.ToString()) == false)
            {
                if (double.TryParse(UnitPrice.Value.ToString(), out num))
                {
                    var value = Convert.ToDouble(ItemQuantity.Value) * Convert.ToDouble(UnitPrice.Value) + "";
                    TotalCost.Text =  value;
                    //Convert.ToDouble(ItemQuantity.Value)*Convert.ToDouble(UnitPrice.Value) + "";
                }
                else
                {
                    errM.Message = "Cant have letters";
                    errM.Show();
                    //MessageBox.Show("Cant have letters", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private void Item_TextInput(object sender, TextCompositionEventArgs e)
        {
            //Item.IsDropDownOpen = true;
            //Item.ItemsSource = new ItemLogic().ItemName();
        }
    }
}
