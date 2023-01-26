using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racetrack_Sweepstakes_26._01._2023
{
    internal class User
    {
        string name { get; set; }
        string login { get; set; }
        string password { get; set; }

        public User(string name, string login, string password)
        {
            this.name = name;
            this.login = login;
            this.password = password;
        }
        public bool enter(string login, string password)
        {
            return true;
        }
    }
}
