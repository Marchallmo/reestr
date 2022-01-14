using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class Notification
    {
        public static DateTime MonthAndYear { get; set; }

        public static string Location { get; set; }

        public static Statuses OldStatus { get; set; }

        public static Statuses NewStatus { get; set; }

        public enum Statuses
        {
            Unfinished = 1,
            ConsultingInOrg = 2,
            ConfirmingInOrg = 3,
            ConsultingInOMSU = 4,
            ConfirmingInOMSU = 5
        }

        public static DateTime StatusChangeDate { get; set; }

        public static User User { get; set; }

        public static string Comment { get; set; }

        public Notification(DateTime mNy, string loc, Statuses OldS, Statuses NewS, DateTime sCd, User user, string comment)
        {
            MonthAndYear = mNy;
            Location = loc;
            OldStatus = OldS;
            NewStatus = NewS;
            StatusChangeDate = sCd;
            User = user;
            Comment = comment;
        }
    }
}
