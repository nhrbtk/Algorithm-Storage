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
    public class UserRepositoryEF : IRepository<User>
    {
        private AlgorithmStorageContext db;
        public UserRepositoryEF()
        {
            this.db = new AlgorithmStorageContext();
        }

        public virtual void Create(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public User Read(int id)
        {
            return db.Users.Find(id);
        }

        public void Update(User user)
        {
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            User user = db.Users.Find(id);
            if (user != null)
                db.Users.Remove(user);
            db.SaveChanges();
        }

        public virtual IEnumerable<User> GetAll()
        {
            return db.Users;
        }
       
    }
}
