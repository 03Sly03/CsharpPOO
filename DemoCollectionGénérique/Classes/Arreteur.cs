using DemoCollectionGenerique.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCollectionGenerique.Classes
{
    internal class Arreteur
    {
        public void ArreteCetteChose<T>(T choseAArreter) where T : IDemarable
        {
            choseAArreter.Arreter();
        }
    }
}
