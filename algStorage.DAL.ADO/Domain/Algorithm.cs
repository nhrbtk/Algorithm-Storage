using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algStorage.DAL_ADO.Domain
{
    public class Algorithm
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<AccessGroup> AccessGroups { get; set; }
        public Algorithm()
        {
            AccessGroups = new List<AccessGroup>();
        }
    }
}
