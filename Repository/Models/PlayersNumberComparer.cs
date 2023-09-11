using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class PlayersNumberComparer : IComparer<Player>
    {
        public int Compare(Player? x, Player? y)
        {
            return x.Goals.CompareTo(y.Goals);
        }
    }
}
