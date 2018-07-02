using System;
using System.Data;
using System.Windows;

using System.Windows.Input;
using MahApps.Metro.Controls;
using RentalSoftware.Logic;


namespace RentalSoftware
{
    /// <summary>
    /// Interaction logic for CustomerListGUI.xaml
    /// </summary>
    /// 
    public partial class CustomerListGUI : MetroWindow
    {
        ErrorWindow errM = new ErrorWindow();
        SuccessWindow sm = new SuccessWindow();
        private static CustomerLocgic.Customer customerData= new CustomerLocgic.Customer();

        public static CustomerLocgic.Customer CustomerData
        {
            get { return customerData; }
            set { customerData = value; }
        }

        public CustomerListGUI()
        {
            InitializeComponent();
            this.Title = new CompanyLogic().GetCompanyInfo().CompanyName;
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            CustomerView.ItemsSource = new CustomerLocgic().GetAllCustomers().DefaultView;
            this.CustomerView.Columns[4].TextWrapping = TextWrapping.Wrap;
            this.CustomerView.Columns[5].TextWrapping = TextWrapping.Wrap;
            CustomerView.Columns[0].MaxWidth=65;

        }

        private void CustomerView_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {

        }

        private void NewCustomer_Click(object sender, RoutedEventArgs e)
        {
            AddCustomer newCustomer = new AddCustomer();
            newCustomer.ShowDialog();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            // this.CustomerView.DeferRefresh();
            CustomerView.ItemsSource = null;
            CustomerView.ItemsSource = new CustomerLocgic().GetAllCustomers().DefaultView;
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

            DataRowView dataRow = CustomerView.SelectedItem as DataRowView;
            if (dataRow != null)
            {
                //over here im selecting each index of the selected row
                //based on the order on which your items are shown in the datagrid
                //note that changing that order will change your resultset
                customerData.Id = dataRow.Row[0].ToString();
                customerData.FullName = (string)dataRow.Row[1].ToString();
                customerData.Phone = (string)dataRow.Row[2].ToString();
                customerData.Address = (string)dataRow.Row[3].ToString();
                customerData.Email = (string)dataRow.Row[4].ToString();
                customerData.Date = dataRow.Row[5].ToString();




            }

            if (dataRow == null)
            {
                errM.Message = "Please select a row or a customer from the table to update information.";
                errM.Show();
            }
            else
            {
                new UpdateCustomer().ShowDialog();
            }
        }

        private void CustomerView_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void CustomerView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //if (CustomerView.SelectedItem == null) return;
            
            DataRowView dataRow = CustomerView.SelectedItem as DataRowView;
            if (dataRow != null)
            {
                //over here im selecting each index of the selected row
                //based on the order on which your items are shown in the datagrid
                //note that changing that order will change your resultset
                customerData.Id = dataRow.Row[0].ToString();
                customerData.FullName = (string)dataRow.Row[1].ToString();
                customerData.Phone = (string)dataRow.Row[2].ToString();
                customerData.Address = (string)dataRow.Row[3].ToString();
                customerData.Email = (string)dataRow.Row[4].ToString();
                customerData.Date = dataRow.Row[5].ToString();


            }

            new UpdateCustomer().ShowDialog();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            DataRowView dataRow = CustomerView.SelectedItem as DataRowView;
            if (dataRow != null)
            {
                CustomerData.Id = dataRow.Row[0].ToString();
            }
            if (dataRow == null)
            {
                errM.Message = "Please select a row or Customer from the table to delete it.";
                errM.Show();
            }
            else
            {
                //giveing a warning message
                var response = System.Windows.MessageBox.Show("Do you really want to delete this customer", "Delete",
               MessageBoxButton.YesNo, MessageBoxImage.Stop);

                if (response == MessageBoxResult.No)
                {
                    e.Handled = true;
                }
                else
                {
                   CustomerLocgic.SetCustomerDeleteStatusToOne(CustomerData.Id);
                    //refresh the datasource to pull all items status with status zero 
                    //into datagrid
                    CustomerView.ItemsSource = null;
                    CustomerView.ItemsSource = new CustomerLocgic().GetAllCustomers().DefaultView;
                    sm.Message = "Customer is successfully deleted from Customer list.";
                    sm.Show();

                }
            }
        }




        ////////
    }

    
}
