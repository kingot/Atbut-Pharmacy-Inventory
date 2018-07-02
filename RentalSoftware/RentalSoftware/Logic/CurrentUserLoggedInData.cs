using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalSoftware.Logic
{
    class CurrentUserLoggedInData
    {
        private static int Id;
        private static string First_Name;
        private static string Last_Name;
        private static string Username;
        private static string Password;
        private static int Role_Id;
        public static bool IsLoaded { get; set; }

        public static void ClearUserData()
        {
            id = 0;
            FirstName = null;
            LastName = null;
            UserName = null;
            role_id = 0;
        }

        public static int id
        {
            get
            {
                return Id;
            }

            set
            {
                Id = value;
            }
        }

        public static string FirstName
        {
            get
            {
                return First_Name;
            }

            set
            {
                First_Name = value;
            }
        }

        public static string LastName
        {
            get
            {
                return Last_Name;
            }

            set
            {
                Last_Name = value;
            }
        }

        public static string UserName
        {
            get
            {
                return Username;
            }

            set
            {
                Username = value;
            }
        }

        public static string password
        {
            get
            {
                return Password;
            }

            set
            {
                Password = value;
            }
        }

        public static int role_id
        {
            get
            {
                return Role_Id;
            }

            set
            {
                Role_Id = value;
            }
        }
    }
}
