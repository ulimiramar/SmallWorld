namespace AnimalsProyect
{
    internal class CarnivoreDiet : IDiet
    {
        public bool CanEat(IFood food)
        {
            return food is AnimalFood;
        }

        public override string ToString()
        {
            return "Carnívoro";
        }
    }
}