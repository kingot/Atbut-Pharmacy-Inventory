using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace RentalSoftware.Logic
{
    public class ItemLogic
    {
       // ErrorWindow errM= new ErrorWindow();
        //adding new category
        public static void AddCategory(string categoryName, string description)
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
                        string query = "INSERT INTO dbo.Category(Category_Name,Description)VALUES('" + categoryName + "','" + description + "')";
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

        //getting the category names for our combobox when adding item
        //public DataTable GetAllCategoryNames()
        //{
        //    var data = new DataTable();
        //    using (
        //        SqlConnection connection =
        //            new SqlConnection(ConfigurationManager.ConnectionStrings["RentalConnection"].ConnectionString))
        //    {
        //        try
        //        {
        //            if (connection.State == ConnectionState.Closed)
        //            {
        //                connection.Open();
        //                string query = "select Category_Name from Category";
        //                var dataAdapter = new SqlDataAdapter(query, connection);
        //                dataAdapter.Fill(data);
        //                connection.Close();
        //            }
        //        }
        //        catch (Exception exception)
        //        {
        //            MessageBox.Show(exception.Message.ToString(), "Error", MessageBoxButton.OK,
        //                MessageBoxImage.Exclamation);
        //        }
        //        return data;
        //    }

        //}


        //getting the category names for our combobox when adding item
        public AutoCompleteStringCollection CategoryName()
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
                        string query = "select Category_Name from dbo.Category";
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


        //getting the item names for our combobox when adding item
        public AutoCompleteStringCollection ItemName()
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
                        string query = "select Name from dbo.Item where Delete_Status=0";
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


        


        //checking if the category name exits--checking for boolean
        //this function will help if category names becomes much and i enable isEditable 
        //in the combobox input
        public static bool IsCategoryExist(string category)
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
                        string query = "select Category_Name from Category where Category_Name='" + category + "'";
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



        //checking if the Item name exits--checking for boolean
        //this function will help if Item names becomes much and i enable isEditable 
        //in the combobox input
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


        // inserting into item table
        public static void AddBrokenItem(string name, string quantity, string comment)
        {
            ErrorWindow errM = new ErrorWindow();
            SuccessWindow sm = new SuccessWindow();
            if (IsItemExist(name))
            {

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
                                "INSERT INTO dbo.Damage_Item(Item_Id,Quantity,Comment)VALUES(" +
                                "(select Id from Item where Name='" + name + "'), '" + quantity + "'," +
                                "'" + comment + "')";
                            var command = new SqlCommand(query, connection) { CommandType = CommandType.Text };
                            if (command.ExecuteNonQuery() > 0)
                            {
                                //command.ExecuteNonQuery();
                                sm.Message = "Damage item is recorded Successfully.";
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
            else
            {
                errM.Message = "OOPS!!! Item Name cannot be found.";
                errM.Show();

            }
        }



        // update item stock..by returning rented item back to stock
        public static void ReturnItem(string name, string quantity, string id)
        {
            ErrorWindow errM = new ErrorWindow();
            SuccessWindow sm = new SuccessWindow();
            if (IsItemExist(name))
            {

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
                                "UPDATE dbo.Item SET  Quantity +='" + quantity + "' where Id='" + id + "'";
                            var command = new SqlCommand(query, connection) { CommandType = CommandType.Text };
                            if (command.ExecuteNonQuery() > 0)
                            {
                                //command.ExecuteNonQuery();
                                sm.Message = "Item return is successfully added to stock.";
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
            else
            {
                errM.Message = "OOPS!!! Item Name cannot be found.";
                errM.Show();

            }
        }


        // inserting into item table
        public static void AddNewItem(string category,string vendor, string name, string description, string unitPrice, string quantity)
        {
            ErrorWindow errM = new ErrorWindow();
            SuccessWindow sm = new SuccessWindow();
            if (IsCategoryExist(category) || IsVendorExist(vendor))
            {

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
                                "INSERT INTO dbo.Item(Category_Id,Vendor_Id,Name,Description,Unit_Price,Quantity)VALUES(" +
                                "(select Id from Category where Category_Name='" + category + "')," +
                                "(select Id from Vendor where Company_Name = '" + vendor + "'), '" + name + "'," +
                                "'" + description + "','" + unitPrice + "','" + quantity + "')";
                            var command = new SqlCommand(query, connection) { CommandType = CommandType.Text };
                            if (command.ExecuteNonQuery() > 0)
                            {
                                //command.ExecuteNonQuery();
                                sm.Message = "New Item is saved Successfully.";
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
            else
            {
                errM.Message = "OOPS!!! Category Name or Vendor Name cannot be found.";
                errM.Show();

            }
        }




        //retrieve item data into category datagrid view
        //selection of all items from a view
        public DataTable GetAllItems()
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
                        string query = "select * from dbo.ItemList order by [Item #] desc";
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

        
        //getting and setting values from the datagridview

        public class Item
        {
            public string Id { get; set; }
            public string CategoryId { get; set; }
            public string Vendor { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string UnitePric { get; set; }
            public string Quantity { get; set; }
            public string Date { get; set; }
        }


        public class ItemOrder
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public SqlMoney UnitePrice { get; set; }
            public int Quantity { get; set; }
          
        }


        public ItemOrder GeItemInfo(string name)
        {

            var info = new ItemOrder();
            using (
                SqlConnection connection =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["RentalConnection"].ConnectionString))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        string query = "select Id,Unit_Price,Quantity from Item where Name='" + name + "'";
                        var command = new SqlCommand(query, connection) { CommandType = CommandType.Text };
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {

                            info.Id = reader.GetInt32(0);
                            info.UnitePrice = reader.GetSqlMoney(1);
                            info.Quantity = reader.GetInt32(2);

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

        //updating item table
        public static void UpdateItem(string itemName, string description, double? unitPrice, double? quantity, string id)
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
                        string query = "UPDATE dbo.Item SET  Name ='" + itemName + "' , Description ='" + description + "'," +
                                       " Unit_Price ='" + unitPrice + "', Quantity ='" + quantity + "' WHERE  Id ='" + id + "' ";
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


        //updating the item price from references link
        // inserting into item table
        public static void UpdatePrice(string name, decimal price)
        {
            ErrorWindow errM = new ErrorWindow();
            SuccessWindow sm = new SuccessWindow();
            if (IsItemExist(name))
            {

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
                                "UPDATE dbo.Item SET Unit_Price='"+price + "' WHERE Name=(select Id from Item where Name='" + name + "')";
                            var command = new SqlCommand(query, connection) { CommandType = CommandType.Text };
                            if (command.ExecuteNonQuery() > 0)
                            {
                                //command.ExecuteNonQuery();
                                sm.Message = "Item price updated Successfully.";
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
            else
            {
                errM.Message = "OOPS!!! Item Name cannot be found.";
                errM.Show();

            }
        }


        //set item status to 1 on delete to hide item from user
        //but item still in the DB table for future audit

        public static void SetItemDeleteStatusToOne(string id)
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
                        string query = "UPDATE dbo.Item SET Delete_Status = 1 where Id='" + id + "'";
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


        ///////////

        //public static bool IsQuantityZero(string name)
        //{
        //    bool isZero = false;

        //    using (
        //      SqlConnection connection =
        //          new SqlConnection(ConfigurationManager.ConnectionStrings["RentalConnection"].ConnectionString))
        //    {
        //        try
        //        {
        //            if (connection.State == ConnectionState.Closed)
        //            {
        //                connection.Open();
        //                string query = "select Name,Quantity from Item where Name='" + name + "'And Quantity > 0";
        //                var command = new SqlCommand(query, connection);
        //                var reader = command.ExecuteReader();
        //                if (reader.Read())
        //                {
        //                    isZero = true;
        //                }
        //                else
        //                {
        //                    isZero = false;
        //                }
        //                connection.Close();
        //            }
        //        }
        //        catch (Exception exception)
        //        {
        //            isZero = false;

        //        }
        //    }
        //    return isZero;
        //}


        //
    }


}
