using DemoCollectionGenerique.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCollectionGenerique.Classes
{
    internal class Demarreur<TypeDemarable> where TypeDemarable : IDemarable
    {
        public void DemareCetteChose(TypeDemarable choseADemarrer)
        {
            choseADemarrer.Demarrer();
        }
    }
}
