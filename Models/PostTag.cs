using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("[PostsTags]")]
    public class PostTag
    {
        public int PostId { get; set; }
        public int TagId { get; set; }
    }
}
