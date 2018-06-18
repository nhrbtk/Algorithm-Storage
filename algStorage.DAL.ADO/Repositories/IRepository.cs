using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algStorage.DAL.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        void Create(T item);
        T Read(int id);
        void Update(T item);
        void Delete(int id);
        void Close();
    }
}
