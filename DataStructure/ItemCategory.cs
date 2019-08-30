using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atarbashi.DataStructure
{
    [Table("ItemCategory", Schema = "Atarbashi")]
    public class ItemCategory
    {
        public ItemCategory()
        {
            Enable = false;
        }

        [Key]
        public int Id { get; set; }

        [Required,MaxLength(100)]
        public string Title { get; set; }

        public bool Enable { get; set; }
    }
}
