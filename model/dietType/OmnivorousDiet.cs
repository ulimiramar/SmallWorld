namespace AnimalsProyect
{
    internal class OmnivorousDiet : IDiet
    {
        public bool CanEat(IFood food)
        {
            return food is VegetableFood || food is AnimalFood;
        }
        public override string ToString()
        {
            return "Omnívoro";
        }
    }
}