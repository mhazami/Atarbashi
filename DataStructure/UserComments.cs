using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atarbashi.DataStructure
{
    [Table("UserComments", Schema = "Content")]
    public class UserComments
    {
        public UserComments()
        {
            Like = false;
            Confirm = false;
        }
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string ArticleId { get; set; }

        public virtual Article Article { get; set; }

        [Required, MaxLength(150)]
        public string Name { get; set; }

        public Guid? ParentId { get; set; }

        [Required]
        public string Comment { get; set; }

        [Required, MaxLength(10)]
        public string SaveDate { get; set; }

        [Required, MaxLength(5)]
        public string SaveTime { get; set; }

        public bool Confirm { get; set; }

        public bool Like { get; set; }

        [Required, MaxLength(16)]
        public string IP { get; set; }




    }
}
