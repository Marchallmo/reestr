using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class User
    {
        public static string Username { get; set; }

        public static Roles Role { get; set; }
        public enum Roles
        {
            ORGoperator = 1,
            ORGcurator = 2,
            ORGsigner = 3,
            OMSUoperator = 4,
            OMSUcurator = 5,
            OMSUsigner = 6,
            VETuser = 7
        }

        public User(string username, Roles role)
        {
            Username = username;
            Role = role;
        }
    }
}
