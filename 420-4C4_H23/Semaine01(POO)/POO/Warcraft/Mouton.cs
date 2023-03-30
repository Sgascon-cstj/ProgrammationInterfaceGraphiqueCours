using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft
{
    public class Mouton : Unite
    {
        public Mouton(){ pointsVie = 100; }

        public override void Parler()
        {
            Console.WriteLine("Le mouton bèle");
        }

        public override void Cliquer()
        {
            base.Cliquer();
            Exploser();
        }

        private void Exploser()
        {
            pointsVie = 0;
            Console.WriteLine("*** Booom ***");
        }
    }
}
