using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenProgram
{
    public class Oak : DecorationTree
    {
        public Oak()
        {
            BeautyScore = 5;
            WaterRequired = 11;
        }
        public Oak(double beauty, double water)
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
