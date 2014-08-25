using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSingn_Content_Manager_cs
{
    public partial class PlayersListWnd : Form
    {
        public PlayersListWnd(List<DSTreeNode> nodes)
        {
            InitializeComponent();
            foreach (DSTreeNode tn in nodes)
            {
                this.treeView1.Nodes.Add(tn);
            }
        }

        private void mouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Point pt = treeView1.PointToScreen(new Point(e.X, e.Y));
            DSTreeNode selectedNode = (DSTreeNode)this.treeView1.SelectedNode; //(DSTreeNode)treeView1.GetNodeAt(pt);
            if (selectedNode.Nodes.Count == 0)
            {
                ((Form1)this.Owner).set_ass_player(selectedNode.playerId);
                this.Close();
            }
        }
    }
}
