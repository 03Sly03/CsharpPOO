using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel.Classes
{
    internal class Hotel
    {
        private string _name = "Excelsior";
        private List<Client> _clients = new List<Client>();
        private List<Bedroom> _bedrooms = new List<Bedroom>();
        private List<Reservation> _reservations = new List<Reservation>();

        public string Name { get => _name; set => _name = value; }
        internal List<Client> Clients { get => _clients; set => _clients = value; }
        internal List<Bedroom> Bedrooms { get => _bedrooms; set => _bedrooms = value; }
        internal List<Reservation> Reservations { get => _reservations; set => _reservations = value; }

        public void AddClient(Client client)
        {

        }
    }

}
