using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using WebExplorer.Infrastructure;

namespace WebExplorer.Services.Implementation
{
    public class FolderAliasService : BaseService, IFolderAliasService
    {
        public FolderAliasService(AppDatabaseContext dbContext) : base(dbContext)
        {
        }

        public async Task<Folder> FindByPath(string alias)
        {
            // just in case
            if (string.IsNullOrWhiteSpace(alias))
            {
                throw new ApplicationException("Bad path.");
            }

            if (alias.EndsWith("/")) alias = alias.Substring(0, alias.Length - 1);

            var folder = (await Db.Aliases.Include(a => a.Folder.Children.Select(f => f.Alias))
                .FirstOrDefaultAsync(a => a.Path.Equals(alias)).ConfigureAwait(false))?.Folder;

            return folder;
        }
    }
}