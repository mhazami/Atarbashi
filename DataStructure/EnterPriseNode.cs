using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atarbashi.DataStructure
{
    [Table("EnterPriseNode", Schema = "Atarbashi")]
    public class EnterPriseNode
    {
        [Key]
        public Guid Id { get; set; }

        [Required,MaxLength(100)]
        public string FirstName { get; set; }

        [Required,MaxLength(100)]
        public string LastName { get; set; }

        [Required,MaxLength(300)]
        public string Email { get; set; }

        [MaxLength(11)]
        public string Mobile { get; set; }

        [MaxLength(11)]
        public string Tel { get; set; }

        [MaxLength(10)]
        public string BirthDate { get; set; }

        [MaxLength(11)]
        public string NationalCode { get; set; }
    }
}
