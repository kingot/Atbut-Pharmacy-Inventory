using System;
using System.Collections.Generic;
using System.Data;
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
using Telerik.Windows.Controls;

namespace RentalSoftware
{
    /// <summary>
    /// Interaction logic for RecieveItemGUI.xaml
    /// </summary>
    public partial class RecieveItemGUI : MetroWindow
    {
        ErrorWindow errM = new ErrorWindow();
        SuccessWindow sm = new SuccessWindow();
        private static PurchaseOrderLogic.Purchase purchaseData = new PurchaseOrderLogic.Purchase();

        public static PurchaseOrderLogic.Purchase PurchaseData
        {
            get { return purchaseData; }
            set { purchaseData = value; }

        }
        public RecieveItemGUI()
        {
            InitializeComponent();
            this.Title = new CompanyLogic().GetCompanyInfo().CompanyName;
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            RecieveItem.ItemsSource = new PurchaseOrderLogic().GetAllPurchaseOrderBeforeRecieve().DefaultView;
            RecieveItem.Columns[0].Width = 65;
            RecieveItem.Columns[8].Width = 50;
            //formating the unit price to show in two decimal place
            var column4 = this.RecieveItem.Columns[4] as GridViewDataColumn;
            var column6 = this.RecieveItem.Columns[6] as GridViewDataColumn;

            if (column4 != null) column4.DataFormatString = "₵{0:N2}";
            if (column6 != null) column6.DataFormatString = "₵{0:N2}";
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            RecieveItem.ItemsSource = null;
            RecieveItem.ItemsSource = new PurchaseOrderLogic().GetAllPurchaseOrderBeforeRecieve().DefaultView;
            RecieveItem.Columns[0].Width = 65;
            RecieveItem.Columns[8].Width = 50;

            //formating the unit price to show in two decimal place
            var column4 = this.RecieveItem.Columns[4] as GridViewDataColumn;
            var column6 = this.RecieveItem.Columns[6] as GridViewDataColumn;

            if (column4 != null) column4.DataFormatString = "₵{0:N2}";
            if (column6 != null) column6.DataFormatString = "₵{0:N2}";
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void recieveItem_Click(object sender, RoutedEventArgs e)
        {
            DataRowView dataRow = RecieveItem.SelectedItem as DataRowView;
            if (dataRow != null)
            {
                PurchaseData.Id = dataRow.Row[0].ToString();
                PurchaseData.Pid = dataRow.Row[8].ToString();
                PurchaseData.Quantity = (int)dataRow.Row[5];
            }
            if (dataRow ==null)
            {
                errM.Message = "Please select a row or an item from the table to recieve item into store.";
                errM.Show();
            }
            else
            {
                //giveing a warning message
                var response = System.Windows.MessageBox.Show("Do you really want to Recieve Item into store", "Recieve Item",
               MessageBoxButton.YesNo, MessageBoxImage.Exclamation);

                if (response == MessageBoxResult.No)
                {
                    e.Handled = true;
                }
                else { 


                PurchaseOrderLogic.RecievePurchase(PurchaseData.Id, PurchaseData.Quantity);

                PurchaseOrderLogic.SetPurchaseOderToZeroOnRecieve(PurchaseData.Pid);
                //refresh the datasource to pull on purchase status to zero 
                //into datagrid
                RecieveItem.ItemsSource = null;
                RecieveItem.ItemsSource = new PurchaseOrderLogic().GetAllPurchaseOrderBeforeRecieve().DefaultView;
                sm.Message = "Item is successfully recieved and added to item stock";
                sm.Show();

            }
            }

        }



    }
}
