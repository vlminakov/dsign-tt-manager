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

using DSingn_Content_Manager_cs;

namespace DSUI
{
    public partial class TimeLineControl : UserControl
    {
        private int duration;
        public Form1 delegateForm1 { get; set; }
        public string Date { get; set; }
        public string Start { get; set; }

        private List<PreviewItem> items;

        public List<PreviewItem> Items
        {
            get { return items; }
            set { items = value; }
        }

        public void Add(PreviewItem item)
        {
            this.items.Add(item);
        }

        public TimeLineControl()
        {
            InitializeComponent();
            Items = new List<PreviewItem>();
            this.duration = 0;
            this.durationLabel.Text = this.duration.ToString() + " сек.";
        }

        private void timelineContent_DragDrop(object sender, DragEventArgs e)
        {
            if (items == null)
                items = new List<PreviewItem>();
            PreviewItem item = (PreviewItem)e.Data.GetData(typeof(PreviewItem));
            flLayout.Controls.Add(item);
            Add(item);
            item.Dragged = true;
            this.duration += (int)Convert.ToDouble(item.Duration);
            this.durationLabel.Text = this.duration.ToString() + " сек.";
            item.TimelineDelegate = this;
        }

        private void timelineContent_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void timelineContent_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //save
            delegateForm1.saveTT();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            delegateForm1.asignPlayer();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            delegateForm1.copyCurrent(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            delegateForm1.copyAll();
        }

        public void setDay(DSingn_Content_Manager_cs.Day day)
        {
            if (flLayout.Controls.Count > 0)
                flLayout.Controls.Clear();
            if (Items.Count > 0)
                Items.Clear();
            dateTimePicker1.Text = day.StartTime;
            foreach (TTFileDesc fd in day.Files)
            {
                PreviewItem pi = new PreviewItem();
                pi.TimelineDelegate = this;
                pi.Dragged = true;
                pi.Type = fd.Type;
                pi.Duration = fd.Duration.ToString();
                this.duration += (int)Convert.ToDouble(pi.Duration);
                this.durationLabel.Text = this.duration.ToString() + " сек";
                pi.setText(fd.Name);
                string imgName = "";
                if (fd.Name.IndexOf(".mp4") != -1)
                {
                    imgName = fd.Name + "_preview.png";
                    pi.Type = Constants.PREVIEW_ITEM_TYPE_VIDEO;
                }
                else if (fd.Name.IndexOf(".mp3") != -1)
                {
                    imgName = "test.png";
                    pi.Type = Constants.PREVIEW_ITEM_TYPE_AUDIO;
                }
                else
                {
                    imgName = fd.Name;
                    pi.Type = Constants.PREVIEW_ITEM_TYPE_IMAGE;
                }
                try
                {
                    Image img = Image.FromFile("images\\" + imgName);
                    pi.setImage(img);
                    pi.Width = 100;
                    flLayout.Controls.Add(pi);
                    Add(pi);
                }
                catch (Exception e)
                {
                    
                }
                
                
            }
        }

        public DSingn_Content_Manager_cs.Day getDay()
        {
            DSingn_Content_Manager_cs.Day day = new DSingn_Content_Manager_cs.Day();
            day.StartTime = dateTimePicker1.Text;
            day.Date = "";
            day.Cycled = false;
            day.Files = new List<TTFileDesc>();
            foreach(PreviewItem pi in flLayout.Controls){
                TTFileDesc fd = new TTFileDesc();
                fd.Name = pi.getText();
                fd.Duration = (int)Convert.ToDouble(pi.Duration);
                fd.Type = pi.Type;
                day.Files.Add(fd);
            }

            return day;
        }

        private void controllAdded(object sender, ControlEventArgs e)
        {
            timeline_panel.ScrollControlIntoView(e.Control);
        }

        public void addImageDuration(int duration)
        {
            this.duration += duration;
            this.durationLabel.Text = this.duration.ToString() + " сек";
        }

        public void Clear()
        {
            flLayout.Controls.Clear();
            this.Items.Clear();
            this.Date = "";
            this.Start = "";
            this.duration = 0;
            this.durationLabel.Text = this.duration.ToString() + " сек";
            this.dateTimePicker1.ResetText();
        }
    }
}
