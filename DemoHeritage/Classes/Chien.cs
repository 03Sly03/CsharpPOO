using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHeritage.Classes
{
    internal class Chien : Mamifere
    {
        public string Race { get; set; }

        public Chien(string nom, bool estVivant, string genre, string race) : base(nom, estVivant, genre)
        {
            Race = race;
        }

        public void Crier() // C'est du masquage, c'est pas recommandé
        {
            Console.WriteLine("Le Chien aboie !");
        }
    }
}
