using System.Collections.Generic;
using System.ServiceModel;
using DbContext;

namespace ObjectWCF
{
    [ServiceContract]
    public interface ICommentService : IService<Comment>
    {
    }
}
