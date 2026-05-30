using PersonalBlog;
using System;

var blog = new BlogManager();

Console.WriteLine("--- Мій Особистий Блог ---");

blog.AddPost("Мій перший пост", "Привіт, світе! Це мій консольний блог.");
blog.AddPost("Навчання C#", "Модульні тести — це дуже корисно.");

Console.WriteLine($"Всього постів: {blog.GetCount()}");

foreach (var post in blog.GetAllPosts())
{
    Console.WriteLine($"[{post.Id}] {post.Title}");
}