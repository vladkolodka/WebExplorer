using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebExplorer.Infrastructure
{
    public class Folder
    {
        public Folder()
        {
            Children = new HashSet<Folder>();
        }

        public virtual Alias Alias { get; set; }

        public ICollection<Folder> Children { get; set; }

        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        public virtual Folder Parent { get; set; }

        public int? ParentId { get; set; }
    }
}