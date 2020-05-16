using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DbContext;

namespace ObjectWCF
{
    public class PostService : IPostService
    {
        private readonly PostRepository postRepository;

        public PostService()
        {
            postRepository = new PostRepository();
        }

        public void Add(Post model)
        {
            postRepository.Add(model);
        }

        public Post GetById(int id)
            => postRepository.GetById(id);

        public List<Post> GetAll()
            => postRepository.GetAll();


        public void Update(Post model)
        {
            postRepository.Update(model);
        }

        public void Delete(int id)
        {
            postRepository.Delete(id);
        }
    }
}
