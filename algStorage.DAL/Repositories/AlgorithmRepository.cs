using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using algStorage.DAL.Entities;
using System.Data.Entity;
using algStorage.DAL.EF;

namespace algStorage.DAL.Repositories
{
    public class AlgorithmRepository : IRepository<Algorithm>
    {
        private AlgorithmStorageContext db;
        public void Create(Algorithm algorithm)
        {
            db.Algorithms.Add(algorithm);
        }

        public Algorithm Read(int id)
        {
            return db.Algorithms.Find(id);
        }

        public void Update(Algorithm algorithm)
        {
            db.Entry(algorithm).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Algorithm algorithm = db.Algorithms.Find(id);
            if (algorithm != null)
                db.Algorithms.Remove(algorithm);
        }

        public IEnumerable<Algorithm> GetAll()
        {
            return db.Algorithms;
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
