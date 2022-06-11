using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garden garden = new Garden();
            string input;
            string[] input2;
            string type;
            int count;
            Console.WriteLine("Въведете име на растението и брой. За край въведете \"end\"");
            do
            {
                input = Console.ReadLine().ToLower();
                if (input == "end") 
                {
                    break;
                }
                //input го разделяма от интервала. Първия го записваме в type,а втория го парсваме в int и го записваме в count
                input2 = input.Split(' ');
                type = input2[0];
                count = Int32.Parse(input2[1]);

                //Въртим count на брой пъти,за да създадем толкова обекти колкото ни е необходимо
                for (int i = 0; i < count; i++)
                {
                    switch (type)
                    {
                        case "peach":
                            garden.AddGarden(new Peach());
                            break;
                        case "appricot":
                            garden.AddGarden(new Appricot());
                            break;
                        case "acacia":
                            garden.AddGarden(new Acacia());
                            break;
                        case "oak":
                            garden.AddGarden(new Oak());
                            break;
                        case "lily":
                            garden.AddGarden(new Lily());
                            break;
                        case "rose":
                            garden.AddGarden(new Rose());
                            break;
                        case "carrote":
                            garden.AddGarden(new Carrote());
                            break;
                        case "strawberry":
                            garden.AddGarden(new Strawberry());
                            break;
                    }
                }
            } while (type != "end");
            Console.WriteLine();
            Console.WriteLine("BeautyScore: " + garden.CalculateBeautyScores());
            Console.WriteLine("WaterRequired: " + garden.CalculateWaterRequired());
            Console.WriteLine("Energy: " + garden.CalculateEnergy());
        }
    }
}
