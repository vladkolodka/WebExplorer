namespace WebExplorer.Infrastructure
{
    public class BaseService
    {
        public BaseService(AppDbContext dbContext)
        {
            Db = dbContext;
        }

        public AppDbContext Db { get; }
    }
}