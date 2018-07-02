
using System.Text.RegularExpressions;

using System.Windows.Input;

using MahApps.Metro.Controls;
using RentalSoftware.Logic;

namespace RentalSoftware
{
    /// <summary>
    /// Interaction logic for BrokenItem.xaml
    /// </summary>
    public partial class BrokenItem : MetroWindow
    {
        ErrorWindow errM = new ErrorWindow();
        SuccessWindow sm = new SuccessWindow();
        public BrokenItem()
        {
            InitializeComponent();
            this.Title = new CompanyLogic().GetCompanyInfo().CompanyName;
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

        private void CancelTask_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.Close();
        }

        private void MetroWindow_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            BrokenItemName.ItemsSource = new ItemLogic().ItemName();
        }

        private void Save_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(BrokenItemName.Text) || string.IsNullOrEmpty(BrokenQuantity.Value.ToString()))
            {
                errM.Message = "All Feilds mark with asterisk(*) Are Required";
                errM.Show();
            }
            else
            {
               ItemLogic.AddBrokenItem(BrokenItemName.Text,BrokenQuantity.Value.ToString(),Comment.Text);
                //errM.Message = "New item details saved successfully";
                //errM.Show();

                Hide();
            }
        }

        private void BrokenItemName_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var item = BrokenItemName.SelectedItem.ToString();

            if (!MakeSaleLogic.IsQuantityZero(item))
            {
                errM.Message =
                    "OOPS!!! Item may have zero quantity, check available quantity and try again.";
                errM.Show();
               
            }
        }
    }
}
