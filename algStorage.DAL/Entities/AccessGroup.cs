using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algStorage.DAL.Entities
{
    public class AccessGroup
    {
        public int Id { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<Algorithm> Algoritms { get; set; }
        public AccessGroup()
        {
            Users = new List<User>();
            Algoritms = new List<Algorithm>();
        }
    }
}
