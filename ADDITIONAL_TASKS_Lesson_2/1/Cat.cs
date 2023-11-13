using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1
{
    public class Cat
    {
        public int FullnessLevel = 50; 
        public enum Food {Fish,Mouse,Chicken,Milk }
        public void EatSomething(Food food)
        {
            switch (food)
            {
                case Food.Milk:
                    FullnessLevel += 5;
                    break;
                case Food.Fish:
                    FullnessLevel += 15;
                    break;
                case Food.Mouse:
                    FullnessLevel += 10;
                    break;
                case Food.Chicken:
                    FullnessLevel += 20;
                    break;
                default:
                    Console.WriteLine("Unknown food type.");
                    break;
            }
            Console.WriteLine($"Ate {food}. New fullness level: {FullnessLevel}");
        }
    }
    }
