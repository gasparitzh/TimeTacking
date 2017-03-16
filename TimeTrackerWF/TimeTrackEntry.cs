using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTrackerWF
{
    class TimeTrackEntry
    {
        public DateTime Start { get; }
        public DateTime End { get; }
        public String Category { get; }
        public String Comment { get; }

        public TimeTrackEntry(DateTime start, DateTime end, string category, string comment)
        {
            Start = start;
            End = end;
            Category = category;
            Comment = comment;
        }

        public TimeTrackEntry(TimeTrackEntry entry) : this(entry.Start, entry.End, entry.Category, entry.Comment) { }

        public override string ToString()
        {
            return String.Format("Start: {0}, End: {1}, Category: {2}, Comment {3}", Start.ToString(), End.ToString(), Category.ToString(), Comment.ToString());
        }



    }
}
