using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atarbashi.DataStructure
{
    [Table("Menu", Schema = "Security")]
    public class Menu
    {
        public Menu()
        {
            Enable = false;
            IsShow = false;
        }

        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(100)]
        public string Title { get; set; }

        public byte Order { get; set; }

        public Guid ParentId { get; set; }

        public bool IsShow { get; set; }

        public bool Enable { get; set; }
    }
}
