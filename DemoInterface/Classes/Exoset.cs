using DemoInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface.Classes
{
    internal class Exoset : Poisson, IPeutVoler
    {
        public void Decoller()
        {
            Console.WriteLine("L'exoset sort de l'eau et s'envole !");
        }
        public void Atterir()
        {
            Console.WriteLine("L'exoset plonge dans l'eau !");
            Nager();
        }
    }
}
