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
    /// Interaction logic for ReturnItem.xaml
    /// </summary>
    public partial class ReturnItem : MetroWindow
    {
        ErrorWindow errM = new ErrorWindow();
        SuccessWindow sm = new SuccessWindow();
        public string id = ItemListGUI.ItemData.Id;
        public ReturnItem()
        {
            InitializeComponent();
            this.Title = new CompanyLogic().GetCompanyInfo().CompanyName;
            //reference the item id from datagridview into return item page
            ReturnItemName.Text = ItemListGUI.ItemData.Name;
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

        private void BothNumberAndTextValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z0-9@.]+");
            e.Handled = regex.IsMatch(e.Text);
        }


        private void CancelTask_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(ReturnItemName.Text) || string.IsNullOrEmpty(QuantityReturn.Value.ToString()))
            {
                errM.Message = "All Feilds mark with asterisk(*) Are Required";
                errM.Show();
            }
            else
            {
                
                ItemLogic.ReturnItem(ReturnItemName.Text,QuantityReturn.Value.ToString(),id);

                Hide();

            }
            //MessageBox.Show(id);
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
           // ReturnItemName.ItemsSource = new ItemLogic().ItemName();
        }
    }
}
