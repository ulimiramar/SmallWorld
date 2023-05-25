namespace AnimalsProyect
{
    internal interface IAnimal
    {
        int GetId();
        string GetSpecie();
        double GetWeight();
        int GetAge();
        IDiet GetDiet();
        bool Move();
        bool Feed(IFood food);
        bool Sleep();
    }
}