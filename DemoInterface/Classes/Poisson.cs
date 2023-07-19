using DemoInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface.Classes
{
    internal abstract class Poisson : Animal, IPeutNager // ici tous les poissons vont être capable de nager.
    {
        public void Nager()
        {
            Console.WriteLine($"Le {this.GetType().Name} nage"); // On récupére ici le nom de la classe de l'animal qui sait nager.
        }
    }
}
