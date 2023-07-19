using DemoInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface.Classes
{
    internal class ChauveSouris : Mamifere, IPeutVoler
    {
        public void Decoller()
        {
            Console.WriteLine("\"flapflap la chauve-souris s'envole\"");
        }
        public void Atterir()
        {
            Console.WriteLine("\"flapflap la chauve-souris attéri\"");
        }
    }
}
