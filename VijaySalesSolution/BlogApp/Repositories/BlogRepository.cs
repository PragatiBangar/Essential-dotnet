using BlogApp.DBContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlogApp.Entities;

namespace BlogApp.Repositories
{
    public class BlogRepository
    {
        private BlogContext _context;
        public BlogRepository(BlogContext context) {
            _context = context;
        }

        public void ShowAll()
        {
            using (var context = new BlogContext())
            {
                var blogswithposts = context.Author.Include(a => a.Blogs).ThenInclude(pa => pa.Posts).ToList();
               

                foreach (var author in blogswithposts)
                {
                    Console.WriteLine($"Author: {author.Title}");

                    foreach (var blog in author.Blogs)
                    {
                        Console.WriteLine($" - Blog: {blog.Title}");

                        foreach (var post in blog.Posts)
                        {
                           Console.WriteLine($" - Post: {post.Title}");
                            Console.WriteLine($" - description: {post.Description}");
                        }

                    }
                }
            }
        }

        public void Insert()
        {
            using (var context = new BlogContext())
            {
                var author = new Author { Title = "P.l deshpande" };
                author.Blogs = new List<Blog>
                {
                    new Blog { Title ="add blog",
                    Posts = new List<Post>
                    {
                    new Post { Title ="add Post"},
                    new Post { Title ="add"},

                    }} ,

                    new Blog { Title ="add",
                    Posts = new List<Post>
                    {
                    new Post { Title ="add Post"},
                    new Post { Title ="add"},

                    }}
                };
            }
        }
    }
}
