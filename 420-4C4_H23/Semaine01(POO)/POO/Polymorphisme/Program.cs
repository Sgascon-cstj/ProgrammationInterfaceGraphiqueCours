using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2,4);
            p1.Afficher();
            Point p2 = new Point(1,2);
            p2.Afficher();

            Point p3 = new Point();
            p3 = p1 + p2;

            Console.WriteLine("\nAprès l'Addition de l'opérateur +");
            p3.Afficher();

            Console.ReadKey();
        }
    }
}
