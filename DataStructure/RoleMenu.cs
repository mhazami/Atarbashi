using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atarbashi.DataStructure
{
    [Table("RoleMenu", Schema = "Security")]
    public class RoleMenu
    {
        [Key, Column(Order = 0)]
        public Guid RoleId { get; set; }
        public Role Role { get; set; }

        [Key, Column(Order = 1)]
        public Guid MenuId { get; set; }
        public Menu Menu { get; set; }
    }
}
