using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atarbashi.DataStructure
{
    [Table("Customer", Schema = "Atarbashi")]
    public class Customer
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid EnterPriseNodeId { get; set; }

        public EnterPriseNode EnterPriseNode { get; set; }

        [Required, MaxLength(16)]
        public string IPAddress { get; set; }

        [Required, MaxLength(150)]
        public string Usename { get; set; }

        [Required, MaxLength(150)]
        public string Password { get; set; }

        [Required, MaxLength(10)]
        public string RegisterDate { get; set; }

        [Required, MaxLength(5)]
        public string RegisterTime { get; set; }


    }
}
