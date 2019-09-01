using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atarbashi.DataStructure
{
    [Table("Article", Schema = "Content")]
    public class Article
    {
        public Article()
        {
            Enable = false;
        }

        [Key]
        public string Title { get; set; }

        [Required]
        public string Abstract { get; set; }

        [Required]
        public string Orginal { get; set; }

        public bool Enable { get; set; }

        public ICollection<File> FileId { get; set; }

        public string KeyWords { get; set; }

        public int ArticleCategoryId { get; set; }
        public ArticleCategory ArticleCategory { get; set; }

        public bool IsTrend { get; set; }


    }
}
