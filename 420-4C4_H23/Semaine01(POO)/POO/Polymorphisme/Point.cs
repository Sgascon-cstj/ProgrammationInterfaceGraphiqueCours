using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisme
{
    class Point
    {
        private int x = 0;
        private int y = 0;

        public Point()
        {

        }
        public Point(int i, int j )
        {
            x = i;
            y = j;
        }
        public void Afficher()
        {
            Console.WriteLine(x + " " + y);
        }
        //Surcharge de l'opérateur + pour pouvoir additioner les coordoné de deux points.
        public static Point operator +(Point a, Point b) 
        {
            Point point = new Point();

            point.x = a.x + b.x;
            point.y = a.y + b.y;
            return point;
        }
    }
}
