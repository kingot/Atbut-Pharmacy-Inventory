
using System;
using System.Windows;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using RentalSoftware.Logic;

namespace RentalSoftware
{
    /// <summary>
    /// Interaction logic for SalePerson.xaml
    /// </summary>
    public partial class SalePerson : MetroWindow
    {
        public SalePerson()
        {
            InitializeComponent();
            this.Title = new CompanyLogic().GetCompanyInfo().CompanyName;
            time.Content = new CompanyLogic().GetCompanyInfo().CompanyName;
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ActiveUser.Content = "Activer User: " + CurrentUserLoggedInData.FirstName + " " +
                                 CurrentUserLoggedInData.LastName;
            welcome.Text = "Welcome, " + CurrentUserLoggedInData.FirstName + " " + CurrentUserLoggedInData.LastName;
        }

        private void MakeASale_Click(object sender, RoutedEventArgs e)
        {
            new MakeASale().ShowDialog();
        }

        private void AddNewCustomer_Click(object sender, RoutedEventArgs e)
        {
            new AddCustomer().ShowDialog();
        }

        private void CustomerList_Click(object sender, RoutedEventArgs e)
        {
            new CustomerListGUI().ShowDialog();
        }

        private async void Logout_OnClick(object sender, RoutedEventArgs e)
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
    }
}
