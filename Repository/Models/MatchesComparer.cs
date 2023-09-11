using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class MatchesComparer : IComparer<Match>
    {
        public int Compare(Match? x, Match? y)
        {
            return -x.Attendance.CompareTo(y.Attendance);
        }
    }
}
