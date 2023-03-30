using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilisationInterfaces
{
    public class Oiseau : IVolant
    {
        public int AltitudeMaximale{ get; set; }

        public Oiseau(int altitudeMaximal)
        {
            AltitudeMaximale = altitudeMaximal;
        }

        public void Voler()
        {
            Console.WriteLine("Oiseau vole à l'altitude " + AltitudeMaximale + " mètres");
        }
    }
}
