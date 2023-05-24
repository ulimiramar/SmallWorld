namespace AnimalsProyect
{
    internal class AcuaticAnimal : IAnimal, Ipositionable
    {
        private static int lastId = 0;
        private int id;
        private string Specie { get; set; }
        private double Weight { get; set; }
        private int Age { get; set; }
        private IDiet Diet { get; set; }
        private int PosX { get; set; }
        private int PosY { get; set; }

        public AcuaticAnimal(string specie, double weight, int age, IDiet diet)
        {
            this.id = ++lastId;
            Specie = specie;
            Weight = weight;
            Age = age;
            Diet = diet;
        }

        public int GetId(){
            return id;
        }
        public string GetSpecie()
        {
            return Specie;
        }
        public double GetWeight()
        {
            return Weight;
        }
        public int GetAge()
        {
            return Age;
        }
        public IDiet GetDiet()
        {
            return Diet;
        }
        public int GetPosX()
        {
            return PosX;
        }
        public int GetPosY()
        {
            return PosY;
        }
        public bool Feed(IFood food)
        {
            return Diet.CanEat(food);
        }
        public bool Move()
        {
            throw new NotImplementedException();
        }

        public bool Sleep()
        {
            throw new NotImplementedException();
        }
    }
}