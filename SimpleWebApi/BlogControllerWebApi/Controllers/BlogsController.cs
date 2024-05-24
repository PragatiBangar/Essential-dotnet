using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BloggersWebAPI.Entities;

namespace BlogControllerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {

        [HttpGet]
        public List<Post> Get()
        {
            List<Post> posts = new List<Post>
            {
                new Post { Title = "Job Guarantee Course: A Delusion.", Content = "sdfjlasjflasjldfjsaldfjlsadjflsadj" },
                new Post { Title = "Are we on right Path?", Content = "sdfyutyutyu 888888888888888888888888 adj" },
             };
            return posts;
        }
    }
}
