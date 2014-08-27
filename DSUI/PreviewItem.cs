using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

//using DSingn_Content_Manager_cs;

namespace DSUI
{
    public partial class PreviewItem : UserControl, ICloneable
    {
        public TimeLineControl TimelineDelegate { get; set; }

        public bool dragged { get; set; }
        public bool Selected { get; set; }


        public bool Dragged
        {
            get { return dragged; }
            set { dragged = value; }
        }

        private int type;
        private string duration;

        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public int Type
        {
            get { return type; }
            set { type = value; }
        }


        public PreviewItem()
        {
            InitializeComponent();
        }

        public PreviewItem(PreviewItem previewItem)
        {
            InitializeComponent();
            Type = previewItem.Type;
            Duration = previewItem.Duration;
            Dragged = previewItem.Dragged;
            setImage(previewItem.getImage());
            setText(previewItem.getText());
        }

        public void setText(string text)
        {
            this.label1.Text = text;
        }

        public void setImage(Image img)
        {
            this.pictureBox1.Image = img;
        }

        private void qweqwe(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Left))
            {
                if (!dragged)
                {
                    DoDragDrop(this.Clone(), DragDropEffects.Copy);
                }
                else
                {
                    if (!Selected)
                    {
                        Selected = true;
                        BackColor = Color.DarkGray;
                    }
                    else
                    {
                        Selected = false;
                        BackColor = Color.White;
                    }
                }
            }
        }

        public string getText()
        {
            return this.label1.Text;
        }

        public Image getImage()
        {
            return this.pictureBox1.Image;
        }

        public object Clone()
        {
            return new PreviewItem(this);
        }

        public void setDuration(string duration)
        {
            this.Duration = duration;
            if (this.TimelineDelegate != null)
                this.TimelineDelegate.addImageDuration(Convert.ToInt32(this.Duration));
        }
    }
}
