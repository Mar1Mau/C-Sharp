using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random((int)DateTime.Now.Ticks);

            List<Building> building = new List<Building>();

            int num_buildings = 5;

            for (int i = 0; i < num_buildings; i++)
            {
                bool has_elevator = false;

                if (r.Next(0, 100) > 50)
                {
                    has_elevator = true;

                } 

                int floors = r.Next(1, 10);

                building.Add(new Hotel(floors, has_elevator));

            }


            foreach (Building item in building)
            {
                Console.WriteLine(item.GetDetails() + "");
            }



            Console.ReadLine();

        }
    }
}
