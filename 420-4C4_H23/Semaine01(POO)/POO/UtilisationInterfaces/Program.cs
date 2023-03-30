using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilisationInterfaces
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Oiseau cigogne = new Oiseau(4000);
            Camion mack = new Camion(10);
            Avion boeing = new Avion(12000,10);

            cigogne.Voler();
            mack.Rouler();
            Console.WriteLine("----------");
            boeing.Rouler();
            boeing.Voler();

            Console.ReadKey();
        }
    }
}
