using System;
namespace AnimalsProyect
{
    static class FeedAnimalController
    {
        public static void FeedAnimal(List<IAnimal> animalList, List<IFood> foodList, int AnimalId, int FoodId){
            
            IAnimal animal = animalList.Find(a => a.GetId() == AnimalId);
            IFood food = foodList.Find(f => f.GetId() == FoodId);

            if (animal == null)
            {
                Console.WriteLine("Animal not found.");
            }
            else if (food == null)
            {
                Console.WriteLine("Food not found.");
            }
            else if (!animal.GetDiet().CanEat(food))
            {
                Console.WriteLine("Animal cannot eat this type of food.");
            }
            else
            {
                animal.Feed(food);
                Console.WriteLine("Animal has been fed.");
            }
        }
    }
}