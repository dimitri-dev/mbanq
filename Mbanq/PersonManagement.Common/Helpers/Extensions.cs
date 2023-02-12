using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement.Common
{
    public static class Extensions
    {
        public static bool IsNullOrEmpty(this string str)
        {
            if (str == null || str.Length == 0) return true;
            else return false;
        }

        public static bool IsInRange(this DateTime dateTime, DateTimeRange range)
        {
            if (dateTime == null || range == null) return false;
            if (range.DateTimeFrom == null || range.DateTimeTo == null) return false;

            if (range.DateTimeFrom <= dateTime && dateTime <= range.DateTimeTo) return true;
            else return false;
        }
    }
}
