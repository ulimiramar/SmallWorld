using System;
namespace AnimalsProyect
{
    static class FoodController
    {
        public static void CreateFood(List<IFood> foodList, string name, int calories, int dietType)
        {
            Dictionary<int, Func<int, string, IFood>> foodMappings = new Dictionary<int, Func<int, string, IFood>>
            {
                { 1, (c, n) => new VegetableFood(c, n) },
                { 2, (c, n) => new AnimalFood(c, n) }
            };

            IFood newFood = foodMappings.GetValueOrDefault(dietType, (c, n) => throw new InvalidOperationException("Invalid diet type"))(calories, name);

            foodList.Add(newFood);


            // esto es lo que hacía antes y lo que reemplacé por el diccionario
            // IFood newFood;
            // switch (dietType)
            // {
            //     case 1:
            //         newFood = new VegetableFood(calories, name);
            //         break;
            //     case 2:
            //         newFood = new AnimalFood(calories, name);
            //         break;
            //     default:
            //         Console.WriteLine("Invalid option. Defaulting to animal.");
            //         newFood = new AnimalFood(calories, name);
            //         break;
            // }

            // foodList.Add(newFood);
        }
    }

}