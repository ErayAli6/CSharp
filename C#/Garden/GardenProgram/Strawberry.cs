using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenProgram
{
    public class Strawberry : EdiblePlant
    {
        public Strawberry()
        {
            Energy = 12;
            WaterRequired = 3;
        }
        public Strawberry(double energy,double water)
        {
            if (energy >= 0 && water >= 0)
            {
                Energy = energy;
                WaterRequired = water;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
