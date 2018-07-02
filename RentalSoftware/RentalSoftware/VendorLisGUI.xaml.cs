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

namespace RentalSoftware
{
    /// <summary>
    /// Interaction logic for VendorLisGUI.xaml
    /// </summary>
    public partial class VendorLisGUI : MetroWindow
    {
        ErrorWindow errM = new ErrorWindow();
        SuccessWindow sm = new SuccessWindow();
        private  static  VendorLogic.Vendor _vendorData =new VendorLogic.Vendor();
        public static VendorLogic.Vendor VendorData
        {
            get { return _vendorData; }
            set { _vendorData = value; }

        }
        public VendorLisGUI()
        {
            InitializeComponent();
            this.Title = new CompanyLogic().GetCompanyInfo().CompanyName;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            VendorView.ItemsSource = null;
            VendorView.ItemsSource = new VendorLogic().GetAllVendors().DefaultView;
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            VendorView.ItemsSource = new VendorLogic().GetAllVendors().DefaultView;
            VendorView.Columns[0].MaxWidth = 65;
        }

        private void NewVendor_Click(object sender, RoutedEventArgs e)
        {
            new AddVendor().ShowDialog();
        }


        private void MetroWindow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
          DataRowView dataRow = VendorView.SelectedItem as DataRowView;

            if (dataRow != null)
            {
                _vendorData.Id = dataRow.Row[0].ToString();
                _vendorData.CompanyName = dataRow.Row[1].ToString();
                _vendorData.FirstName = dataRow.Row[2].ToString();
                _vendorData.LastName = dataRow.Row[3].ToString();
                _vendorData.City = dataRow.Row[4].ToString();
                _vendorData.Phone = dataRow.Row[5].ToString();
                _vendorData.Email = dataRow.Row[6].ToString();
                _vendorData.Address = dataRow.Row[7].ToString();
                _vendorData.Date = dataRow.Row[8].ToString();
            }
            new UpdateVendor().ShowDialog();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            DataRowView dataRow = VendorView.SelectedItem as DataRowView;

            if (dataRow != null)
            {
                _vendorData.Id = dataRow.Row[0].ToString();
                _vendorData.CompanyName = dataRow.Row[1].ToString();
                _vendorData.FirstName = dataRow.Row[2].ToString();
                _vendorData.LastName = dataRow.Row[3].ToString();
                _vendorData.City = dataRow.Row[4].ToString();
                _vendorData.Phone = dataRow.Row[5].ToString();
                _vendorData.Email = dataRow.Row[6].ToString();
                _vendorData.Address = dataRow.Row[7].ToString();
                _vendorData.Date = dataRow.Row[8].ToString();
            }
            if (dataRow == null)
            {
                errM.Message = "Please select a row or a vendor from the table to update information.";
                errM.Show();
            }
            else
            {
                new UpdateVendor().ShowDialog();
            }
          
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            DataRowView dataRow = VendorView.SelectedItem as DataRowView;
            if (dataRow != null)
            {
                _vendorData.Id = dataRow.Row[0].ToString();
            }
            if (dataRow == null)
            {
                errM.Message = "Please select a row or vendor from the table to delete it.";
                errM.Show();
            }
            else
            {
                //giveing a warning message
                var response = System.Windows.MessageBox.Show("Do you really want to delete this vendor", "Delete",
               MessageBoxButton.YesNo, MessageBoxImage.Stop);

                if (response == MessageBoxResult.No)
                {
                    e.Handled = true;
                }
                else
                {
                   VendorLogic.SetVendorDeleteStatusToOne(_vendorData.Id);
                    //refresh the datasource to pull all items status with status zero 
                    //into datagrid
                    VendorView.ItemsSource = null;
                    VendorView.ItemsSource = new VendorLogic().GetAllVendors().DefaultView;
                    sm.Message = "Vendor is successfully deleted from Vendor list.";
                    sm.Show();

                }
            }
        }

        //private void NewItem_Click(object sender, RoutedEventArgs e)
        //{

        //}
    }
}
