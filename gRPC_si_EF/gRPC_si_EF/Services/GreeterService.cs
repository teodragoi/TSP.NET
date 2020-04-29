using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using gRPC_si_EF.Services;
using Microsoft.Extensions.Logging;
using PostComment;
using Repository;

namespace gRPC_si_EF
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }
    }

    public class PostsService : IService<Post>
    {
        private readonly IRepository<Post> postRepository;

        public PostsService()
        {
            postRepository = new PostRepository();
        }

        public void Add(Post model)
        {
            postRepository.Add(model);
        }

        public List<Post> GetAll()
            => postRepository.GetAll();

        public Post GetById(int id)
            => postRepository.GetById(id);
    }

    public class CommentsService : IService<Comment>
    {

        private readonly IRepository<Comment> commentRepository;

        public CommentsService()
        {
                commentRepository = new CommentRepository();
        }

        public void Add(Comment model)
        {
            commentRepository.Add(model);
        }

        public List<Comment> GetAll()
            => commentRepository.GetAll();

        public Comment GetById(int id)
            => commentRepository.GetById(id);
    }
}
