using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructeurs
{
    public class Employe
    {
        public int SemaineDeVacances { get; set; }
        //public Employe()
        //{

        //}
        public Employe(int nbSemaines)
        {
            SemaineDeVacances= nbSemaines;
        }

    }
}
