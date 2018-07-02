using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalSoftware.Logic
{
    class MakeSaleLogic
    {

        // inserting into purchase order table table
        public static void Ordering(string customer, string itemName, string user, string quantity,string discount, string totalCost)
        {
            ErrorWindow errM = new ErrorWindow();
            SuccessWindow sm = new SuccessWindow();

            if (!IsItemExist(itemName))
            {
                errM.Message = "OOPS!!! Item Name cannot be found, try again.";
                errM.Show();
            }

            //if (!IsQuantityZero(itemName))
            //{
            //    errM.Message = "OOPS!!! Some Item may have zero quantity, check available quantity and try again.";
            //    errM.Show();
            //}

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
                        string query = "INSERT INTO [dbo].[Order](Customer_Id,Item_Id,User_Id,Quantity,Discount,Total_Cost)VALUES((select Id from Customer where Full_Name = '" + customer+"'),(select Id from Item where Name = '"+itemName+"'), '"+user+"','"+quantity+ "','" + discount + "','" + totalCost+"')";

                        var command = new SqlCommand(query, connection) { CommandType = CommandType.Text };
                        if (command.ExecuteNonQuery() > 0)
                        {
                            //command.ExecuteNonQuery();
                          
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

        public static bool IsQuantityZero(string name)
        {
            bool isZero = false;

            using (
              SqlConnection connection =
                  new SqlConnection(ConfigurationManager.ConnectionStrings["RentalConnection"].ConnectionString))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        string query = "select Name,Quantity from Item where Name='"+ name +"'And Quantity > 0";
                        var command = new SqlCommand(query, connection);
                        var reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            isZero = true;
                        }
                        else
                        {
                            isZero = false;
                        }
                        connection.Close();
                    }
                }
                catch (Exception exception)
                {
                    isZero = false;

                }
            }
            return isZero;
        }

        //
    }
}
