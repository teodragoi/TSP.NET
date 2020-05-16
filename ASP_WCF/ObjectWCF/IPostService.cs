using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using DbContext;

namespace ObjectWCF
{
    [ServiceContract]
    public interface IPostService : IService<Post>
    {
    }
}
