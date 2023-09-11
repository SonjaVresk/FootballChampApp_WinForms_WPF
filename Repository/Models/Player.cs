using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Player : IComparable<Player>
    {
        public Player()
        {
            
        }

        public Player(string name, int number, string position, int goals, int yellowCards)
        {
            Name = name;
            this.Number = number;
            Position = position;
            Goals = goals;
            YellowCards = yellowCards;
        }


        public string? Name { get; set; }
        public int Number { get; set; }
        public string? Position { get; set; }
        public int Goals { get; set; }
        public int YellowCards { get; set; }

        public int CompareTo(Player other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
