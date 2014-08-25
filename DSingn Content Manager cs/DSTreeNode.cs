using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSingn_Content_Manager_cs
{
    public class DSTreeNode : TreeNode, ICloneable
    {
        //public bool isGroup { get; set; }
        public PlayersGroup plGroup { get; set; }
        public List<Player> players { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public int playerId { get; set; }
        public Player player { get; set; }

        public DSTreeNode(string name, string desc): base(name + "   " + desc)
        {
            this.name = name;
            this.desc = desc;
            this.players = new List<Player>();
        }

        public DSTreeNode(DSTreeNode node)
        {
            this.plGroup = node.plGroup;
            this.players = node.players;
            this.name = node.name;
            this.desc = node.desc;
            this.playerId = node.playerId;
            this.player = node.player;
            Text = node.Text;
        }

        public void addPlayer(Player p)
        {
            this.players.Add(p);
        }

        public DSTreeNode Clone()
        {
            DSTreeNode clone = new DSTreeNode(this);
            
            return clone;
        }
    }
}
