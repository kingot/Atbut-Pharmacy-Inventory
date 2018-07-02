
using System.Windows;
using MahApps.Metro.Controls;
using RentalSoftware.Logic;
using Telerik.Windows.Controls;

namespace RentalSoftware
{
    /// <summary>
    /// Interaction logic for PurchaseOrderListGui.xaml
    /// </summary>
    public partial class PurchaseOrderListGui : MetroWindow
    {
        ErrorWindow errM= new ErrorWindow();
        //private static PurchaseOrderLogic.Purchase purchaseData = new PurchaseOrderLogic.Purchase();

        //public static PurchaseOrderLogic.Purchase PurchaseData
        //{
        //    get { return purchaseData; }
        //    set { purchaseData = value; }

        //}

        public PurchaseOrderListGui()
        {
            InitializeComponent();
            this.Title = new CompanyLogic().GetCompanyInfo().CompanyName;
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            PurchaseOrderView.ItemsSource = null;
            PurchaseOrderView.ItemsSource = new PurchaseOrderLogic().GetAllPurchaseOrder().DefaultView;


            //formating the unit price to show in two decimal place
            var column4 = this.PurchaseOrderView.Columns[4] as GridViewDataColumn;
            var column6 = this.PurchaseOrderView.Columns[6] as GridViewDataColumn;

            if (column4 != null) column4.DataFormatString = "₵{0:N2}";
            if (column6 != null) column6.DataFormatString = "₵{0:N2}";
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void PurchaseOrder_Click(object sender, RoutedEventArgs e)
        {
            new PurchaseOrder().ShowDialog();
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            PurchaseOrderView.ItemsSource = new PurchaseOrderLogic().GetAllPurchaseOrder().DefaultView;
            PurchaseOrderView.Columns[0].MaxWidth = 65;

            //formating the unit price to show in two decimal place
            var column4 = this.PurchaseOrderView.Columns[4] as GridViewDataColumn;
            var column6 = this.PurchaseOrderView.Columns[6] as GridViewDataColumn;

            if (column4 != null) column4.DataFormatString = "₵{0:N2}";
            if (column6 != null) column6.DataFormatString = "₵{0:N2}";
        }

        //private void recievedPay_Click(object sender, RoutedEventArgs e)
        //{
        //    DataRowView dataRow = PurchaseOrderView.SelectedItem as DataRowView;
        //    if (dataRow != null)
        //    {
        //        PurchaseData.Id = dataRow.Row[0].ToString();
        //        PurchaseData.VendorId = dataRow.Row[1].ToString();
        //        //PurchaseData.ItemId = dataRow.Row[2].ToString();
        //        PurchaseData.Quantity = (int)dataRow.Row[6];
        //    }

        //    //MessageBox.Show(PurchaseData.Id);
        //    //MessageBox.Show(PurchaseData.Quantity);
        //    //MessageBox.Show(purchaseData.ItemId);

        //        PurchaseOrderLogic.RecievePurchase(PurchaseData.Id, PurchaseData.Quantity); 
        //        errM.Message = "Item is successfully recieved and added to item stock";
        //        errM.Show();
          
            
        //}

    }
}
