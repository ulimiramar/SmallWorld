namespace AnimalsProyect
{
    internal class HerbivorousDiet : IDiet
    {
        public bool CanEat(IFood food)
        {
            return food is VegetableFood;
        }
        public override string ToString()
        {
            return "Hervívoro";
        }
    }
}