using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenProgram
{
    public class Rose : Flowers
    {
        public Rose()
        {
            BeautyScore = 15;
            WaterRequired = 5;
        }
        public Rose(double beauty,double water)
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
