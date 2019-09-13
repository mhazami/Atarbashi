using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Atarbashi.DataStructure.Tools.Enums;

namespace Atarbashi.DataStructure
{
    [Table("Slider", Schema = "Gallery")]
    public class Slider
    {
        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(150)]
        public string Title { get; set; }

        public bool Enable { get; set; }

        public SliderType Type { get; set; }

        public ICollection<GalleryItem> SlideItemId { get; set; }
    }
}
