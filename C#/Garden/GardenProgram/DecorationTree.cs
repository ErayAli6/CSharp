using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenProgram
{
    public abstract class DecorationTree :Tree, IBeauty
    {
        public double BeautyScore { get; set; }
    }
}
