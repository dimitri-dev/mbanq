using System;

namespace PersonManagement.Common
{
    public class DateTimeRange
    {
        public DateTime DateTimeFrom { get; set; }
        public DateTime DateTimeTo { get; set; }

        public DateTimeRange(DateTime t1, DateTime t2)
        {
            if (t1 > t2)
            {
                DateTimeFrom = t2;
                DateTimeTo = t1;
            }
            else
            {
                DateTimeFrom = t1;
                DateTimeTo = t2;
            }
        }
    }
}
