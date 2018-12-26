namespace WebExplorer.Infrastructure
{
    public class BaseService
    {
        public AppDbContext Db { get; }

        public BaseService(AppDbContext dbContext)
        {
            Db = dbContext;
        }
    }
}