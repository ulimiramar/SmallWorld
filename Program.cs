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
                Console.WriteLine("Enter animal age:");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter animal weight:");
                double weight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter animal species:");
                string? species = Console.ReadLine();

                Console.WriteLine("Enter animal diet type (1. carnivore, 2. herbivore, or 3. omnivore):");
                int diet = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter animal habitat type (1. terrestrial, 2. aquatic, or 3. aeroterrestrial):");
                int habitat = Convert.ToInt32(Console.ReadLine());

                AnimalController.CreateAnimal(animalList, age, weight, species, diet, habitat);
            }
            else if (userInput == "2")
            {
                Console.WriteLine("Enter food name:");
                string? name = Console.ReadLine();

                Console.WriteLine("Enter food calories:");
                int calories = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter food diet type (1. vegetable or 2. animal):");
                int dietType = Convert.ToInt32(Console.ReadLine());

                FoodController.CreateFood(foodList,name,calories,dietType);
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
