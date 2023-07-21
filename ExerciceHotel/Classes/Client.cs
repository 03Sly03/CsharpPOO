using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel.Classes
{
    internal class Client
    {
        private int _identifier = 1001;
        private string _firstname = "John";
        private string _lastname = "Doe";
        private string _phoneNumber = "0606060606";

        public int Identifier { get => _identifier; set => _identifier = value; }
        public string Firstname { get => _firstname; set => _firstname = value; }
        public string Lastname { get => _lastname; set => _lastname = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }

        public override string ToString()
        {
            return $"Le client \"{Firstname} {Lastname}\", dont l'identifiant est {Identifier} a été ajouté";
        }
    }
}
