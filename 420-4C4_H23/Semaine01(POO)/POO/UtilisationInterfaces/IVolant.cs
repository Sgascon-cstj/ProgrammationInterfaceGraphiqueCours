using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilisationInterfaces
{
    public interface IVolant
    {
        int AltitudeMaximale { get; set; }

        void Voler();
    }
}
