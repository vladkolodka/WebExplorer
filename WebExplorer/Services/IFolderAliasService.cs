using System.Threading.Tasks;
using WebExplorer.Entities;
using WebExplorer.Infrastructure;

namespace WebExplorer.Services
{
    public interface IFolderAliasService
    {
        Task<Folder> FindByPath(string alias);
    }
}