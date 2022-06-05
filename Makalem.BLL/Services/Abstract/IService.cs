using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makalem.BLL.Services.Abstract
{
    public interface IService<T> where T:class
    {
        //tablo içindeki herşeyi, getirir
        IEnumerable<T> GetAll();

        //tablo içinde girilen id ye sahip herşeyi getirir
        T GetById(int id);

        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
