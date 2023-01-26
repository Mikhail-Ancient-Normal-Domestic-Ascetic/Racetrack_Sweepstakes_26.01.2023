using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racetrack_Sweepstakes_26._01._2023
{
    internal class Client : User
    {
        private List<Parlay> parlays = new List<Parlay>();
        public Client(string name, string login, string password) : base(name, login, password)
        {

        }
        public void addParlay(string horce,int sum)
        {
            parlays.Add(new Parlay(horce,sum));
        }
        public void clearParlay()
        {
            parlays.Clear();
        }
        public void getParlay()
        {
            parlays.Clear();
        }
    }
}
