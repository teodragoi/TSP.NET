using System.Collections.Generic;
using System.Linq;
using PostComment;

namespace Repository
{
    public class CommentRepository : IRepository<Comment>
    {
        private readonly PostCommentContainer dbContext;

        public CommentRepository()
        {
            dbContext = new PostCommentContainer();
        }

        public void Add(Comment model)
        {
            dbContext.Comments.Add(model);
            var post = dbContext.Posts.Find(model.PostId);
            post.Comments.Add(model);

            dbContext.SaveChanges();
        }

        public List<Comment> GetAll()
            => dbContext.Comments.ToList();

        public Comment GetById(int id)
            => dbContext.Comments.Find(id);
    }
}
