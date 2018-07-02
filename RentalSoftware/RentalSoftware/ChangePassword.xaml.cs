using System;
using System.Collections.Generic;
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
using RentalSoftware.Logic;

namespace RentalSoftware
{
    /// <summary>
    /// Interaction logic for ChangePassword.xaml
    /// </summary>
    public partial class ChangePassword : MetroWindow
    {
        ErrorWindow errM = new ErrorWindow();
        SuccessWindow sm = new SuccessWindow();
        public ChangePassword()
        {
            InitializeComponent();
            this.Title = new CompanyLogic().GetCompanyInfo().CompanyName;
        }

        //validation rules
        //regular expression for checking validation
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

        private void BothNumberAndTextAndOtherCharatersValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z0-9@,-.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Username.Text) || string.IsNullOrEmpty(NewPassword.Password)
                  || string.IsNullOrEmpty(ConfirmNewPassword.Password))
            {
                errM.Message = "All Feilds mark with asterisk(*) Are Required";
                errM.Show();
            }
            else
            {
                if (NewPassword.Password != ConfirmNewPassword.Password)
                {
                    errM.Message = "New password and confirm password does not match.";
                    errM.Show();
                }
                else
                {
                    if (NewPassword.Password.Length < 5)
                    {
                        errM.Message = "Password length must not be less than five characters.";
                        errM.Show();
                    }
                    else
                    {
                        if (UserLoggedIn.ChangePassword(Username.Text, NewPassword.Password))
                        {
                            sm.Message = "New password is successfully created.";
                            sm.Show();
                            Hide();
                        }

                        else
                        {
                            errM.Message = "Incorrect username, try again.";
                            errM.Show();

                        }
                    }

                }
            }
        }


        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Username.Focus();
        }

        private void CancelTask_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
