namespace Repository
{
    public class RepositoryFactory
    {
        public static IRepository GetRepository()
        {
            
            return new DataRepository();
        }
    }
}