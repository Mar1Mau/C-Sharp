using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    abstract class Building
    {
        public int NumOfFloors { get; set; }
        public bool IsElevator { get; set; }

         public Building(int numOfFloors, bool isElevator)
        {
            NumOfFloors = numOfFloors;
            IsElevator = isElevator;
        }

        public virtual string GetDetails()
        {
            string elevator = "abc";

            if(IsElevator == true)
            {
                elevator = "elevator";
            }
            else
            {
                elevator = "no elevator";
            }

            string str = $"Number of the floors: {NumOfFloors} with {elevator}.";

            return str; 

        }
    }

    
}
