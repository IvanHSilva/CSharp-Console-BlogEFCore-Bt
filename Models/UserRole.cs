using System.ComponentModel.DataAnnotations.Schema;

namespace BlogEFCore.Models
{
    [Table("[UsersRoles]")]
    public class UserRole
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
