using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenProgram
{
    public class Carrote : EdiblePlant
    {
        public Carrote()
        {
            Energy = 10;
            WaterRequired = 1;
        }
        public Carrote(double energy,double water)
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
