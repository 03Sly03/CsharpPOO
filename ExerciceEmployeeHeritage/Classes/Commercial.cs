using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceEmployeeHeritage.Classes
{
    internal class Commercial : Salarie
    {
        public double ChiffreDAffaire { get; set; }
        public double Commission { get; set; }

/*        public Commercial() : base() 
        {
            Salaire = (decimal)((double)16236 * (1 + 0.10));
        }*/

        public Commercial(string matricule, string nom, string service, string categorie, decimal salaire, double chiffreDAffaire, double commission) : base(matricule, nom, service, categorie, salaire)
        {
            ChiffreDAffaire = chiffreDAffaire;
            Commission = commission;
/*            Salaire = (decimal)((double)salaire * (1 + Commission / 100));
*/        }

        public override void AfficherSalaire()
        {
            base.AfficherSalaire();
        }
        public override string ToString()
        {
            return base.ToString() + $"Le salaire du commercial {Nom} est de {Salaire} Euros est la commission est de {Commission}";
        }
    }
}
