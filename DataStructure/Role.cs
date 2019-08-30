using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atarbashi.DataStructure
{
    [Table("Role", Schema = "Security")]
    public class Role
    {
        public Role()
        {
            Enable = false;
        }

        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(100)]
        public string Title { get; set; }

        public bool Enable { get; set; }
    }
}
