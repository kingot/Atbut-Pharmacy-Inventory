using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using RentalSoftware.Logic;
using MessageBox = System.Windows.MessageBox;

namespace RentalSoftware
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : MetroWindow
    {
        ErrorWindow errM= new ErrorWindow();
       

        public static int Id;
        public static string fullname = null;
        private int valid = 0;
        public MainWindow()
        {
            InitializeComponent();
            this.Title = new CompanyLogic().GetCompanyInfo().CompanyName;
            comp.Content= new CompanyLogic().GetCompanyInfo().CompanyName;
        }

        public static int ID
        {
            get { return Id; }
            set { Id = value; }
        }

        public static string FullName
        {
            get { return fullname; }
            set { fullname = value; }
        }

       

        public void LogUserIn()
        {
            if (string.IsNullOrEmpty(Username.Text) || string.IsNullOrEmpty(Password.Password))
            {
                
                    errM.Message = "All Fields Are Required, check your username and password.";
                    errM.Show();
                    //MessageBox.Show("All Details Are Required", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    Password.Password = "";
                    Username.Text = "";
                    Username.Focus();
               // }
                //catch (Exception ) { }
               
            }
            else
            {
                valid =UserLoggedIn.VerifyUser(Username.Text, Password.Password);
                CurrentUserLoggedInData userData = new CurrentUserLoggedInData();
                if (valid == 1)
                {
                    ID = UserLoggedIn.USerType(Username.Text, Password.Password);

                    FullName = UserLoggedIn.Username(Username.Text, Password.Password);
                    Dashboard cashier = new Dashboard();
                    SalePerson sales = new SalePerson();
                    if (Id == 1)
                    { cashier.Show(); }
                    else if (Id == 2)
                    {
                        sales.Show();
                    }

                    Hide();
                
                }
                else
                {
                    errM.Message = "Invalid Username or Password provided, try again.";
                    errM.ShowDialog();
                  
                    Password.Password = "";
                    Username.Text = "";
                    Username.Focus();
                }
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LogUserIn();
        }

        private void Password_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                LogUserIn();
            }
        }

        private void Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                LogUserIn();
            }
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Username.Focus();
        }
    }
}
