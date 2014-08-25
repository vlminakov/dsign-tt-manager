using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DSUI
{
    public class DSPictureBox : PictureBox
    {
        public string filename { get; set; }

        public DSPictureBox() : base()
        {
            
        }
    }
}
