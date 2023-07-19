using DemoInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface.Classes
{
    internal class Baleine : Mamifere, IPeutNager
    {
        public void Nager() 
        {
            Console.WriteLine("La baleine nage");
        }
    }
}
