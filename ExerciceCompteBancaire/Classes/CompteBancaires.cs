using ExerciceCompteBancaire.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceCompteBancaire.Classes
{
    internal abstract class CompteBancaires
    {

        private decimal _solde;
        private string _client;
        private List<DepotRetrait> _operations;

        public decimal Solde { get => _solde; set => _solde = value; }
        public string Client { get => _client; set => _client = value; }
        internal List<DepotRetrait> Operations { get => _operations; set => _operations = value; }
    }
}
