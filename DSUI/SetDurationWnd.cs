using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSUI
{
    public partial class SetDurationWnd : Form
    {
        public PreviewItem _delegate { get; set; }

        public SetDurationWnd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _delegate.setDuration(textBox1.Text);
            Close();
        }
    }
}
