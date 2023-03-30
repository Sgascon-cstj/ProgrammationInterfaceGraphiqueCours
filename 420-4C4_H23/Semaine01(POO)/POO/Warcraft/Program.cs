using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Peon Thrall = new Peon();
            Paysan Wryn = new Paysan();
            Mouton Pouf= new Mouton();

            List<Unite> ListUnites = new List<Unite>();
            ListUnites.Add(Thrall);
            ListUnites.Add(Wryn);
            ListUnites.Add(Pouf);

            Console.WriteLine("On clique sur nos personnages... ");
            Console.WriteLine();

            foreach (Unite u in ListUnites)
            {
                u.Cliquer();
            }

            Console.ReadKey();
        }
    }
}
