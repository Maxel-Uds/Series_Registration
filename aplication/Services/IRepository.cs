using System.Collections.Generic;

namespace aplication
{
    public interface IRepository<T>
    {
        public List<T> List();
        public T ReturnById(int id);
        public void Insert(T obj);
        public void Remove(int id);
        public void Update(int id, T obj);
        public int Next();
    }
}