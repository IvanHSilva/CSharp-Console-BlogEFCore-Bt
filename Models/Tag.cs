using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("[Tags]")]
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
    }
}
