using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebExplorer.Entities
{
    public class Folder
    {
        public int Id { get; set; }

        [Required] public string Name { get; set; }

        public virtual Folder Parent { get; set; }

        public int? ParentId { get; set; }

        public virtual ICollection<Folder> Children { get; set; } = new List<Folder>();
    }
}