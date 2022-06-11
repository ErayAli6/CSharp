using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenProgram
{
    public class Peach : FruitTree
    {
        public Peach()
        {
            Energy = 5;
            WaterRequired = 5;
        }
        public Peach(double energy,double water)
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
