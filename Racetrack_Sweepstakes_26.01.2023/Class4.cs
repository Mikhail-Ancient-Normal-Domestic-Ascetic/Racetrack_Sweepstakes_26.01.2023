using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racetrack_Sweepstakes_26._01._2023
{
    internal class Parlay
    {
        public string Horse { get; set; }
        public int sum { get; set; }
        public Parlay(string horse, int sum)
        { 
            Horse = horse;
            this.sum = sum;
        }
        string getHorse()
        {
            return Horse;
        }
        int getSum()
        {
            return sum;
        }
    }
}
