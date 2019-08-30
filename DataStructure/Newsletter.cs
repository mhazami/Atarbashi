using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atarbashi.DataStructure
{
    [Table("Newsletter", Schema = "Atarbashi")]
    public class Newsletter
    {
        [Key]
        public long Id { get; set; }

        [Required, MaxLength(300)]
        public string Email { get; set; }

        [Required, MaxLength(10)]
        public string SaveDate { get; set; }

        [Required, MaxLength(5)]
        public string SaveTime { get; set; }
    }
}
