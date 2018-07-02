using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RentalSoftware.Logic
{
    public class CompanyLogic
    {
        //private static int id;
        //private static string companyName;
        //private static string phone;
        //private static string address;

        //public static int Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}

        //public static string CompanyName
        //{
        //    get { return companyName; }
        //    set { companyName = value; }
        //}

        //public static string Phone
        //{
        //    get { return phone; }
        //    set { phone = value; }
        //}

        //public static string Address
        //{
        //    get { return address;}
        //    set { address = value; }
        //}
       // private static string companyName;
        public class Company
        {
            public int Id { get; set; }
            public string CompanyName { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
           // public byte Photo { get; set; }
            public string Terms { get; set; }


        }

        //selecting company details
        //public static string GetCompanyInfo()
        //{
        //    //string name = null;

        //    using (
        //        SqlConnection connection =
        //            new SqlConnection(ConfigurationManager.ConnectionStrings["RentalConnection"].ConnectionString))
        //    {
        //        try
        //        {
        //            if (connection.State == ConnectionState.Closed)
        //            {
        //                connection.Open();
        //                string query = "slect * from Company_Info";
        //                var command = new SqlCommand(query, connection) { CommandType = CommandType.Text };
        //                var reader = command.ExecuteReader();
        //                while (reader.Read())
        //                {

        //                    Id = reader.GetInt32(0);
        //                    companyName = reader.GetString(1);
        //                    Phone = reader.GetString(2);
        //                    Address = reader.GetString(3);
        //                }
        //                reader.Close();
        //                connection.Close();

        //            }

        //        }
        //        catch (Exception exception)
        //        {
        //            MessageBox.Show(exception.Message.ToString(), "Error", MessageBoxButton.OK,
        //                MessageBoxImage.Exclamation);
        //        }
        //        return CompanyName;
        //    }

        //}

        public Company GetCompanyInfo()
        {
           
            var info = new Company();
            using (
                SqlConnection connection =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["RentalConnection"].ConnectionString))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        string query = "select * from Company_Info";
                        var command = new SqlCommand(query, connection) { CommandType = CommandType.Text };
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {


                            info.Id = reader.GetInt32(0);
                            info.CompanyName = reader.GetString(1);
                            info.Phone = reader.GetString(2);
                            info.Address = reader.GetString(3);

                           // info.Photo = reader.GetByte(4);
                           // MemoryStream str = new MemoryStream();
                           // str.Write(new[] {info.Photo}, 0, info.Photo);
                           // Bitmap bit = new Bitmap(str);
                           //// info.Photo = reader.GetSqlBinary(4);
                            info.Terms = reader.GetString(4);

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



        //updating company info details
        public static void UpdateCompanyInfo(string companyname,string phone,string address,string terms, string id)
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
                        string query = "UPDATE dbo.Company_Info SET  Company_Name ='" + companyname + "' , Phone ='" + phone + "',Address ='" + address + "',Terms_And_Conditions ='" + terms + "' where Id ='" + id + "'";
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
        /////////..............
    }
}
