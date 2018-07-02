
using System;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

using MahApps.Metro.Controls;
using RentalSoftware.Logic;
using Telerik.Windows.Controls.Map;

namespace RentalSoftware
{
    /// <summary>
    /// Interaction logic for UpdateItem.xaml
    /// </summary>
    public partial class UpdateItem : MetroWindow
    {
        ErrorWindow errM = new ErrorWindow();
        SuccessWindow sm = new SuccessWindow();
        public UpdateItem()
        {
            InitializeComponent();
            this.Title = new CompanyLogic().GetCompanyInfo().CompanyName;
            //getting values from the datagrid view rows
            UpdateCategory.SelectedItem = ItemListGUI.ItemData.CategoryId;
            UpdateItemName.Text = ItemListGUI.ItemData.Name;
            UpdateItemDescription.Text = ItemListGUI.ItemData.Description;
            UpdateUnitPrice.Value= Convert.ToDouble(ItemListGUI.ItemData.UnitePric);
            UpdateItemQuantity.Value = Convert.ToDouble(ItemListGUI.ItemData.Quantity);


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
            Regex regex = new Regex("[^a-zA-Z0-9@,&()-.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void MetroWindow_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            //UpdateCategory.IsDropDownOpen = true;
            UpdateCategory.ItemsSource = new ItemLogic().CategoryName();
        }

        private void UpdateCancel_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //updating code goes here

            if (string.IsNullOrEmpty(UpdateItemName.Text) || string.IsNullOrEmpty(UpdateUnitPrice.Value.ToString()) || string.IsNullOrEmpty(UpdateItemQuantity.Value.ToString()))
            {
                errM.Message = "All Feilds mark with asterisk(*) Are Required";
                errM.Show();
            }
            else
            {
                ItemLogic.UpdateItem(UpdateItemName.Text,UpdateItemDescription.Text,UpdateUnitPrice.Value,UpdateItemQuantity.Value, ItemListGUI.ItemData.Id.ToString());
                sm.Message = "Item details saved successfully";
                sm.Show();
               
                Hide();

            }

        }

        private void UpdateCategory_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //UpdateCategory.IsDropDownOpen = true;
            //UpdateCategory.ItemsSource = new ItemLogic().CategoryName();
        }
    }
}
