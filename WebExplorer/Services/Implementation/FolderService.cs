using WebExplorer.Infrastructure;

namespace WebExplorer.Services.Implementation
{
    public class FolderService : BaseService, IFolderService
    {
        public FolderService(AppDbContext dbContext) : base(dbContext)
        {
        }


    }
}