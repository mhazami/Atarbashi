using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atarbashi.DataStructure
{
    [Table("Configuration", Schema = "Security")]
    public class Configuration
    {
        [Key]
        public Guid Id { get; set; }

        
    }
}
