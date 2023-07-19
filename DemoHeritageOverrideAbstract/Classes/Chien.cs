using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHeritageOverrideAbstract.Classes
{
    internal sealed class Chien : Mamifere
    {
        public string Race { get; set; }

        public Chien(string nom, bool estVivant, string genre, string race) : base(nom, estVivant, genre)
        {
            Race = race;
        }

        public override void Crier()
        {
            Console.WriteLine("Le Chien aboie !");
        }

        public override void SeDeplacer()
        {
            Console.WriteLine("Le chat se déplace à 4 pattes");
        }

        public new void Allaiter()
        {
            Console.WriteLine("Le chien allaite ses petits");
        }
    }
}
