using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceReferencePost;

namespace PostCommentClient.Models
{
    public class PostDTO
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public virtual ICollection<CommentDTO> Comments { get; set; }
    }
}
