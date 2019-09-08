using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atarbashi.DataStructure
{
    [Table("UserRole", Schema = "Security")]
    public class UserRole
    {
        [Key, Column(Order = 0)]
        public Guid UserId { get; set; }
        public User User { get; set; }


        [Key, Column(Order = 1)]
        public Guid RoleId { get; set; }
        public Role Role { get; set; }
    }
}
