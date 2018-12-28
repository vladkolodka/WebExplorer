using System.Threading.Tasks;
using WebExplorer.Entities;

namespace WebExplorer.Services
{
    public interface IFolderAliasService
    {
        Task<Folder> FindByPath(string alias);
    }
}