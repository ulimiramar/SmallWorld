namespace AnimalsProyect
{
    internal class VegetableFood : IFood
    {
        private IdFood Id;
        private int Calories;
        private string Name;

        public VegetableFood(int calories, string name)
        {
            this.Id = new IdFood();
            Calories = calories;
            Name = name;
        }
        public int GetId()
        {
            return Id.GetId();
        }

        public int GetCalories()
        {
            return Calories;
        }

        public string GetName()
        {
            return Name;
        }
        public override string ToString()
        {
            return $"ID:{GetId()}, Calories:{Calories}, Name:{Name}";
        }
    }
}