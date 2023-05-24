namespace AnimalsProyect
{
    internal class AnimalFood : IFood
    {
        private static int lastId = 0;
        private int id;
        private int Calories;
        private string Name;

        public AnimalFood(int calories, string name)
        {
            this.id = ++lastId;
            Calories = calories;
            Name = name;
        }
        public int GetId(){
            return id;
        }
        public int GetCalories()
        {
            return Calories;
        }
        public string GetName()
        {
            return Name;
        }
    }
}