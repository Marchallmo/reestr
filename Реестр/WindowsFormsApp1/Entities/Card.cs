using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class Card
    {
        public static DateTime MonthAndYear { get; set; }

        public static string Location { get; set; }

        public static Statuses Status { get; set; }

        public enum Statuses
        {
            Unfinished = 1,
            ConsultingInOrg = 2,
            ConfirmingInOrg = 3,
            ConsultingInOMSU = 4,
            ConfirmingInOMSU = 5
        }

        public static EndStatuses EndStatus { get; set; }

        public enum EndStatuses
        {
            Declined = 1,
            ORGconsulted = 2,
            ORGconfirmed = 3,
            OMSUconsulted = 4,
            OMSUconfirmed = 5
        }

        public static DateTime StatusChangeDate { get; set; }

        public static User User { get; set; }

        public static string Comment { get; set; }

        public Dictionary<User, EndStatuses> ChangeLog { get; set; }

        public static List<User> Recipients { get; set; }

    }
}
