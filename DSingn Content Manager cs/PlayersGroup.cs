using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSingn_Content_Manager_cs
{
    public class PlayersGroup
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<Player> players { get; set; }

        public void addPlayer(Player p)
        {
            if (players == null)
                players = new List<Player>();
            players.Add(p);
        }
    }
}
