using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilisationInterfaces
{
    public class Avion : IVolant, IRoulant
    {
        public int AltitudeMaximale { get; set; }
        public int NombreRoues { get; set; }

        public Avion(int altitudeMaximale, int nombreRoues)
        {
            AltitudeMaximale = altitudeMaximale;
            NombreRoues = nombreRoues;
        }
        public void Voler()
        {
            Console.WriteLine("L'avion vole à " + AltitudeMaximale + "mètre");
        }
        public void Rouler()
        {
            Console.WriteLine("l'avion roule avec " + NombreRoues);
        }

    }
}
