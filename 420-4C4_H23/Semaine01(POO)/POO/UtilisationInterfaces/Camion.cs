using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilisationInterfaces
{
    public class Camion : IRoulant
    {
        public int NombreRoues { get; set; }
        public Camion(int nombreroues) 
        {
            NombreRoues = nombreroues;            
        }
        public void Rouler()
        {
            Console.WriteLine("Le camion roule avec ses " + NombreRoues + " roues");
        }
    }
}
