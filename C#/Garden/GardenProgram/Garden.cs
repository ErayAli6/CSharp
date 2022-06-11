using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenProgram
{
    public class Garden
    {
        List<IGardenItem> gardens = new List<IGardenItem>();
        public void AddGarden(IGardenItem item)
        {
            gardens.Add(item);
        }
        public void RemoveGarden(IGardenItem item)
        {
            gardens.Remove(item);
        }

        public List<IFood> Foods
        {
            get
            {
                return GetAllFoods();
            }
        }

        public List<IBeauty> Beauties
        {
            get
            {
                return GetAllBeauties();
            }
        }

        public List<IFood> GetAllFoods()
        {
            List<IFood> food = new List<IFood>();
            foreach (var item in gardens)
            {
                if (item is IFood)
                {
                    food.Add((IFood)item);
                }
            }
            return food;
        }

        public List<IBeauty> GetAllBeauties()
        {
            List<IBeauty> beauty = new List<IBeauty>();
            foreach (var item in gardens)
            {
                if (item is IBeauty)
                {
                    beauty.Add((IBeauty)item);
                }
            }
            return beauty;
        }
        public double CalculateBeautyScores()
        {
            var beauty = this.GetAllBeauties();
            double score = 0;
            foreach (var item in beauty)
            {
                score += item.BeautyScore;
            }
            return score;
        }

        public double CalculateWaterRequired()
        {
            double score = 0;
            foreach (var item in gardens)
            {
                score += item.WaterRequired;
            }
            return score;
        }

        public double CalculateEnergy()
        {
            var food = this.GetAllFoods();
            double score = 0;
            foreach (var item in food)
            {
                score += item.Energy;
            }
            return score;
        }

    }
}
