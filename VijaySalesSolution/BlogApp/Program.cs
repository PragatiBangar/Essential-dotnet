using BlogApp.DBContexts;
using BlogApp.Repositories;

using (var context = new BlogContext())
{
    Console.WriteLine("program started");
    BlogRepository repo = new BlogRepository(context);
    repo.ShowAll();
    repo.Insert();
}