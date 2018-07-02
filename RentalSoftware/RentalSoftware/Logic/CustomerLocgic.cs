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
    public class CustomerLocgic
    {
       // ErrorWindow errM = new ErrorWindow();

            //insertion into customer table
           

        public static void AddCustomer(string fullName, string phone, string address, string email)
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
                        string query = "INSERT INTO dbo.Customer(Full_Name,Phone,Address,Email)VALUES('" + fullName + "','" + phone + "','" + address + "','" + email + "')";
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
        public DataTable GetAllCustomers()
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
                        string query = "select * from dbo.CustomerList order by [CID #] desc";
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

        public class Customer
        {
            //setting object of the customer
            public string Id { get; set; }
            public string FullName { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }
            public string Date { get; set; }
        }

        public class Customer2
        {
            //setting object of the customer
            public int Id { get; set; }
            public string FullName { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }
            public string Date { get; set; }
        }



        public Customer2 GetCustomerInfo(string name)
        {

            var info = new Customer2();
            using (
                SqlConnection connection =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["RentalConnection"].ConnectionString))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        string query = "select * from Customer where Full_Name='" + name+ "'";
                        var command = new SqlCommand(query, connection) { CommandType = CommandType.Text };
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {


                            info.Id = reader.GetInt32(0);
                            info.FullName = reader.GetString(1);
                            info.Phone = reader.GetString(2);
                            info.Address = reader.GetString(3);
                            info.Email = reader.GetString(4);

                            //comp.Add(info);
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
            return info;
        }


        //    public class Auto
        //    {
        //        public int Id { get; set; }
        //        public string firstname { get; set; }
        //        public string lastname { get; set; }

        //        public List<Auto> getCustomerDetails()
        //        {
        //            List<Auto> AutoList = new List<Auto>();
        //            using (
        //            SqlConnection connection =
        //                new SqlConnection(ConfigurationManager.ConnectionStrings["RentalConnection"].ConnectionString))
        //            {
        //                try
        //                {
        //                    if (connection.State == ConnectionState.Closed)
        //                    {
        //                        connection.Open();
        //                        string query = "select Id,First_Name,Last_Name from dbo.Customer";
        //                        var command = new SqlCommand(query, connection) { CommandType = CommandType.Text };
        //                        var reader = command.ExecuteReader();
        //                        while (reader.Read())
        //                        {
        //                          var data = new Auto();
        //                            data.Id = (reader.GetInt32(0));
        //                            data.firstname = reader.GetString(1);
        //                            data.lastname = reader.GetString(2);
        //                            AutoList.Add(data);
        //                        }
        //                        reader.Close();
        //                        connection.Close();
        //                    }

        //                }
        //                catch (Exception exception)
        //                {
        //                    MessageBox.Show(exception.Message.ToString(), "Error", MessageBoxButton.OK,
        //                        MessageBoxImage.Exclamation);
        //                }

        //            }
        //            return AutoList;
        //        }

        //}

        public AutoCompleteStringCollection CustomerName()
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
                        string query = "select Full_Name from dbo.Customer where Delete_Status =0";
                        var command = new SqlCommand(query, connection) { CommandType = CommandType.Text };
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            nameSource.Add(reader.GetString(0));
                           // nameSource.Add(reader.GetString(1));
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



        //updating customer details
        public static void UpdateCustomer(string fullname, string phone, string address, string email, string id)
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
                        string query = "UPDATE dbo.Customer SET  Full_Name ='" + fullname + "'," +
                                       " Phone ='" + phone + "', Address ='" + address + "',Email ='" + email + "'" + " WHERE  Id ='" + id + "' ";
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



        //set item status to 1 on delete to hide customer from user
        //but customer still in the DB table for future audit

        public static void SetCustomerDeleteStatusToOne(string cid)
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
                        string query = "UPDATE dbo.Customer SET Delete_Status = 1 where Id='" + cid + "'";
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
