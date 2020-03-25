using PostComment;
using System;
using System.Collections.Generic;

namespace ObjectWCF
{
    public class PostComment : IPostComment
    {
        public Comment UpdateComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Post UpdatePost(Post post)
        {
            return post.UpdatePost(post);
        }

        bool InterfaceComment.AddComment(Comment comment)
        {
            return comment.AddComment();
        }

        bool InterfacePost.AddPost(Post post)
        {
            return post.AddPost();
        }

        int InterfacePost.DeletePost(int id)
        {
            var post = new Post();
            return post.DeletePost(id);
        }

        Comment InterfaceComment.GetCommentById(int id)
        {
            var comment = new Comment();
            return comment.GetCommentById(id);
        }

        Post InterfacePost.GetPostById(int id)
        {
            var post = new Post();
            Console.WriteLine("GetPostById. Id = {0}", id);
            post = post.GetPostById(id);
            Console.WriteLine("Post returnat. Id = {0}, Description = {1}", post.PostId, post.Description);

            return post;
        }

        List<Post> InterfacePost.GetPosts()
        {
            var post = new Post();
            return post.GetAllPosts();
        }

    }
}
