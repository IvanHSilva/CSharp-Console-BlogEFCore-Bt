using System.ComponentModel;
using BlogEFCore.Data;
using BlogEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            using DataContext context = new();

            // User user = new()
            // {
            //     Name = "Nazaré Leal",
            //     Email = "nazareleal@gmail.com",
            //     PasswordHash = "0145451321654ASGJUYTECSNZ",
            //     Bio = "Contadora",
            //     Image = "http://",
            //     Slug = "nazare-leal"
            // };
            // User user = context.Users.FirstOrDefault(u => u.Name.Contains("Nazaré"))!;
            // Category category = context.Categories.FirstOrDefault(c => c.Name.Contains("Excel"))!;

            // // Category category = new()
            // // {
            // //     Name = "Excel",
            // //     Slug = "excel"
            // // };

            // Post post = new()
            // {
            //     CategoryId = category.Id,
            //     AuthorId = user.Id,
            //     Title = "Tabelas Dinâmicas no Excel",
            //     Slug = "tabelas-dinâmicas-excel",
            //     CreateDate = DateTime.Now,
            //     LastUpdateDate = DateTime.Now
            // };

            // //context.Users.Add(user);
            // //context.Categories.Add(category);
            // context.Posts.Add(post);
            // context.SaveChanges();

            List<Post> posts = [.. context.Posts.AsNoTracking().Include(a => a.Author)
            .OrderByDescending(p => p.LastUpdateDate)];

            foreach (Post post in posts)
                Console.WriteLine($"{post.Title} - autor: {post.Author?.Name}");

            Console.WriteLine("");
        }
    }
}
