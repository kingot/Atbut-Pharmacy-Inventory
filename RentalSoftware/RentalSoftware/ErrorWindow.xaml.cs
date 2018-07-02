
using System.Windows;

using MahApps.Metro.Controls;
using RentalSoftware.Logic;

namespace RentalSoftware
{
    /// <summary>
    /// Interaction logic for ErrorWindow.xaml
    /// </summary>
    public partial class ErrorWindow : MetroWindow
    {
        private string _message;
        public ErrorWindow()
        {
            InitializeComponent();
            this.Title = new CompanyLogic().GetCompanyInfo().CompanyName;
        }

        public string Message
        {
            get
            {
                return _message;
            }

            set
            {
                _message = value;
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
         this.Hide();
            ShowInTaskbar = false;
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            errorMessage.Text = Message;
        }

        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
            ShowInTaskbar = false;
        }
    }
}
