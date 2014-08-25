using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DSUI;

namespace DSingn_Content_Manager_cs
{
    public partial class Day
    {
        public string Date { get; set; }
        public string StartTime { get; set; }
        public bool Cycled { get; set; }
        public List<TTFileDesc> Files { get; set; }
    }
}
