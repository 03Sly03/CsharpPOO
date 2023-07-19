using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHeritage.Classes
{
    internal class Mamifere : Animal
    {
        public string Genre { get; set; } 
        public Mamifere(string nom, bool estVivant, string genre) : base(nom, estVivant)
        {
            Genre = genre;
        }

        public Mamifere() : base("nom mam par défaut", true)
        {
            Genre = "Male";
        }

        public void Respirer() // C'est du masquage, c'est pas recommandé
        {
            Console.WriteLine("Le mamifére respire !");
        }
    }
}
