using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atarbashi.DataStructure
{
    [Table("File", Schema = "Content")]
    public class File
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public byte[] Content { get; set; }

        public byte Size { get; set; }

        [Required, MaxLength(250)]
        public string FileName { get; set; }

        [Required, MaxLength(10)]
        public string Extension { get; set; }

        public byte Order { get; set; }

        public string Alt { get; set; }

    }
}
