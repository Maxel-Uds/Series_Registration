using System;
using System.Collections.Generic;

namespace aplication
{
    public class SerieRepository : IRepository<Serie>
    {

        private List<Serie> serieList = new List<Serie>();

        public List<Serie> List()
        {
            return serieList;
        }

        public Serie ReturnById(int id)
        {
            return serieList[id];
        }

        public void Insert(Serie obj)
        {
            serieList.Add(obj);
        }

        public void Remove(int id)
        {
            serieList[id].Exclude();
        }

        public void Update(int id, Serie obj)
        {
            serieList[id] = obj;
        }

        public int Next()
        {
            return serieList.Count;
        }
    }
}