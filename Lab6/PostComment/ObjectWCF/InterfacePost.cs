using PostComment;
using System.Collections.Generic;
using System.ServiceModel;

namespace ObjectWCF
{
    [ServiceContract]
    interface InterfacePost
    {
        [OperationContract]
        bool AddPost(Post post);

        [OperationContract]
        Post GetPostById(int id);

        [OperationContract]
        Post UpdatePost(Post post);

        [OperationContract]
        int DeletePost(int id);

        [OperationContract]
        List<Post> GetPosts();
    }

    [ServiceContract]
    interface InterfaceComment
    {
        [OperationContract]
        bool AddComment(Comment comment);

        [OperationContract]
        Comment UpdateComment(Comment comment);

        [OperationContract]
        Comment GetCommentById(int id);
    }

    [ServiceContract]
    interface IPostComment: InterfacePost, InterfaceComment
    {
    }
}
