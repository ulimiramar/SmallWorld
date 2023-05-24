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
        public string ToString()
        {
            return $"ID: {id}, Name: {name} Species: {species}, Age: {age}, Weight: {weight}, Diet: {dietType}, Energy: {energy}";
        }
    }
}