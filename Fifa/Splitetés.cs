using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifa
{
    class csapat
    {


        public string csnev { get; set; }
        public int helyezés { get; set; }
        public int valtozas { get; set; }
        public int pont { get; set; }
        public csapat(string sor)
        {
            string[] s = sor.Split(';');
            csnev = s[0];
            helyezés = int.Parse(s[1]);
            valtozas = int.Parse(s[2]);
            pont = int.Parse(s[3]);
        }
    }
}
