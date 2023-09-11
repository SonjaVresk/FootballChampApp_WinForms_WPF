using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class PlayersYellowCardsComparer : IComparer<Player>
    {
        public int Compare(Player? x, Player? y)
        {
            return -x.YellowCards.CompareTo(y.YellowCards);
        }
    }
}
