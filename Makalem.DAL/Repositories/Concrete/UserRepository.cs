using Makalem.Core.Entities;
using Makalem.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makalem.DAL.Repositories.Concrete
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly ApplicationDbContext db;

        public UserRepository(ApplicationDbContext _db) : base(_db)
        {
            db = _db;
        }

        public User CheckUser(User user)
        {
            User _user = db.Users.FirstOrDefault(a => a.Email == user.Email && a.Password == user.Password);
            if (_user ==null)
            {
                return _user;
            }

            return _user;
        }
    }
}
