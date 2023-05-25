namespace AnimalsProyect
{
    public class IdFood
    {
        private static int count = 0;
        public int Id { get; }

        public IdFood()
        {
            Id = ++count;
        }

        public int GetId()
        {
            return Id;
        }
    }
}