using System.Collections.Generic;

namespace aplication
{
    public interface IRepository<T>
    {
         List<T> list();
         T ReturnById(int Id);
         void Insert(T obj);
         void Remove(int Id);
         void Update(int Id, T obj);
         int Next();
    }
}