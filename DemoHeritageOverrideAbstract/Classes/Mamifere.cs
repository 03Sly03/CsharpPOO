using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHeritageOverrideAbstract.Classes
{
    internal abstract class Mamifere : Animal
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

        public override void Respirer()
        {
            Console.WriteLine("Le mamifére respire !");
        }

        public override void SeDeplacer()
        {
            base.SeDeplacer();
            Console.WriteLine("Le mammifére se déplace !");
        }

        public virtual void Allaiter()
        {
            Console.WriteLine("Les mamifére allaite !");
        }
    }
}
