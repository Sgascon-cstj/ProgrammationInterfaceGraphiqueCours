using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructeurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Secretaire secretaire1 = new Secretaire(true, 4);
            int nbSemVac = secretaire1.SemaineDeVacances;
            Console.WriteLine("Secrétaire 1: \nLe nombre de semaine de vacance est: " + nbSemVac);

            Secretaire secretaire2 = new Secretaire(false);
            nbSemVac = secretaire2.SemaineDeVacances;
            Console.WriteLine("Secrétaire 2: \nLe nombre de semaine de vacance est: " + nbSemVac);

            Secretaire secretaire3 = new Secretaire();
            nbSemVac = secretaire3.SemaineDeVacances;
            Console.WriteLine("Secrétaire 3: \nLe nombre de semaine de vacance est: " + nbSemVac);

            Console.ReadKey();
        }
    }
}
