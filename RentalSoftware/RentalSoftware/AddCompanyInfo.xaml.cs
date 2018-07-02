using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;
using RentalSoftware.Logic;

namespace RentalSoftware
{
    /// <summary>
    /// Interaction logic for AddCompanyInfo.xaml
    /// </summary>
    public partial class AddCompanyInfo : MetroWindow
    {
        public byte[] data;

         ErrorWindow errM= new ErrorWindow();
        SuccessWindow sm = new SuccessWindow();
        
        public AddCompanyInfo()
        {
            InitializeComponent();
            this.Title = new CompanyLogic().GetCompanyInfo().CompanyName;
            CompanyName.Text = new CompanyLogic().GetCompanyInfo().CompanyName;
            Phone.Text = new CompanyLogic().GetCompanyInfo().Phone;
            Address.Text = new CompanyLogic().GetCompanyInfo().Address;
            Terms.Text = new CompanyLogic().GetCompanyInfo().Terms;

        }

        //validation rules
        //regular expression for checking validation
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9/]+");
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

        private void BothNumberAndTextAndOtherCharatersValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z0-9@,-.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void CancelTask_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(CompanyName.Text) || string.IsNullOrEmpty(Phone.Text))
            {
                errM.Message = "All Feilds mark with asterisk(*) Are Required";
                errM.Show();
            }
            else
            {

                    var id = new CompanyLogic().GetCompanyInfo().Id;
                    CompanyLogic.UpdateCompanyInfo(CompanyName.Text, Phone.Text, Address.Text,Terms.Text,
                        id.ToString());
                    sm.Message = "Company Details saved successfully";
                    sm.Show();

                    Hide();

                
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            //OpenFileDialog dlg =new OpenFileDialog();
            //dlg.ShowDialog();

            //FileStream fs = new FileStream(dlg.FileName, FileMode.Open,FileAccess.Read);

            // data = new byte[fs.Length];
            //fs.Read(data, 0, System.Convert.ToInt32(fs.Length));

            ////ImageSourceConverter imgs = new ImageSourceConverter();
            ////imagebox.SetValue(Image.SourceProperty, imgs.
            ////ConvertFromString(dlg.FileName));

            //fs.Close();

        }
    }
}
