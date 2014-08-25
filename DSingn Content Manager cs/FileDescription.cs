using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSingn_Content_Manager_cs
{
    class FileDescription
    {
        public string name { get; set; }
        public string path { get; set; }
        public string duration { get; set; }
        public string type { get; set; }
        public PreviewDescription preview { get; set; }
    }
}
