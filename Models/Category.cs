using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("[Categories]")]
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
    }
}
