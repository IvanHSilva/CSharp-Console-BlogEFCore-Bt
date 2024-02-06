using BlogEFCore.Data;
using BlogEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            using (var context = new DataContext())
            {
                // INSERT
                // Tag tag = new() { Name = "EFCore", Slug = "ef-core" };
                // context.Tags.Add(tag);
                // context.SaveChanges();

                // UPDATE
                // Tag tag = context.Tags.FirstOrDefault(t => t.Id == 6)!;
                // tag.Name = ".NET EFCore";
                // tag.Slug = "net-efcore";
                // context.Update(tag);
                // context.SaveChanges();

                // DELETE
                // Tag tag = context.Tags.FirstOrDefault(t => t.Id == 6)!;
                // if (tag != null)
                // {
                //     context.Remove(tag);
                //     context.SaveChanges();
                // }

                Console.WriteLine($"Tags:");
                List<Tag> tags = [.. context.Tags.AsNoTracking().ToList()];
                //.Where(t => t.Name.Contains("NET"))];
                foreach (var tag in tags)
                {
                    Console.WriteLine($"{tag.Name} - {tag.Slug}");
                }
                Console.WriteLine("");
            };
        }
    }
}
