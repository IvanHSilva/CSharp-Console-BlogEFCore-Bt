using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogEFCore.Models
{
    //[Table("[Categories]")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(80)]
        [Column("Name", TypeName = "NVARCHAR")]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(80)]
        [Column("Slug", TypeName = "VARCHAR")]
        public string Slug { get; set; } = string.Empty;
    }
}
