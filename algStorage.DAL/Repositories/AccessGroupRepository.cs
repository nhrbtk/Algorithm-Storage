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
    public class AccessGroupRepository:IRepository<AccessGroup>
    {
        private AlgorithmStorageContext db;

        public void Create(AccessGroup accessGroup)
        {
            db.AccessGroups.Add(accessGroup);
        }

        public AccessGroup Read(int id)
        {
            return db.AccessGroups.Find(id);
        }

        public void Update(AccessGroup accessGroup)
        {
            db.Entry(accessGroup).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            AccessGroup accessGroup = db.AccessGroups.Find(id);
            if (accessGroup != null)
                db.AccessGroups.Remove(accessGroup);
        }

        public IEnumerable<AccessGroup> GetAll()
        {
            return db.AccessGroups;
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
