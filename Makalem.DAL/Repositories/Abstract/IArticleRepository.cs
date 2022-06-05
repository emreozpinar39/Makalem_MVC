using Makalem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makalem.DAL.Repositories.Abstract
{
    public interface IArticleRepository : IRepository<Article>
    {
        IEnumerable<Article> GetAllIncludeUsers();
        IEnumerable<Article> GetArticlesByUserId(int userId);
        Article GetArticleIncludeUser(int id);
    }
}
