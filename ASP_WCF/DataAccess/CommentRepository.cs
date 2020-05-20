using System.Collections.Generic;
using System.Linq;
using DbContext;

namespace DataAccess
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
            dbContext.SaveChanges();
        }

        public Comment GetById(int id)
            => dbContext.Comments.Find(id);

        public List<Comment> GetAll()
            => dbContext.Comments.ToList();


        public void Update(Comment model)
        {
            var comment = dbContext.Comments.Find(model.Id);

            comment = new Comment()
            {
                Id = model.Id,
                Content = model.Content,
                PostId = model.PostId,
                Post = model.Post
            };

            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var comment = dbContext.Comments.Find(id);
            dbContext.Comments.Remove(comment);
            dbContext.SaveChanges();
        }
    }
}
