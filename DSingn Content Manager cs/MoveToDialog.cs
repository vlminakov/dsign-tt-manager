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
    public partial class MoveToDialog : Form
    {
        private List<TreeNode> _nodes;
        public List<TreeNode> Nodes
        {
            get
            {
                return this._nodes;
            }

            set
            {
                this._nodes = (List<TreeNode>)value;
                foreach (TreeNode node in this._nodes)
                    this.listView1.Items.Add(node.Text);
            }
        }
        
        public MoveToDialog()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Form1)this.Owner).MovePlayerToGroup(this.listView1.SelectedItems[0].Text);
            this.Close();
        }
    }
}
