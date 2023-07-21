using ExerciceHotel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel.Classes
{
    internal class Bedroom
    {
        private int _number;
        private Status _status;
        private int _nbBed;
        private double _price;

        public int Number { get => _number; set => _number = value; }
        public int NbBed { get => _nbBed; set => _nbBed = value; }
        public double Price { get => _price; set => _price = value; }
        internal Status Status { get => _status; set => _status = value; }
    }
}
