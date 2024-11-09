using System.Collections.Generic;

namespace CSharpEgitimKampi301.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T entity);
        void Update(T entity);
        void DeleteById(int id);
        List<T> GetAll();
        T GetById(int id);
    }
}
