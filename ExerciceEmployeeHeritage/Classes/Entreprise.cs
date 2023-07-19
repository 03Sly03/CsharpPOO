using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceEmployeeHeritage.Classes
{
    internal class Entreprise
    {
        private List<Salarie> _salarieList = new List<Salarie>();
        private List<Commercial> _commercialList = new List<Commercial>();

        public int Taille { get; set; }

        public Entreprise(int taille = 20) { Taille = taille; }

        public void AjouterSalarie(Salarie salarie)
        {
            _salarieList.Add(salarie);
        }
        public void AjouterSalarie(Commercial commercial)
        {
            _commercialList.Add(commercial);
        }

        public string Find(string nameToFind)
        {
            string nameToFindToLower = nameToFind.Trim().ToLower();
            foreach (var salarie in _salarieList)
            {
                string salarieToLower = salarie.Nom.Trim().ToLower();
                if (nameToFindToLower == salarieToLower || salarieToLower.Contains(nameToFindToLower))
                    return $"------------------------\nLe salaire fixe de {salarie.Nom} est de {salarie.Salaire} euros\n------------------------\n";
            }
            foreach (var commercial in _commercialList)
            {
                string commercialToLower = commercial.Nom.Trim().ToLower();
                if (nameToFindToLower == commercialToLower || commercialToLower.Contains(nameToFindToLower))
                    return $"------------------------\nJe suis un commerciale\nLe salaire fixe de {commercial.Nom} est de {commercial.Salaire} euros\nLe salaire avec commission de {commercial.Nom} est de {(decimal)((double)commercial.Salaire * (1 + commercial.Commission / 100))} euros\n------------------------\n";
            }
            return "L'employé n'existe pas";
        }

        public override string ToString()
        {
            string infos = "";
            foreach (var salarie in _salarieList)
            {
                infos += $"Le salaire fixe de {salarie.Nom} est de {salarie.Salaire} euros\n------------------------\n";
            }
            foreach (var commercial in _commercialList)
            {
                infos += $"Je suis un commerciale\nLe salaire fixe de {commercial.Nom} est de {commercial.Salaire} euros\nLe salaire avec commission de {commercial.Nom} est de {(decimal)((double)commercial.Salaire * (1 + commercial.Commission/100))} euros\n------------------------\n";
            }
            return "------------------------\n" + infos;
        }
    }

}
