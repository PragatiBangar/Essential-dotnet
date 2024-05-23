using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Entities
{
    public class Author
    {
        public int  Id { get; set; }
        public string Title { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}




