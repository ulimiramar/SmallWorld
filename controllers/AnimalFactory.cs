using System;
namespace AnimalsProyect
{
    static class AnimalFactory
    {
        public static void CreateAnimal(List<IAnimal> animalList)
        {
            Console.WriteLine("Enter animal age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter animal weight:");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter animal species:");
            string? species = Console.ReadLine();

            Console.WriteLine("Enter animal diet type (1. carnivore, 2. herbivore, or 3. omnivore):");
            int diet = Convert.ToInt32(Console.ReadLine());

            IDiet dietAnimalConversion;
            switch (diet)
            {
                case 1:
                    dietAnimalConversion = new CarnivoreDiet();
                    break;
                case 2:
                    dietAnimalConversion = new HerbivorousDiet();
                    break;
                case 3:
                    dietAnimalConversion = new OmnivorousDiet();
                    break;
                default:
                    Console.WriteLine("Invalid option. Defaulting to omnivorous.");
                    dietAnimalConversion = new OmnivorousDiet();
                    break;
            }

            Console.WriteLine("Enter animal habitat type (1. terrestrial, 2. aquatic, or 3. aeroterrestrial):");
            int habitat = Convert.ToInt32(Console.ReadLine());

            IAnimal newAnimal;
            switch (habitat)
            {
                case 1:
                    newAnimal = new TerrestrialAnimal(species, weight, age, dietAnimalConversion);
                    break;
                case 2:
                    newAnimal = new AquaticAnimal(species, weight, age, dietAnimalConversion);
                    break;
                case 3:
                    newAnimal = new AeroTerrestrialAnimal(species, weight, age, dietAnimalConversion);
                    break;
                default:
                    Console.WriteLine("Invalid option. Defaulting to terrestrial.");
                    newAnimal = new TerrestrialAnimal(species, weight, age, dietAnimalConversion);
                    break;
            }

            animalList.Add(newAnimal);
        }
    }
}