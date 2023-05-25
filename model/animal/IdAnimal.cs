namespace AnimalsProyect
{
    public class IdAnimal
    {
        private static int count = 0;
        public int Id { get; }

        public IdAnimal()
        {
            Id = ++count;
        }

        public int GetId()
        {
            return Id;
        }
    }
}