using System;
using System.Data.Entity;
using System.Threading.Tasks;
using WebExplorer.Entities;
using WebExplorer.Infrastructure;

namespace WebExplorer.Services.Implementation
{
    public class FolderAliasService : BaseService, IFolderAliasService
    {
        public FolderAliasService(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Folder> FindByPath(string alias)
        {
            if (string.IsNullOrWhiteSpace(alias)) throw new ApplicationException("Bad path.");

            if (alias.EndsWith("/")) alias = alias.Substring(0, alias.Length - 1);

            var folder = (await Db.Aliases.Include(a => a.Folder.Children)
                .FirstOrDefaultAsync(a => a.Path.Equals(alias)))?.Folder;

            return folder;
        }
    }
}