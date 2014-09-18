using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace DSUI
{
    public partial class MyPanel : Panel
    {
        private Pen pen;
        private Font fnt;

        private int lines;
        private int lineStep;
        private int secondsInStep;
        private int secondsValue;
        private int startSecondsValue;
        private int seconds;
        private int firstLineY;

        public MyPanel(): base()
        {
            pen = new Pen(Color.Black, 1.0F);
            fnt = new Font(new FontFamily("Tahoma"), 10, FontStyle.Regular, GraphicsUnit.Pixel);
            seconds = 24 * 60 * 60;
            lineStep = 10; // in pixels
            lines = this.Height / lineStep;
            secondsInStep = 60; // initial value arranged to 1 minute
            startSecondsValue = 0;
            firstLineY = 10;
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
            Debug.WriteLine(e.Delta.ToString());
            if (Form.ModifierKeys == Keys.Control)
            {
                if (e.Delta > 0)
                {
                    if (secondsInStep > 1)
                    {
                        secondsInStep -= 1;
                    }
                    else
                        return;
                }
                else if (e.Delta < 0)
                {
                    if (secondsInStep < 60)
                    {
                        secondsInStep += 1;
                    }
                    else
                        return;
                }
                Debug.WriteLine(secondsInStep.ToString());
                DrawMesh();
                return;
            }

            int c = e.Delta / Math.Abs(e.Delta);
            startSecondsValue += secondsInStep * c;
            DrawMesh();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.Focus();
            Debug.WriteLine(this.Focused.ToString());
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.Parent.Focus();
            Debug.WriteLine(this.Focused.ToString());
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.DrawMesh();
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);

        }

        private void DrawMesh()
        {
            lines = Height / lineStep;
            Graphics gr = CreateGraphics();
            gr.Clear(Color.White);
            for (int i = 0; i < lines; i++)
            {
                secondsValue = startSecondsValue + i * secondsInStep;
                gr.DrawLine(pen, new Point(0, firstLineY + lineStep * i), new Point(10, firstLineY + lineStep * i));
                gr.DrawString(secondsValue.ToString(), fnt, Brushes.Black, new PointF(12, (firstLineY + lineStep * i) - 5));
            }

            gr.Dispose();
        }
    }
}
