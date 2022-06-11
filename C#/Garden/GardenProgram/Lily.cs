using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenProgram
{
    public class Lily : Flowers
    {
        public Lily()
        {
            BeautyScore = 7;
            WaterRequired = 2;
        }
        public Lily(double beauty,double water)
        {
            if (beauty >= 0 && water >= 0)
            {
                BeautyScore = beauty;
                WaterRequired = water;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
