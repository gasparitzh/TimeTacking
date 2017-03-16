using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTrackerWF
{
    interface ITimeTrackStorage
    {
        //Add an entry to the storage
        void addTimeTrackEntry(TimeTrackEntry timetrackentry);
        //Get a list of TimeTrackEntries of a specific day
        List<TimeTrackEntry> getTimeTrackEntries(DateTime day);

    }
}
