using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace RentalSoftware.Logic
{
    public static class UserLoggedIn
    {
        public static int VerifyUser(string username, string password)
        {
            CurrentUserLoggedInData userData = new CurrentUserLoggedInData();
            int id = 0;
            try
            {
                using (
                    SqlConnection connection =
                        new SqlConnection(ConfigurationManager.ConnectionStrings["RentalConnection"].ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        string query = "select * from [User] where Username='" + @username + "' and Password='" +
                                       @password + "'";
                        var command = new SqlCommand(query, connection) {CommandType = CommandType.Text};
                        command.Parameters.AddWithValue(@username, username);
                        command.Parameters.AddWithValue(@password, password);
                        command.Parameters.Clear();
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            id++;
                            CurrentUserLoggedInData.id = reader.GetInt32(0);
                            CurrentUserLoggedInData.FirstName = reader.GetString(1);
                            CurrentUserLoggedInData.LastName = reader.GetString(2);
                            CurrentUserLoggedInData.UserName = reader.GetString(3);
                            CurrentUserLoggedInData.role_id = reader.GetInt32(5);

                        }
                        reader.Close();

                        connection.Close();

                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            return id;
        }


        //query to show userType ..either Cashier or SalePerson
        public static int USerType(string username, string password)
        {
            int usertype = 0;
            using (
                SqlConnection connection =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["RentalConnection"].ConnectionString))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        string query = "select Role_Id from [User] where Username='" + @username + "' and Password='" +
                                       @password + "'";
                        var command = new SqlCommand(query, connection) {CommandType = CommandType.Text};
                        command.Parameters.AddWithValue(@username, username);
                        command.Parameters.AddWithValue(@password, password);
                        command.Parameters.Clear();
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            usertype = reader.GetInt32(0);

                        }
                        reader.Close();

                        connection.Close();

                    }

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message.ToString(), "Error", MessageBoxButton.OK,
                        MessageBoxImage.Exclamation);
                }
            }

            return usertype;
        }


        //selecting user full name : that is firstname and last name
        public static string Username(string username, string password)
        {
            string name = null;

            using (
                SqlConnection connection =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["RentalConnection"].ConnectionString))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        string query = "select First_Name,Last_Name from [User] where Username='" + @username +
                                       "' and Password='" + @password + "'";
                        var command = new SqlCommand(query, connection) {CommandType = CommandType.Text};
                        command.Parameters.AddWithValue(@username, username);
                        command.Parameters.AddWithValue(@password, password);
                        command.Parameters.Clear();
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            name = reader.GetString(0) + " " + reader.GetString(1);

                        }
                        reader.Close();
                        connection.Close();

                    }

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message.ToString(), "Error", MessageBoxButton.OK,
                        MessageBoxImage.Exclamation);
                }
                return name;
            }
        }


        //change password

        public static bool ChangePassword(string username, string newPassword)
        {
            bool isExist = false;
            try
            {
                using (
                    SqlConnection connection =
                        new SqlConnection(ConfigurationManager.ConnectionStrings["RentalConnection"].ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        string query = "UPDATE [User] SET Password='" + newPassword + "' where Username='" + username + "'";
                        var command = new SqlCommand(query, connection) {CommandType = CommandType.Text};

                        if (command.ExecuteNonQuery()>0)
                        {
                            isExist = true;
                        }
                        else
                        {
                            isExist = false;
                        }
                        connection.Close();
                       
                    }
                }
            }
            catch (Exception exception)
            {
                isExist = false;
            }
            return isExist;
        }


        //getting the item names for our combobox when adding item
        public static AutoCompleteStringCollection UserRole()
        {
            AutoCompleteStringCollection nameSource = new AutoCompleteStringCollection();
            using (
                SqlConnection connection =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["RentalConnection"].ConnectionString))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        string query = "select Name from dbo.Role";
                        var command = new SqlCommand(query, connection) {CommandType = CommandType.Text};
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            nameSource.Add(reader.GetString(0));
                        }
                        reader.Close();
                        connection.Close();
                    }

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message.ToString(), "Error", MessageBoxButton.OK,
                        MessageBoxImage.Exclamation);
                }

            }
            return nameSource;
        }

        //


        // inserting into user table
        public static void AddUser(string firstname, string lastname, string username, string password, string userrole)
        {
            ErrorWindow errM = new ErrorWindow();
            SuccessWindow sm = new SuccessWindow();

            try
            {
                using (
                    SqlConnection connection =
                        new SqlConnection(
                            ConfigurationManager.ConnectionStrings["RentalConnection"].ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        string query =
                            "INSERT INTO [User](First_Name,Last_Name,Username,Password,Role_Id)VALUES('" + firstname +
                            "','" + lastname + "','" + username + "','" + password +
                            "',(select Id from Role where Name='" + userrole + "'))";
                        var command = new SqlCommand(query, connection) {CommandType = CommandType.Text};
                        if (command.ExecuteNonQuery() > 0)
                        {
                            //command.ExecuteNonQuery();
                            sm.Message = "New User is successfully added.";
                            sm.Show();
                        }

                        connection.Close();
                    }
                }
            }
            catch (Exception exception)
            {

                errM.Message = exception.Message;
                errM.Show();

            }

        }


        //
    }
    
}
