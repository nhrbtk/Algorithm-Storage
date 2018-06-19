using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using algStorage.DAL_ADO.Domain;
using algStorage.DAL_ADO.Repositories;
using System.Data.Entity;
using algStorage.DAL.EF;

namespace algStorage.DAL.Repositories
{
    public class AlgorithmRepositoryEF : IRepository<Algorithm>
    {
        private AlgorithmStorageContext db;
        public AlgorithmRepositoryEF()
        {
            db = new AlgorithmStorageContext();
        }
        public void Create(Algorithm algorithm)
        {
            db.Algorithms.Add(algorithm);
            db.SaveChanges();
        }

        public Algorithm Read(int id)
        {
            return db.Algorithms.Find(id);
        }

        public void Update(Algorithm algorithm)
        {
            db.Entry(algorithm).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Algorithm algorithm = db.Algorithms.Find(id);
            if (algorithm != null)
                db.Algorithms.Remove(algorithm);
            db.SaveChanges();
        }

        public IEnumerable<Algorithm> GetAll()
        {
            return db.Algorithms;
        }
    }
}
