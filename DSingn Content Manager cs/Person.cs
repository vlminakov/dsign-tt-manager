using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Drawing;

namespace DSingn_Content_Manager_cs
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DOfBirth { get; set; }
        public string Work { get; set; }
        public int Age { get; set; }
        public byte[] Avater { get; set; }
    }
}
