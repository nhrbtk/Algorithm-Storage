using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algStorage.DAL_ADO.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Role { get; set; }

        public ICollection<Algorithm> Algorithms { get; set; }
        public ICollection<AccessGroup> AccessGroups { get; set; }
        public User()
        {
            Algorithms = new List<Algorithm>();

            AccessGroups = new List<AccessGroup>();
        }
    }
}
