using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RepoService : IRepoService
    {
        private readonly IRequestPathAccessor _userAccessor;

        public RepoService(IRequestPathAccessor userAccessor)
        {
            _userAccessor = userAccessor;
        }

        public void LogRequestPath()
        {
            // get path 
            var path = _userAccessor.GetRequestPath();
            Console.WriteLine(path);
        }
    }
}
