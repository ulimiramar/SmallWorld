namespace AnimalsProyect
{
    internal class AcuaticAnimal : IAnimal, Ipositionable
    {
        private IdAnimal Id;
        private string Specie { get; set; }
        private double Weight { get; set; }
        private int Age { get; set; }
        private IDiet Diet { get; set; }
        private int PosX { get; set; }
        private int PosY { get; set; }
        private int energy;
        private int maxEnergy;

        public AcuaticAnimal(string specie, double weight, int age, IDiet diet)
        {
            this.Id = new IdAnimal();
            Specie = specie;
            Weight = weight;
            Age = age;
            Diet = diet;
            this.energy = 100;
            this.maxEnergy = 100;
        }

        public int GetId()
        {
            return Id.GetId();
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
            if (Diet.CanEat(food))
            {
                energy += food.GetCalories();
                energyCheck();
                return true;
            }
            else { return false; }
        }
        public bool Move()
        {
            throw new NotImplementedException();
        }

        public bool Sleep()
        {
            throw new NotImplementedException();
        }

        public int getEnergy()
        {
            return energy;
        }

        public void energyCheck()
        {
            if (energy > maxEnergy)
            {
                energy = maxEnergy;
            }
        }

        public override string ToString()
        {
            return $"ID: {GetId()}, Species: {Specie}, Age: {Age}, Weight: {Weight}, Diet: {Diet}, Energy: {energy}";
        }
    }
}