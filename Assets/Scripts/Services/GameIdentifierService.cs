namespace Services
{
    public class GameIdentifierService : IIdentifierService
    {
        private int currentId = 1;

        public int Next() => currentId++;
    }
}