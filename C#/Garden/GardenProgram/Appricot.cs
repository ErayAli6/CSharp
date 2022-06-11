using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenProgram
{
    public class Appricot : FruitTree
    {
        public Appricot()
        {
            Energy = 7;
            WaterRequired = 7;
        }
        public Appricot(double energy, double water)
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
