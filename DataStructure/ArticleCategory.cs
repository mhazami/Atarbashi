using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atarbashi.DataStructure
{
    [Table("ArticleCategory", Schema = "Content")]
    public class ArticleCategory
    {
        public ArticleCategory()
        {
            Enable = false;
        }
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public byte Order { get; set; }


        public bool Enable { get; set; }
    }
}
