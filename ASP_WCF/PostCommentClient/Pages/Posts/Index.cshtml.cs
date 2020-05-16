using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServiceReferencePost;
using ServiceReferenceComment;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PostCommentClient.Models;

namespace PostCommentClient.Pages.Posts
{
    public class IndexModel : PageModel
    {
        PostServiceClient postClient = new PostServiceClient();
        public List<PostDTO> Posts { get; set; }

        public IndexModel()
        {
            Posts = new List<PostDTO>();
        }

        public void OnGet()
        {
        }

        public async Task OnGetAsync()
        {
            var posts = await postClient.GetAllAsync();
            foreach (var post in posts)
            {
                var pd = new PostDTO()
                {
                    Id = post.Id,
                    Content = post.Content,
                };
                foreach (var comment in post.Comments)
                {
                    var cdto = new CommentDTO()
                    {
                        Id = comment.Id,
                        Content = comment.Content,
                        PostId = comment.PostId
                    };
                    pd.Comments.Add(cdto);
                }
                Posts.Add(pd);
            }
        }
    }
}