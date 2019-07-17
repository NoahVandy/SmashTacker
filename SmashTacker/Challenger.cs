using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmashTacker
{
    public class Challenger
    {
        public string name { get; set; }
        public string main { get; set; }
        public int BP { get; set; }
        public double KDA { get; set; }

        public Challenger(string name, string main, int BP, double KDA)
        {
            this.name = name;
            this.main = main;
            this.BP = BP;
            this.KDA = KDA;

        }


    }
}
