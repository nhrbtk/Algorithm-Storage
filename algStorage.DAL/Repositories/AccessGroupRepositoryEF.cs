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
    public class AccessGroupRepositoryEF:IRepository<AccessGroup>
    {
        private AlgorithmStorageContext db;
        public AccessGroupRepositoryEF()
        {
            db = new AlgorithmStorageContext();
        }
        public void Create(AccessGroup accessGroup)
        {
            db.AccessGroups.Add(accessGroup);
            db.SaveChanges();
        }

        public AccessGroup Read(int id)
        {
            return db.AccessGroups.Find(id);
        }

        public void Update(AccessGroup accessGroup)
        {
            db.Entry(accessGroup).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            AccessGroup accessGroup = db.AccessGroups.Find(id);
            if (accessGroup != null)
                db.AccessGroups.Remove(accessGroup);
            db.SaveChanges();
        }

        public IEnumerable<AccessGroup> GetAll()
        {
            return db.AccessGroups;
        }

    }
}
