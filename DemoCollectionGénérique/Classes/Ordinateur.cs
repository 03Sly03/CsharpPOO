using DemoCollectionGenerique.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCollectionGenerique.Classes
{
    internal class Ordinateur : IDemarable
    {
        public void Arreter()
        {
            Console.WriteLine("L'ordinateur s'éteint");
        }

        public void Demarrer()
        {
            Console.WriteLine("L'ordinateur s'allume");
        }
    }
}
