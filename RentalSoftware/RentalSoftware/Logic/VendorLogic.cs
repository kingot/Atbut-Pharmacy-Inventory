using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace RentalSoftware.Logic
{
    public class VendorLogic
    {

        //getting the names of all the vendors
        public AutoCompleteStringCollection VendorName()
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
                        string query = "select Company_Name from dbo.Vendor";
                        var command = new SqlCommand(query, connection) { CommandType = CommandType.Text };
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



        //insertion into new  Vendor table
        public static void AddVendor(string companyName,string firstName, string lastName, string city, string phone, string address, string email)
        {
            try
            {
                using (
                    SqlConnection connection =
                        new SqlConnection(ConfigurationManager.ConnectionStrings["RentalConnection"].ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        string query = "INSERT INTO dbo.Vendor(Company_Name,First_Name,Last_Name,City,Phone,Email,Address)" +
                                       "VALUES('" + companyName + "','" + firstName + "','" + lastName + "','" + city + "','" + phone + "','" + email + "','" + address + "')";
                        var command = new SqlCommand(query, connection) { CommandType = CommandType.Text };
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }


        }



        //selection of all customers from a view
        public DataTable GetAllVendors()
        {
            var data = new DataTable();
            using (
                SqlConnection connection =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["RentalConnection"].ConnectionString))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        string query = "select * from dbo.VendorList order by [VID #] desc";
                        var dataAdapter = new SqlDataAdapter(query, connection);
                        dataAdapter.Fill(data);
                        connection.Close();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message.ToString(), "Error", MessageBoxButton.OK,
                        MessageBoxImage.Exclamation);
                }
                return data;
            }

        }


        public class Vendor
        {
            //setting object of the customer
            public string Id { get; set; }
            public string CompanyName { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }
            public string Date { get; set; }
        }


        //updating customer details
        public static void UpdateVendor(string companyname,string firstname, string lastname,string city, string phone, string address, string email, string id)
        {
            try
            {
                using (
                    SqlConnection connection =
                        new SqlConnection(ConfigurationManager.ConnectionStrings["RentalConnection"].ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        string query = "UPDATE dbo.Vendor SET Company_Name ='" + companyname + "' , First_Name ='" + firstname + "' , Last_Name ='" + lastname + "'," +
                                       " Phone ='" + phone + "',city ='" + city + "' , Address ='" + address + "',Email ='" + email + "'" + " WHERE  Id ='" + id + "' ";
                        var command = new SqlCommand(query, connection) { CommandType = CommandType.Text };
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

        }


        //set item status to 1 on delete to hide item from user
        //but item still in the DB table for future audit

        public static void SetVendorDeleteStatusToOne(string id)
        {
            try
            {
                using (
                    SqlConnection connection =
                        new SqlConnection(ConfigurationManager.ConnectionStrings["RentalConnection"].ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        string query = "UPDATE dbo.Vendor SET Delete_Status = 1 where Id='" + id + "'";
                        var command = new SqlCommand(query, connection) { CommandType = CommandType.Text };
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

        }


        //
    }
}
