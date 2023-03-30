using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilisationInterfaces
{
    public interface IRoulant
    {
        int NombreRoues { get; set; }

        void Rouler();

    }
}
