using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSUI
{
    public partial class TimeLineMesh : UserControl
    {
        private int lineY;
        private int lineW;
        private int step;
        private int secAmount;
        private Pen pen;
        private Font font;
        private List<Panel> panels;

        public TimeLineMesh()
        {
            InitializeComponent();
            this.lineY = 10;
            this.lineW = 10;
            this.step = 10;
            this.secAmount = 24 * 60 * 60;
            this.pen = new Pen(Color.Black, 1);
            this.font = new Font("Times New Roman", 8);
            this.panels = new List<Panel>();
            this.panels.Add(this.createPanel());
        }

        private void drawMesh(Graphics graphics, int height)
        {
            graphics.Clear(Color.White);
            int lines = secAmount / 10;
            int secondsInOneStep = secAmount / lines;
            int secondscount = 0;
            for (int i = lineY; i <= height; i += step)
            {
                string text = (secondsInOneStep * secondscount).ToString();
                graphics.DrawString(text, font, Brushes.Black, new PointF(2, i - (font.GetHeight() / 2)));
                graphics.DrawLine(pen, new Point((int)graphics.MeasureString(text, font).Width + 2, i), new Point((int)graphics.MeasureString(text, font).Width + 2 + lineW, i));
                secondscount++;
            }
            graphics.Dispose();
        }

        private Panel createPanel()
        {
            Panel pnl = new Panel();
            pnl.Dock = DockStyle.Top;
            pnl.Tag = 0;

            return pnl;
        }
        //onPaint(sender, new PaintEventArgs(panel2.CreateGraphics(), panel2.RectangleToClient(new Rectangle(panel2.Location, panel2.Size))));
    }
}
