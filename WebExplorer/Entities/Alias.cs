﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebExplorer.Entities
{
    public class Alias
    {
        private const int MaxUrlLength = 2000;

        public int Id { get; set; }

        [Index("IX_Alias_Path", IsUnique = true)]
        [MaxLength(MaxUrlLength)]
        public string Path { get; set; }

        public int FolderId { get; set; }

        [Required] public Folder Folder { get; set; }
    }
}