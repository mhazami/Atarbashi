using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Atarbashi.DataStructure.Tools.Enums;

namespace Atarbashi.DataStructure
{
    [Table("Gallery", Schema = "Gallery")]
    public class Gallery
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(150)]
        public string Title { get; set; }

        public bool Enable { get; set; }

        public GalleryType Type { get; set; }

        public ICollection<GalleryItem> SlideItemId { get; set; }
    }
}
