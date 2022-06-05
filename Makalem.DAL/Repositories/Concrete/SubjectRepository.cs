using Makalem.Core.Entities;
using Makalem.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makalem.DAL.Repositories.Concrete
{
    public class SubjectRepository : GenericRepository<Subject> , ISubjectRepository
    {
        private readonly ApplicationDbContext db;

        public SubjectRepository(ApplicationDbContext _db) : base(_db)
        {
            db = _db;
        }

    }
}
