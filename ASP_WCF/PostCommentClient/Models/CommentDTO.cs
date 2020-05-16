using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceReferencePost;

namespace PostCommentClient.Models
{
    public class CommentDTO
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public int PostId { get; set; }

        public virtual Post Post { get; set; }
    }
}
