using System.ComponentModel.DataAnnotations.Schema;

namespace BlogEFCore.Models
{
    [Table("[PostsTags]")]
    public class PostTag
    {
        public int PostId { get; set; }
        public int TagId { get; set; }
    }
}
