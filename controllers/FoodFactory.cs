using System;
namespace AnimalsProyect
{
    static class FoodFactory
    {
        public static void CreateFood(List<IFood> foodList)
        {
            Console.WriteLine("Enter food name:");
            string? name = Console.ReadLine();

            Console.WriteLine("Enter food calories:");
            int calories = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter food diet type (1. vegetable or 2. animal):");
            int dietType = Convert.ToInt32(Console.ReadLine());

            IFood newFood;
            switch (dietType)
            {
                case 1:
                    newFood = new VegetableFood(calories, name);
                    break;
                case 2:
                    newFood = new AnimalFood(calories, name);
                    break;
                default:
                    Console.WriteLine("Invalid option. Defaulting to animal.");
                    newFood = new AnimalFood(calories, name);
                    break;
            }

            foodList.Add(newFood);
        }
    }

}