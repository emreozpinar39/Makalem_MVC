using Makalem.Core.Entities;
using Makalem.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makalem.DAL.Repositories.Concrete
{
    public class ArticleRepository : GenericRepository<Article>, IArticleRepository
    {
        private readonly ApplicationDbContext db;
        public ArticleRepository(ApplicationDbContext _db) : base(_db)
        {
            db = _db;
        }

        public IEnumerable<Article> GetAllIncludeUsers()
        {
            return db.Articles.Include(a => a.User);
        }

        public Article GetArticleIncludeUser(int id)
        {
            return db.Articles.Include(a => a.User).FirstOrDefault(b => b.Id == id);
        }

        public IEnumerable<Article> GetArticlesByUserId(int userId)
        {
            return db.Articles.Where(a => a.UserId == userId).ToList();
        }

        
    }
}
