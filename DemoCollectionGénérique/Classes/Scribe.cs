using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCollectionGenerique.Classes
{
    internal class Scribe
    {
        public static void EcritPulsieursFois<T1>(T1 choseAEcrire, int nombreDeFois)
        {
            for (int i = 0; i < nombreDeFois; i++)
            {
                Console.WriteLine(choseAEcrire.ToString());
            }
        }
    }
}
