using DemoInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface.Classes
{
    internal class Pigeon : Oiseau, IPeutVoler
    {
        public void Decoller()
        {
            Console.WriteLine("\"ouou le pigeon s'envole\"");
        }
        public void Atterir()
        {
            Console.WriteLine("\"ouou le pigeon attéri\"");
        }
    }
}
