using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTrackerWF
{
    class CSVStorage : ITimeTrackStorage
    {


        public void addTimeTrackEntry(TimeTrackEntry timetrackentry)
        {
            throw new NotImplementedException();
        }

        public List<TimeTrackEntry> getTimeTrackEntries(DateTime day)
        {
            throw new NotImplementedException();
        }

        public static TimeTrackEntry CreateTimeEntryFromCSV(String csvline)
        {
            DateTime start = new DateTime();
            DateTime end = new DateTime();
            String category = "";
            String comment ="";
            if (csvline.Length > 0)
            {
                string[] values = csvline.Split(',');
                start  = Convert.ToDateTime(values[0]);
                end = Convert.ToDateTime(values[1]);
                category = values[2];
                if (values.Length > 2)
                {
                    comment = values[3];
                }
            }
            return new TimeTrackEntry(start, end, category, comment);
        }
    }
}
