using System.Collections.Generic;
using DataAccess;
using DbContext;

namespace ObjectWCF
{
    public class CommentService : ICommentService
    {
        private readonly CommentRepository commentRepository;

        public CommentService()
        {
            commentRepository = new CommentRepository();
        }

        public void Add(Comment model)
        {
            commentRepository.Add(model);
        }

        public Comment GetById(int id)
            => commentRepository.GetById(id);

        public List<Comment> GetAll()
            => commentRepository.GetAll();


        public void Update(Comment model)
        {
            commentRepository.Update(model);
        }

        public void Delete(int id)
        {
            commentRepository.Delete(id);
        }
    }
}
