using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atarbashi.DataStructure
{
    [Table("SlideItem", Schema = "Gallery")]
    public class GalleryItem
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(500)]
        public string Title { get; set; }

        public string Description { get; set; }

        public bool Order { get; set; }

        public bool Enable { get; set; }

        public int FileId { get; set; }

        public File File { get; set; }

    }
}
