using Makalem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makalem.BLL.Services.Abstract
{
    public interface IArticleService : IService<Article>
    {
        IEnumerable<Article> GetAllIncludeUsers();
        IEnumerable<Article> GetArticlesByUserId(int userId);
        Article GetArticleIncludeUser(int id);
    }
}
