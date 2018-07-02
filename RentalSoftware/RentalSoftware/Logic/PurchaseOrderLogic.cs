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
    public class PurchaseOrderLogic
    {
        private static int oldQuanity;
        public static int OldQuantity { get; set; }

        public class Purchase
        {
            public string Id { get; set; }
            public string Pid { get; set; }
            public string VendorId { get; set; }
            public string ItemId { get; set; }
            public string UnitPric { get; set; }
            public int Quantity { get; set; }
            public string TotalCost { get; set; }
        }
    
        
      
        // inserting into purchase order table table
        public static void PurchaseOrder(string itemName, string vendor, string unitPrice,string quantity,string total)
        {
            ErrorWindow errM = new ErrorWindow();
            SuccessWindow sm = new SuccessWindow();

            if (!IsItemExist(itemName) || !IsVendorExist(vendor))
            {
                errM.Message = "OOPS!!! Item Name cannot be found, try again.";
                errM.Show();
            }

            if (!IsVendorExist(vendor))
            {
                errM.Message = "OOPS!!! Vendor Name cannot be found, try again.";
                errM.Show();
            }



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
                                "INSERT INTO dbo.Purchase_Order(Vendor_Id,Item_Id,Unit_Price,Quantity,Total)VALUES(" +
                                "(select Id from Vendor where Company_Name='" + vendor + "')," +
                                "(select Id from Item where Name = '" + itemName + "'), '" + unitPrice + "','" + quantity + "','" + total + "')";
                            var command = new SqlCommand(query, connection) { CommandType = CommandType.Text };
                            if (command.ExecuteNonQuery() > 0)
                            {
                                //command.ExecuteNonQuery();
                                sm.Message = "New item order is processed successfully.";
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

            //}
            //else
            //{
            //    errM.Message = "OOPS!!! Item Name or Vendor Name cannot be found.";
            //    errM.Show();

            //}
        }

        public static bool IsItemExist(string name)
        {
            bool isExist = false;

            using (
              SqlConnection connection =
                  new SqlConnection(ConfigurationManager.ConnectionStrings["RentalConnection"].ConnectionString))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        string query = "select Name from Item where Name='" + name + "'";
                        var command = new SqlCommand(query, connection);
                        var reader = command.ExecuteReader();
                        if (reader.Read())
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
                catch (Exception exception)
                {
                    isExist = false;

                }

            }
            return isExist;
        }


        //
        //checking for vendor company if exist
        public static bool IsVendorExist(string vendor)
        {
            bool isExist = false;

            using (
              SqlConnection connection =
                  new SqlConnection(ConfigurationManager.ConnectionStrings["RentalConnection"].ConnectionString))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        string query = "select Company_Name from Vendor where Company_Name='" + vendor + "'";
                        var command = new SqlCommand(query, connection);
                        var reader = command.ExecuteReader();
                        if (reader.Read())
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
                catch (Exception exception)
                {
                    isExist = false;

                }

            }
            return isExist;
        }


        // selecting the values in the purchase order table
        public static string SelectFields(string item)
        {
            string k = null;  
            using (
              SqlConnection connection =
                  new SqlConnection(ConfigurationManager.ConnectionStrings["RentalConnection"].ConnectionString))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        string query = "select Quantity from Item where Id='"+ item +"'";
                        var command = new SqlCommand(query, connection);
                        var reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                           
                        }
                      
                        connection.Close();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);

                }
            }
            return k;
        }


        //recieving purchase order query

        public static void RecievePurchase(string item, int quantity)
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
                        string query = "UPDATE dbo.Item SET  Quantity +='"+ quantity + "' where Id='"+ item +"'";
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



        //set purchase order status to 0 when item is recieved

        public static void SetPurchaseOderToZeroOnRecieve(string pid)
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
                        string query = "UPDATE dbo.Purchase_Order SET  Recieved_Status = 1 where Id='" + pid + "'";
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


        //selection of all purchase order from a view
        public DataTable GetAllPurchaseOrder()
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
                        string query = "select * from dbo.PurchaseOrder2 order by [PO #] desc";
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



        //selection of all purchase order before reecieve item from a view
        public DataTable GetAllPurchaseOrderBeforeRecieve()
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
                        string query = "select * from dbo.RecieveItem order by [PID #] desc";
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

    }
}
