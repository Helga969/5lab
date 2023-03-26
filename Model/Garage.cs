using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5lab.Model
{
    class Garage
    {
        public int IdGarage { get; set; }
        public string Address { get; set; }
        public Garage() { }
        public Garage(int id, string adrs)
        {
            IdGarage = id;
            Address = adrs;
        }
    }
}
