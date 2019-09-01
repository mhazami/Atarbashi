using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atarbashi.DataStructure
{
    [Table("User", Schema = "Security")]
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid EnterPriseNodeId { get; set; }

        public EnterPriseNode EnterPriseNode { get; set; }

        [Required, MaxLength(250)]
        public string Username { get; set; }

        [Required,MaxLength(250)]
        public string Password { get; set; }

        [NotMapped]
        public string RepeatPassword { get; set; }
    }
}
