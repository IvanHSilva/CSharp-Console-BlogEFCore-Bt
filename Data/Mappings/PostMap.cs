using BlogEFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogEFCore.Data.Mappings;

public class PostMap : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        // Table
        builder.ToTable("Posts");

        // PrimaryKey
        builder.HasKey(p => p.Id);

        // Identity
        // builder.Property(p => p.Id).ValueGeneratedOnAdd().UseIdentityColumn();

        // Properties
        builder.Property(p => p.Title).IsRequired().HasColumnName("Title").HasDefaultValue("");
        builder.Property(p => p.Slug).IsRequired().HasColumnName("Slug").HasDefaultValue("");
        builder.Property(p => p.Summary).IsRequired().HasColumnName("Summary").HasDefaultValue("");
        builder.Property(p => p.Body).IsRequired().HasColumnName("Body").HasDefaultValue("");
        builder.Property(p => p.CreateDate).IsRequired().HasColumnName("CreateDate").HasDefaultValue(DateTime.Now.ToUniversalTime());
        //.HasColumnType("SMALLDATETIME").HasDefaultValueSql("GETDATE()");
        builder.Property(p => p.LastUpdateDate).IsRequired().HasColumnName("LastUpdateDate").HasDefaultValue(DateTime.Now.ToUniversalTime());

        // Index
        // builder.HasIndex(p => p.Slug, "IX_Post_Slug").IsUnique();

        // Relations
        builder.HasOne(p => p.Author).WithMany(p => p.Posts);
        //.HasConstraintName("FK_Post_Author").OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(p => p.Category).WithMany(p => p.Posts);
    }
}