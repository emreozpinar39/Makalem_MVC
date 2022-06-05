using Makalem.BLL.Services.Abstract;
using Makalem.Core.Entities;
using Makalem.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makalem.BLL.Services.Concrete
{
    public class ArticleService : GenericService<Article>, IArticleService
    {
        private readonly IArticleRepository repository;
        public ArticleService(IArticleRepository _repository ) : base(_repository)
        {
            repository = _repository;
        }

        public IEnumerable<Article> GetAllIncludeUsers()
        {
            return repository.GetAllIncludeUsers();
        }

        public Article GetArticleIncludeUser(int id)
        {
            return repository.GetArticleIncludeUser(id);
        }

        public IEnumerable<Article> GetArticlesByUserId(int userId)
        {
            return repository.GetArticlesByUserId(userId);
        }
    }
}
