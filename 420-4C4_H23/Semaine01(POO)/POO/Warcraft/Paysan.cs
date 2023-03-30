using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft
{
    public class Paysan : Horde
    {
        public Paysan()
        {
            pointsVie = 220;
        }
        public override void Parler()
        {
            Console.WriteLine("Paysan parle");
        }
    }
}
