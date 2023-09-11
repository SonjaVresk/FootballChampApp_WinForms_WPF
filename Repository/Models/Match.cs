using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Match
    {
        public Match(string location, int attendance, string homeTeam, string awayTeam)
        {
            Location = location;
            Attendance = attendance;
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
        }

        public string Location { get; set; }

        public int Attendance { get; set; }

        public string HomeTeam { get; set; }

        public string AwayTeam { get; set; }

      
    }
}
