using Makalem.BLL.Services.Abstract;
using Makalem.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makalem.BLL.Services.Concrete
{
    public class GenericService<T> : IService<T> where T : class
    {
        private readonly IRepository<T> repository;
        public GenericService(IRepository<T> _repository)
        {
            this.repository = _repository;
        }
        public IEnumerable<T> GetAll()
        {
            return repository.GetAll();
        }

        public T GetById(int id)
        {
            return repository.GetById(id);
        }

        public bool Add(T entity)
        {
            return repository.Add(entity);
        }

        public bool Delete(T entity)
        {
            return repository.Delete(entity);
        }

       
        public bool Update(T entity)
        {
            return repository.Update(entity);
        }
    }
}
