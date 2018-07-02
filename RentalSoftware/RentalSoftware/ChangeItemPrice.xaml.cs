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
using RentalSoftware.Logic;

namespace RentalSoftware
{
    /// <summary>
    /// Interaction logic for ChangeItemPrice.xaml
    /// </summary>
    public partial class ChangeItemPrice : MetroWindow
    {
        ErrorWindow errM = new ErrorWindow();
        SuccessWindow sm = new SuccessWindow();
        public ChangeItemPrice()
        {
            InitializeComponent();
            this.Title = new CompanyLogic().GetCompanyInfo().CompanyName;
            // ItemName.ItemsSource = new ItemLogic().ItemName();
        }

        private void CancelTask_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //ItemName.IsDropDownOpen = true;
            //ItemName.ItemsSource = new ItemLogic().ItemName();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(ItemName.Text) || string.IsNullOrEmpty(NewUnitPrice.Value.ToString()))
            {
                errM.Message = "All Feilds mark with asterisk(*) Are Required";
                errM.Show();
            }
            else
            {

                ItemLogic.UpdatePrice(ItemName.Text,Convert.ToInt16(NewUnitPrice.Value.ToString()));

                Hide();
            }
        }

        private void ItemName_TextInput(object sender, TextCompositionEventArgs e)
        {
           
        }

        private void ItemName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ItemName.IsDropDownOpen = true;
            ItemName.ItemsSource = new ItemLogic().ItemName();

        }
    }
}
