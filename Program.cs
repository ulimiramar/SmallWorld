using System;
using System.Collections.Generic;

namespace AnimalsProyect;
class Program
{
    static void Main(string[] args)
    {
        // TerrestrialAnimal animal = new TerrestrialAnimal("Lobo", 150, 10, new CarnivoreDiet());
        // if (animal.Feed(new VegetableFood(50, "Tomate")))
        // {
        //     Console.WriteLine("Rico");
        // }
        // else
        // {
        //     Console.WriteLine("no como eso");
        // }


        List<IAnimal> animalList = new List<IAnimal>();
        List<IFood> foodList = new List<IFood>();
        IDiet dietAnimalConversion = new OmnivorousDiet();

        bool keepCreating = true;
        while (keepCreating)
        {
            Console.WriteLine("Enter 1 to create an animal or 2 to create a food (or any other key to exit):");
            string? userInput = Console.ReadLine();

            if (userInput == "1")
            {
                // Console.WriteLine("Enter animal name:");
                // string? name = Console.ReadLine();

                Console.WriteLine("Enter animal age:");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter animal weight:");
                double weight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter animal species:");
                string? species = Console.ReadLine();

                Console.WriteLine("Enter animal diet type (1. carnivore, 2. herbivore, or 3. omnivore):");
                int diet = Convert.ToInt32(Console.ReadLine());
                switch (diet)
                {

                    case 1:
                        dietAnimalConversion = new CarnivoreDiet();
                        break;
                    case 2:
                        dietAnimalConversion = new HervivorousDiet();
                        break;
                    case 3:
                        dietAnimalConversion = new OmnivorousDiet();
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Se utilizará por defecto omnivoro.");
                        break;
                }

                Console.WriteLine("Enter animal habitat type (1. terrestrial, 2. aquatic, or 3. aeroterrestrial):");
                int habitat = Convert.ToInt32(Console.ReadLine());
                switch (habitat)
                {

                    case 1:
                         animalList.Add(new TerrestrialAnimal(species, weight, age, dietAnimalConversion));
                        break;
                    case 2:
                        animalList.Add(new AcuaticAnimal(species, weight, age, dietAnimalConversion));
                        break;
                    case 3:
                        animalList.Add(new AeroTerrestrialAnimal(species, weight, age, dietAnimalConversion));
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Se utilizará por defefcto terrestrial.");
                        animalList.Add(new TerrestrialAnimal(species, weight, age, dietAnimalConversion));
                        break;
                }

            }
            else if (userInput == "2")
            {
                Console.WriteLine("Enter food name:");
                string? name = Console.ReadLine();

                Console.WriteLine("Enter food calories:");
                int calories = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter food diet type (1. vegetable or 2. animal):");
                int dietType = Convert.ToInt32(Console.ReadLine());

                switch (dietType)
                {

                    case 1:
                        foodList.Add(new VegetableFood(calories, name));
                        break;
                    case 2:
                        foodList.Add(new AnimalFood(calories, name));
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Se utilizará por defecto animal.");
                        foodList.Add(new AnimalFood(calories, name));
                        break;
                }
            }
            else
            {
                break;
            }

            Console.Write("¿Quieres crear otro animal o comida? (S/N)");
            string? answer = Console.ReadLine();
            if (answer.ToLower() != "s")
            {
                keepCreating = false;
            }
        }


        Console.WriteLine("\nResumen de las animales creados:\n");
        foreach (var a in animalList)
        {
            Console.WriteLine(a.ToString());
        }

        Console.WriteLine("\nResumen de alimentos creados:\n");
        foreach (var f in foodList)
        {
            Console.WriteLine(f.ToString());
        }


        bool keepFeeding = true;
        while (keepFeeding)
        {
        Console.WriteLine("Vamos a alimentar al animal:");

        Console.WriteLine("Enter animal id:");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter food id:");
        int foodId = Convert.ToInt32(Console.ReadLine());

        IAnimal a = animalList.Find(a => a.GetId() == id);
        IFood f = foodList.Find(f => f.GetId() == foodId);

        if (a == null)
        {
            Console.WriteLine("Animal not found.");
        }
        else if (f == null)
        {
            Console.WriteLine("Food not found.");
        }
        else if (!a.GetDiet().CanEat(f))
        {
            Console.WriteLine("Animal cannot eat this type of food.");
        }
        else
        {
            a.Feed(f);
            Console.WriteLine("Animal has been feed.");
        }

        Console.Write("¿Quieres alimentar otro animal? (S/N)");
            string? answer = Console.ReadLine();
            if (answer.ToLower() != "s")
            {
                keepFeeding = false;
            }
        }

    }
}
