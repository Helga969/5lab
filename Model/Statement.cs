using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5lab.Model
{
    class Statement
    {
        public int IdStatement { get; set; }
        public string Date { get; set; }
        public int Driver { get; set; }

        public int Auto { get; set; }
        public int Garage { get; set; }
        public int Autobase { get; set; }
        public string Flue { get; set; }
        public float Volume { get; set; }
        public Statement() { }
        public Statement(int id, string dt, int drvr, int aut, int grg, int autb, string fl, float vol)
        {
            IdStatement=id; 
            Date=dt;
            Driver=drvr;
            Auto=aut;
            Garage=grg;
            Autobase=autb;
            Flue=fl;
            Volume=vol;
        }
    }
}
