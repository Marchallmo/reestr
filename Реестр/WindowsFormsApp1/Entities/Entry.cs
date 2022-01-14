using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class Entry
    {
        public static int ID { get; set; }

        public static DateTime MonthAndYear { get; set; }

        public static Statuses Status { get; set; } 

        public enum Statuses
        {
            Unfinished = 1,
            ConsultingInOrg = 2,
            ConfirmingInOrg = 3,
            ConsultingInOMSU = 4,
            ConfirmingInOMSU = 5
        }

        public static DateTime StatusChangeDate { get; set; }

        public Entry(int id, DateTime monthAndYear, Statuses status, DateTime statusChangeDate)
        {
            ID = id;
            MonthAndYear = monthAndYear;
            Status = status;
            StatusChangeDate = statusChangeDate;
        }
    }
}
