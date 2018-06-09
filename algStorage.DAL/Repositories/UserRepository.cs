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
    public class UserRepository : IRepository<User>
    {
        private AlgorithmStorageContext db;
        public UserRepository()
        {
            this.db = new AlgorithmStorageContext();
        }

        public void Create(User user)
        {
            db.Users.Add(user);
        }

        public User Read(int id)
        {
            return db.Users.Find(id);
        }

        public void Update(User user)
        {
            db.Entry(user).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            User user = db.Users.Find(id);
            if (user != null)
                db.Users.Remove(user);
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users;
        }
        
        public void Save()
        {
            db.SaveChanges(); 
        }
    }
}
