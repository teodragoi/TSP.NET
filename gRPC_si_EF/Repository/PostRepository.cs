using System.Collections.Generic;
using System.Linq;
using PostComment;

namespace Repository
{
    public class PostRepository : IRepository<Post>
    {
        private readonly PostCommentContainer dbContext;

        public PostRepository()
        {
            dbContext = new PostCommentContainer();;
        }

        public void Add(Post model)
        {
            dbContext.Posts.Add(model);
            dbContext.SaveChanges();
        }

        public List<Post> GetAll()
            => dbContext.Posts.ToList();

        public Post GetById(int id)
            => dbContext.Posts.Find(id);
    }
}
