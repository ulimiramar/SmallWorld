using System;
using System.Collections.Generic;

namespace AnimalsProyect;

class Program
{
    static void Main(string[] args)
    {
        List<IAnimal> animalList = new List<IAnimal>();
        List<IFood> foodList = new List<IFood>();

        bool keepCreating = true;
        while (keepCreating)
        {
            Console.WriteLine("Enter 1 to create an animal or 2 to create a food (or any other key to exit):");
            string? userInput = Console.ReadLine();

            if (userInput == "1")
            {
                AnimalFactory.CreateAnimal(animalList);
            }
            else if (userInput == "2")
            {
                FoodFactory.CreateFood(foodList);
            }
            else
            {
                break;
            }

            Console.Write("Do you want to create another animal or food? (Y/N)");
            string? answer = Console.ReadLine();
            if (!string.IsNullOrEmpty(answer) && answer.ToLower() != "y")
            {
                keepCreating = false;
            }
        }

        Console.WriteLine("\nSummary of created animals:\n");
        foreach (var animal in animalList)
        {
            Console.WriteLine(animal.ToString());
        }

        Console.WriteLine("\nSummary of created foods:\n");
        foreach (var food in foodList)
        {
            Console.WriteLine(food.ToString());
        }

        bool keepFeeding = true;
        while (keepFeeding)
        {
            Console.WriteLine("Let's feed an animal:");

            Console.WriteLine("Enter animal id:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter food id:");
            int foodId = Convert.ToInt32(Console.ReadLine());

            IAnimal animal = animalList.Find(a => a.GetId() == id);
            IFood food = foodList.Find(f => f.GetId() == foodId);

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

            Console.Write("Do you want to feed another animal? (Y/N)");
            string? answer = Console.ReadLine();
            if (!string.IsNullOrEmpty(answer) && answer.ToLower() != "y")
            {
                keepFeeding = false;
            }
        }
    }
}
