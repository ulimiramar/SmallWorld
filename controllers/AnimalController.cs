using System;
namespace AnimalsProyect
{
    static class AnimalController
    {

        public static void CreateAnimal(List<IAnimal> animalList, int age, double weight, string species, int diet, int habitat)
        {
            Dictionary<int, IDiet> dietMappings = new Dictionary<int, IDiet>
            {
                { 1, new CarnivoreDiet() },
                { 2, new HerbivorousDiet() },
                { 3, new OmnivorousDiet() }
            };

            Dictionary<int, Func<string, double, int, IDiet, IAnimal>> animalMappings = new Dictionary<int, Func<string, double, int, IDiet, IAnimal>>
            {
                { 1, (s, w, a, d) => new TerrestrialAnimal(s, w, a, d) },
                { 2, (s, w, a, d) => new AquaticAnimal(s, w, a, d) },
                { 3, (s, w, a, d) => new AeroTerrestrialAnimal(s, w, a, d) }
            };

            IDiet selectedDiet = dietMappings.GetValueOrDefault(diet, new OmnivorousDiet());
            IAnimal newAnimal = animalMappings.GetValueOrDefault(habitat, (s, w, a, d) => new TerrestrialAnimal(s, w, a, d))(species, weight, age, selectedDiet);

            animalList.Add(newAnimal);
        }
    }
}