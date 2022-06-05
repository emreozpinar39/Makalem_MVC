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
    public class SubjectService : GenericService<Subject> , ISubjectService
    {
        private readonly ISubjectRepository repository;

        public SubjectService(ISubjectRepository _repository) : base(_repository)
        {
            repository = _repository;
        }


    }
}
