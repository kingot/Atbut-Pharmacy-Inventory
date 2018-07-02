using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using RentalSoftware.Logic;
using RentalSoftware.Report_Windows;


namespace RentalSoftware
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : MetroWindow
    {

        public Dashboard()
        {
            InitializeComponent();
            this.Title = new CompanyLogic().GetCompanyInfo().CompanyName;

            statusTime.Content = new CompanyLogic().GetCompanyInfo().CompanyName;

        }


        private void AddNewCustomer_Click(object sender, RoutedEventArgs e)
        {
            AddCustomer customer = new AddCustomer();
            customer.ShowDialog();

        }

        // private bool? ShouldClose = null;
        private async void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            MessageDialogResult result =
                await
                    this.ShowMessageAsync("Exit Application", "Do You really want to Exit?",
                        MessageDialogStyle.AffirmativeAndNegative);
            if (result == MessageDialogResult.Negative)
            {
                e.Cancel = false;
            }
            else
            {
                CurrentUserLoggedInData.ClearUserData();
                new MainWindow().Show();
                Hide();
                // Application.Current.Shutdown();   
            }
        }




        private void MetroWindow_Activated(object sender, EventArgs e)
        {

        }

        private void AddNewItem_Click(object sender, RoutedEventArgs e)
        {
            AddItem addItem = new AddItem();
            addItem.ShowDialog();
        }


        private void AddItemCategory_Click(object sender, RoutedEventArgs e)
        {
            AddItemCategory addItemCategory = new AddItemCategory();
            addItemCategory.ShowDialog();
        }

        private void ChangeItemPrice_Click(object sender, RoutedEventArgs e)
        {
            ChangeItemPrice changeItemPrice = new ChangeItemPrice();
            changeItemPrice.ShowDialog();
        }

        private void RecordBrokenItem_Click(object sender, RoutedEventArgs e)
        {
            BrokenItem brokenItem = new BrokenItem();
            brokenItem.ShowDialog();

        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ActiveUser.Content = "Activer User: " + CurrentUserLoggedInData.FirstName + " " +
                                 CurrentUserLoggedInData.LastName;
            welcome.Text = "Welcome, " + CurrentUserLoggedInData.FirstName + " " + CurrentUserLoggedInData.LastName;
        }



        private async void Logout_Click(object sender, RoutedEventArgs e)
        {

            MessageDialogResult result =
                await
                    this.ShowMessageAsync("Exit Application", "Do You really want to Exit?",
                        MessageDialogStyle.AffirmativeAndNegative);
            if (result == MessageDialogResult.Negative)
            {
                return;
            }
            else
            {
                CurrentUserLoggedInData.ClearUserData();
                new MainWindow().Show();
                Hide();
                // Application.Current.Shutdown();   
            }
        }

        private void CustomerList_Click(object sender, RoutedEventArgs e)
        {
            CustomerListGUI gui = new CustomerListGUI();
            gui.ShowDialog();
        }

        private void Items_Click(object sender, RoutedEventArgs e)
        {
            new ItemListGUI().ShowDialog();
        }

        private void Vendors_Click(object sender, RoutedEventArgs e)
        {
            new VendorLisGUI().ShowDialog();
        }

        private void PurchaseOrder_Click(object sender, RoutedEventArgs e)
        {
            new PurchaseOrderListGui().ShowDialog();
        }

        private void RecieveItems_Click(object sender, RoutedEventArgs e)
        {
            new RecieveItemGUI().ShowDialog();
        }

        private void UpdateCompanyInfo_Click(object sender, RoutedEventArgs e)
        {
            new AddCompanyInfo().ShowDialog();
        }

        private void MakeASale_Click(object sender, RoutedEventArgs e)
        {
            new MakeASale().ShowDialog();
        }

        private void SaleHistory_Click(object sender, RoutedEventArgs e)
        {
            //new DailySalesReport().ShowDialog();
        }

        private void SaleHistory_Click_1(object sender, RoutedEventArgs e)
        {
            new TodaySales().Show();
        }

        private void SalesReport_Click(object sender, RoutedEventArgs e)
        {
            new OtherSalesReport().ShowDialog();
        }

        private void ResetPassword_OnClick(object sender, RoutedEventArgs e)
        {
            new ChangePassword().ShowDialog();
        }

        private void AddNewUser_OnClick(object sender, RoutedEventArgs e)
        {
            new AddUser().ShowDialog();
        }
    }
}