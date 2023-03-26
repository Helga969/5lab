using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5lab.Model
{
    class Autobase
    {
        public int IdAutobase { get; set; }
        public string Name { get; set; }
        public Autobase() { }
        public Autobase(int id, string nm)
        {
            IdAutobase = id;
            Name = nm;
        }
    }
}
