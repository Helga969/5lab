using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5lab.Model
{
    class Auto
    {
        public int IdAuto { get; set; }
        public string Number { get; set; }
        public Auto() { }
        public Auto(int id, string num)
        {
            IdAuto = id;
            Number = num;
        }
    }
}
