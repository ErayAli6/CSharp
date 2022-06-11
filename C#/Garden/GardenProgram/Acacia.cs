using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenProgram
{
    public class Acacia : DecorationTree
    {
        public Acacia()
        {
            BeautyScore = 10;
            WaterRequired = 3;
        }
        public Acacia(double beauty , double water)
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
