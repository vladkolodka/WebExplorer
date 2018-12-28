namespace WebExplorer.Infrastructure
{
    public class BaseService
    {
        public BaseService(AppDatabaseContext dbContext)
        {
            Db = dbContext;
        }

        public AppDatabaseContext Db { get; }
    }
}