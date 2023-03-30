using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft
{
    public class Peon : Horde
    {

        public Peon()
        {
            pointsVie = 250;
        }
        //Surcharge (override) de la méthode abstraite Parler. Obligatoire dans une classe non abstraite qui hérite de la classe unité.
        public override void Parler()
        {
            Console.WriteLine("Le péon parle");
        }
    }
}
