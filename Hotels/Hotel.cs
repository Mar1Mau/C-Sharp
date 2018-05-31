using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Hotel : Building
    {
        static Random rnd = new Random((int)DateTime.Now.Ticks);

        public int Rooms { get; set; }
        public int ReservedRooms { get; set; }
        public Country Country { get; set; }
        public List< Service > Services { get; set; }

        public override string GetDetails()
        {

            string sre = String.Join(",", Services.ToArray());

            string str = $"\nThis hotel located in {Country.ToString()}. With services: {sre} Number of the rooms: {Rooms}. Reserved rooms: {ReservedRooms}";
            return base.GetDetails() + str;

        }

        public Hotel(int numOfFloors, bool isElevator) : base(numOfFloors, isElevator)
        {
       
            Rooms = rnd.Next(100, 1000);
            ReservedRooms = rnd.Next(2, 100);
            Country = (Country)rnd.Next(8);

            Services = new List<Service>();

            for (int i = 0; i < 3; i++)
            {
                Service temp = ((Service)rnd.Next(Enum.GetValues(typeof(Service)).Length));
                Services.Add(temp);
            }

        }



    }
}
