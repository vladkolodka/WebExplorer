using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebExplorer.Entities
{
    public class Alias
    {
        public virtual Folder Folder { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(800)]
        public string Path { get; set; }
    }
}