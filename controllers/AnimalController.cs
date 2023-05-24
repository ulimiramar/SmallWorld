namespace AnimalsProyect
{
    internal class AnimalController : IController
    {
        private readonly static IController AnimalsController = new AnimalController();        
        private readonly List<IAnimal> Animals = new();

        private AnimalController() { }
        public void AddAnimal(IAnimal animal)
        {
            Animals.Add(animal);
        }
        public static IController GetController()
        {
            return AnimalsController;
        }
        public List<IAnimal> getAnimals()
        {
            return Animals;
        }
        public void RemoveAllAnimals()
        {
            Animals.Clear();
        }
        public void RemoveAnimal(IAnimal animal)
        {
            Animals.Remove(animal);
        }
    }
}
