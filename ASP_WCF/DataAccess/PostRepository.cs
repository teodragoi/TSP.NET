using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using DbContext;

namespace DataAccess
{
    public class PostRepository : IRepository<Post>
    {
        private readonly PostCommentContainer dbContext;

        public PostRepository()
        {
            dbContext = new PostCommentContainer();
        }

        public void Add(Post model)
        {
            dbContext.Posts.Add(model);
            dbContext.SaveChanges();
        }

        public Post GetById(int id)
            => dbContext.Posts.Find(id);

        public List<Post> GetAll()
            => dbContext.Posts.ToList();


        public void Update(Post model)
        {
            var post = dbContext.Posts.Find(model.Id);

            post = new Post()
            {
                Id = model.Id,
                Content = model.Content,
                Comments = model.Comments
            };
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var post = dbContext.Posts.Find(id);
            dbContext.Posts.Remove(post);
            dbContext.SaveChanges();
        }
    }
}
