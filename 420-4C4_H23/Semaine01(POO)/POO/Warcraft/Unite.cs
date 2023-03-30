using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft
{
    public abstract class Unite
    {
        protected int pointsVie;
        public Unite()
        {

        }
        //Méthode virtual Cliquer
        public virtual void Cliquer()
        {
            Parler();
        }
        //Prototype de la méthode abstraite Parler
        public abstract void Parler();
    }
}
