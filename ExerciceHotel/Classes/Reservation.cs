using ExerciceHotel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel.Classes
{
    internal class Reservation
    {
        private int _identifier;
        private Status _status;
        private List<Bedroom> _bedRooms = new List<Bedroom>();
        private Client _client;

        public int Identifier { get => _identifier; set => _identifier = value; }
        internal Status Status { get => _status; set => _status = value; }
        internal List<Bedroom> BedRooms { get => _bedRooms; set => _bedRooms = value; }
        internal Client Client { get => _client; set => _client = value; }
    }
}
