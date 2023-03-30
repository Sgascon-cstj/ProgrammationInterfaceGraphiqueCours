using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructeurs
{
    class Secretaire : Employe
    {
        public bool FormationStenographie { get; set; }
        public Secretaire(bool fromSterno, int nbSemaine)
            :base(nbSemaine)
        {
            FormationStenographie = fromSterno;
        }
        public Secretaire(bool fromSterno): this(fromSterno,3)
        {
          
        }
        public Secretaire()
            :base(6)
        {

        }
    }
}