using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5lab.Model
{
    class Driver
    {
        public int IdDriver { get; set; }
        public string FIO { get; set; }
        public Driver() { }
        public Driver(int id, string fio)
        {
            IdDriver = id;
            FIO = fio;
        }
    }
}
